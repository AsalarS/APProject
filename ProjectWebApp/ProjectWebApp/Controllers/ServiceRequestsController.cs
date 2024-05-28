using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HomeCareObjects.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;

namespace HomeCareWebApp.Controllers
{
    public class ServiceRequestsController : Controller
    {
        private readonly HomeCareDBContext _context;
        private Notification notification; //This is for the customer
        private Notification notificationTec; //This is for the technician


        public ServiceRequestsController(HomeCareDBContext context)
        {
            _context = context;
            notification = new Notification();
            notificationTec = new Notification();
        }
        /// <summary>
        /// Create a notification object for customer
        /// </summary>
        /// <param name="text"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        private void addNotification(string text, string status, string type, int id)
        {
            notification.Status = status;
            notification.NotificationText = text;
            notification.Type = type;
            notification.UserId = id;
            _context.Notifications.Add(notification);
        }


        // GET: ServiceRequests
        [Authorize]
        public async Task<IActionResult> Index(string SearchString)
        {
            var userEmail = User.Identity.GetUserName();
            IEnumerable<ServiceRequest> serviceReqs = null;
            //Get requests related to customer
            if (User.IsInRole("User"))
            {
                serviceReqs = _context.ServiceRequests.Include(s => s.Customer).Include(s => s.Service).Include(s => s.Technician).Where(s => s.Customer.Email == userEmail);
            }
            //Get requests related to technican
            else if (User.IsInRole("Technician"))
            {
                serviceReqs = _context.ServiceRequests.Include(s => s.Customer).Include(s => s.Service).Include(s => s.Technician).Where(s => s.Technician.Email == userEmail);
            }
            //Get requests related to manager 
            else if (User.IsInRole("Manager"))
            {
                serviceReqs = _context.ServiceRequests.Include(s => s.Customer).Include(s => s.Service).Include(s => s.Technician).Where(s => s.Service.Category.Manager.Email == userEmail);
            }
            //Get all requests for admin
            else if (User.IsInRole("Admin"))
            {
                serviceReqs = _context.ServiceRequests.Include(s => s.Customer).Include(s => s.Service).Include(s => s.Technician);

            }
            //check if search bar has value
            if (!String.IsNullOrEmpty(SearchString))
            {
                serviceReqs = serviceReqs.Where(x => x.RequestDescription!.Contains(SearchString));
            }
            return View(serviceReqs);
        }

        // GET: ServiceRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ServiceRequests == null)
            {
                return NotFound();
            }

            var serviceRequest = await _context.ServiceRequests
                .Include(s => s.Customer)
                .Include(s => s.Service)
                .Include(s => s.Technician)
                .FirstOrDefaultAsync(m => m.RequestId == id);
            if (serviceRequest == null)
            {
                return NotFound();
            }

            return View(serviceRequest);
        }

        // GET: ServiceRequests/Create
        public IActionResult Create()
        {
            
            var userEmail = User.Identity.GetUserName();//to get the ID
            ViewData["CustomerId"] = new SelectList(_context.Users.Where(x => x.Email == userEmail), "UserId", "FullName");//return the logged in customer FullName 
            ViewData["ServiceId"] = new SelectList(_context.Services, "ServiceId", "ServiceName"); //return service names
            return View();
        }

