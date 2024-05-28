using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HomeCareObjects.Model;
using HomeCareWebApp.ViewModels;

namespace HomeCareWebApp.Controllers
{
    public class ServicesController : Controller
    {
        private readonly HomeCareDBContext _context;
        private Notification notification;

        public ServicesController(HomeCareDBContext context)
        {
            _context = context;

        }

        // GET: Services
        public async Task<IActionResult> Index(string SearchString, string SearchCategory)
        {

            IEnumerable<Service> homeCareDBContext;
            homeCareDBContext = _context.Services.Include(x => x.Category.Manager).Include(s => s.Category).Include(s => s.Technician);

            if (!String.IsNullOrEmpty(SearchString)) //If the user entered something in the search bar
            {
                homeCareDBContext = homeCareDBContext.Where(x => x.ServiceName.Contains(SearchString));
            }
            if (!String.IsNullOrEmpty(SearchCategory)) //if the user used the search filter
            {
                homeCareDBContext = homeCareDBContext.Where(x => x.CategoryId == Convert.ToInt32(SearchCategory));
            }

            var catList = new SelectList(_context.Categories, "CategoryId", "CategoryName", SearchCategory); //Show the result
            ViewBag.catList = catList;


            return View(homeCareDBContext);
        }

        public async Task<IActionResult> TechsIndex(int id)
        {
            var techs = new TechniciansServicesViewModel
            {
                Service = _context.Services.FirstOrDefault(i => i.ServiceId == id),
                //Technicians = _context.Services.
            };
            return View();
        }
        // GET: Services/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .Include(s => s.Category)
                .Include(s => s.Technician)
                .FirstOrDefaultAsync(m => m.ServiceId == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // GET: Services/Create
        public IActionResult Create()
        {
            if (User.IsInRole("Admin")) //If admin, show all categories
            {
                ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");

            }
            else if (User.IsInRole("Manager")) //If manager, show categories assigned only 
            {
                ViewData["CategoryId"] = new SelectList(_context.Categories.Where(x => x.Manager.Email == User.Identity.Name), "CategoryId", "CategoryName");

            }
            ViewData["TechnicianId"] = new SelectList(_context.Users.Where(x => x.UserRole == "Technician"), "UserId", "Email");
            return View();
        }

        // POST: Services/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ServiceId,ServiceName,ServiceDescription,ServicePrice,CategoryId,TechnicianId")] Service service)
        {
            notification = new Notification();
            if (ModelState.IsValid)
            {
                _context.Add(service);
                notification.Status = "Unread";
                notification.NotificationText = "You have been assigned to a  new service";
                notification.Type = "Test";
                notification.UserId = Convert.ToInt32(service.TechnicianId);
                _context.Notifications.Add(notification); //add notification for the technician 
                try
                {
                    await _context.SaveChangesAsync();
                   //AddLog("Insert", "A new service have been inserted", "None", "None", Manager ID Should be here);
                    _context.SaveChanges();


                }
                catch (Exception)
                {

                    throw;
                }
                
                return RedirectToAction(nameof(Index));
            }
            if (User.IsInRole("Admin"))
            {
                ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", service.CategoryId);

            }
            else if (User.IsInRole("Manager"))
            {
                ViewData["CategoryId"] = new SelectList(_context.Categories.Where(x => x.Manager.Email == User.Identity.Name), "CategoryId", "CategoryName", service.CategoryId);

            }
            ViewData["TechnicianId"] = new SelectList(_context.Users, "UserId", "Email", service.TechnicianId);
            return View(service);
        }

        // GET: Services/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var service = await _context.Services.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }
            if (User.IsInRole("Admin"))
            {
                ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", service.CategoryId);

            }
            else if (User.IsInRole("Manager"))
            {
                ViewData["CategoryId"] = new SelectList(_context.Categories.Where(x => x.Manager.Email == User.Identity.Name), "CategoryId", "CategoryName", service.CategoryId);

            }
            ViewData["TechnicianId"] = new SelectList(_context.Users.Where(x => x.UserRole == "Technician"), "UserId", "Email", service.TechnicianId);
            return View(service);
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ServiceId,ServiceName,ServiceDescription,ServicePrice,CategoryId,TechnicianId")] Service service)
        {
            if (id != service.ServiceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(service);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceExists(service.ServiceId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            if (User.IsInRole("Admin"))
            {
                ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", service.CategoryId);

            }
            else if (User.IsInRole("Manager"))
            {
                ViewData["CategoryId"] = new SelectList(_context.Categories.Where(x => x.Manager.Email == User.Identity.Name), "CategoryId", "CategoryName", service.CategoryId);

            }
            ViewData["TechnicianId"] = new SelectList(_context.Users, "UserId", "Email", service.TechnicianId);
            return View(service);
        }

        // GET: Services/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Services == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .Include(s => s.Category)
                .Include(s => s.Technician)
                .FirstOrDefaultAsync(m => m.ServiceId == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Services == null)
            {
                return Problem("Entity set 'HomeCareDBContext.Services'  is null.");
            }
            var service = await _context.Services.FindAsync(id);
            if (service != null)
            {
                _context.Services.Remove(service);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceExists(int id)
        {
            return (_context.Services?.Any(e => e.ServiceId == id)).GetValueOrDefault();
        }

        private void AddLog(string type, string message, string originalValues, string currentValues, int uid)
        {
            Log log = new Log();
            log.Source = "Web App";
            log.DateTime = DateTime.Now;
            log.Type = type;
            log.Message = message;
            log.OriginalValues = originalValues;
            log.CurrentValues = currentValues;
            log.UserId = uid;
            _context.Logs.Add(log);

        }
    }
}