        // POST: ServiceRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RequestId,RequestDescription,DateNeeded,CustomerId,ServiceId")] ServiceRequest serviceRequest)
        {
            var userEmail = User.Identity.GetUserName();
            if (ModelState.IsValid)
            {
                serviceRequest.TechnicianId = null; // Set Technician Id to null (manager will assign later)
                serviceRequest.RequestDate = DateTime.Now; // Set Request Date to current time
                serviceRequest.RequestStatus = 1; // Set Request Status to 1 (Pending)
                _context.Add(serviceRequest);
                AddLog("Action", "Creating a service request", "None", "None", _context.Users.SingleOrDefault(x => x.Email == userEmail));
                addNotification("A new Service request have been created", "Unread", "New Service Request", serviceRequest.CustomerId);

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    AddLog("Exception", ex.Message, "None", "None", _context.Users.SingleOrDefault(x => x.Email == userEmail));
                    throw;
                }
                TempData["Success"] = "Request Created Successfully";
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Users, "UserId", "UserId", serviceRequest.CustomerId);
            ViewData["ServiceId"] = new SelectList(_context.Services, "ServiceId", "ServiceName", serviceRequest.ServiceId);
            return View(serviceRequest);
        }

        // GET: ServiceRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ServiceRequests == null)
            {
                return NotFound();
            }

            //var serviceRequest = await _context.ServiceRequests.FindAsync(id);
            var serviceRequest = await _context.ServiceRequests
        .Include(sr => sr.Service)
        .ThenInclude(s => s.Technicians)
        .FirstOrDefaultAsync(sr => sr.RequestId == id);
            if (serviceRequest == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Users, "UserId", "FullName", serviceRequest.CustomerId);
            ViewData["ServiceId"] = new SelectList(_context.Services, "ServiceId", "ServiceName", serviceRequest.ServiceId);
            //ViewData["TechnicianId"] = new SelectList(_context.Users.Where(x => x.UserRole == "Technician"), "UserId", "FullName", serviceRequest.TechnicianId);
            // Check if the technician is assigned to the service
            /*var technicians = await _context.Users
                .Where(u => u.UserRole == "Technician" && u.ServicesNavigation.Any(s => s.ServiceId == serviceRequest.ServiceId))
                .Select(u => new { u.UserId, u.FullName })*/
            var technicians = _context.Users
                                     .Where(x => x.UserRole == "Technician")
                                     .Where(x => _context.ServiceRequests
                                                       .Where(sr => sr.Service.CategoryId == serviceRequest.Service.CategoryId)
                                                       .Select(sr => sr.TechnicianId)
                                                       .Contains(x.UserId))
                                                        .ToList();

            ViewData["TechnicianId"] = new SelectList(technicians, "UserId", "FullName", serviceRequest.TechnicianId);
            return View(serviceRequest);
        }

        // POST: ServiceRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,
            [Bind("RequestId,RequestDescription,RequestDate,DateNeeded,CustomerId,TechnicianId,ServiceId,RequestStatus")] ServiceRequest serviceRequest)
        {

            if (id != serviceRequest.RequestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    if (serviceRequest.TechnicianId != null)
                    {
                        serviceRequest.RequestStatus = 2;
                        notificationTec.NotificationText = "You have been assigned to a new Service Request";
                        notificationTec.Status = "Unread";
                        notificationTec.Type = "Assigned to a service request";
                        notificationTec.UserId = Convert.ToInt32(serviceRequest.TechnicianId);

                    }
                    else
                    {
                        serviceRequest.RequestStatus = 1;

                    }
                    var orgReq = _context.ServiceRequests.Find(id);
                    _context.Entry(orgReq).State = EntityState.Detached;
                    var userEmail = User.Identity.GetUserName();
                    _context.Update(serviceRequest);

                    if (serviceRequest.RequestStatus == 2)
                    {
                    string notificationText = "Your service request has an assigned technician and it is now Active";
                    string type = "Service Request Update";
                    string status = "Unread";
                    int uid = serviceRequest.CustomerId;
                    _context.Notifications.Add(notificationTec);
                        addNotification(notificationText,status,type,uid);
                    }
                    try
                    {
                       
                        await _context.SaveChangesAsync();
                        AddLog("Audit", "Updated service request",
                           $"Request Description: {orgReq.RequestDescription}. " +
                           $"Date Needed: {orgReq.DateNeeded.ToString()}. " +
                           $"Technician ID: {(orgReq.TechnicianId != null ? orgReq.TechnicianId.ToString() : "None")}"
                           ,
                           $"Request Description: {serviceRequest.RequestDescription}. " +
                           $"Date Needed: {serviceRequest.DateNeeded.ToString()}. " +
                           $"Technician ID: {(serviceRequest.TechnicianId != null ? serviceRequest.TechnicianId.ToString() : "None")}"

                           , _context.Users.SingleOrDefault(x => x.Email == userEmail));

                    }
                    catch (Exception ex)
                    {
                        AddLog("Exception", ex.Message, "None", "None", _context.Users.SingleOrDefault(x => x.Email == userEmail));
   
                        throw;
                    }
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceRequestExists(serviceRequest.RequestId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                TempData["Success"] = "Request Edited Successfully";
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Users, "UserId", "UserId", serviceRequest.CustomerId);
            ViewData["ServiceId"] = new SelectList(_context.Services, "ServiceId", "ServiceId", serviceRequest.ServiceId);
            ViewData["TechnicianId"] = new SelectList(_context.Users, "UserId", "UserId", serviceRequest.TechnicianId);
            return View(serviceRequest);
        }

        // GET: ServiceRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null || _context.ServiceRequests == null)
            {
                return NotFound();
            }

            var serviceRequest = await _context.ServiceRequests
                .Include(s => s.Customer)
                .Include(s => s.Service)
                .Include(s => s.Technician)
                .FirstOrDefaultAsync(m => m.RequestId == id);
            if (serviceRequest == null)
            {
                return NotFound();
            }

            return View(serviceRequest);
        }

        // POST: ServiceRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ServiceRequests == null)
            {
                return Problem("Entity set 'HomeCareDBContext.ServiceRequests'  is null.");
            }
            var serviceRequest = await _context.ServiceRequests.FindAsync(id);
            if (serviceRequest != null)
            {
                serviceRequest.RequestStatus = 4;
                _context.Update(serviceRequest);
                addNotification("Your service request has been canceled", "Unread", "Service Request Updatet", serviceRequest.CustomerId);

            }
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var userEmail = User.Identity.GetUserName();
                AddLog(ex.InnerException.Message, ex.Message, "None", "None", _context.Users.SingleOrDefault(x => x.Email == userEmail));
                throw;

            }
            TempData["Success"] = "Request Canceled Successfully";
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceRequestExists(int id)
        {
            return _context.ServiceRequests.Any(e => e.RequestId == id);
        }

        /// <summary>
        /// Marks the passed request as a completed request
        /// </summary>
        /// <param name="id">The ID of the request</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Completed(int id)
        {
            if (_context.ServiceRequests == null)
            {
                return Problem("Entity set 'HomeCareDBContext.ServiceRequests'  is null.");
            }
            var serviceRequest = await _context.ServiceRequests.FindAsync(id);
            if (serviceRequest != null)
            {
                var userEmail = User.Identity.GetUserName();
                int orgStatus = serviceRequest.RequestStatus;
                serviceRequest.RequestStatus = 3;
                _context.Update(serviceRequest);
                addNotification("Your service request has been completed", "Unread", "Service Request Update", serviceRequest.CustomerId);
                AddLog("Action", "Service Request Update", $"Original Request Status: {orgStatus}", "New Request Status: 3",_context.Users.SingleOrDefault(x => x.Email == userEmail));

            }
            try
            {
                await _context.SaveChangesAsync();
               
                
            }
            catch (Exception ex)
            {
                var userEmail = User.Identity.GetUserName();
                AddLog(ex.InnerException.Message, ex.Message, "None", "None", _context.Users.SingleOrDefault(x => x.Email == userEmail));
                throw;
            }
            TempData["Success"] = "Request Marked As Completed Successfully";
            return RedirectToAction(nameof(Index));
        }

        private void AddLog(string type, string message, string originalValues, string currentValues, User user)
        {
            int uid = user.UserId;
            Log log = new Log
            {
                Source = "Web App",
                DateTime = DateTime.Now,
                Type = type,
                Message = message,
                OriginalValues = originalValues,
                CurrentValues = currentValues,
                UserId = uid
            };
            _context.Logs.Add(log);
            _context.SaveChanges();

        }
    }

}
