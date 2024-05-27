﻿using System;
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
        private Notification notification;

        public ServiceRequestsController(HomeCareDBContext context)
        {
            _context = context;
            notification = new Notification();
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
            var userEmail = User.Identity.GetUserName();
            ViewData["CustomerId"] = new SelectList(_context.Users.Where(x => x.Email == userEmail), "UserId", "FullName");
            ViewData["ServiceId"] = new SelectList(_context.Services, "ServiceId", "ServiceName");
            return View();
        }

        // POST: ServiceRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RequestId,RequestDescription,DateNeeded,CustomerId,ServiceId")] ServiceRequest serviceRequest)
        {
            if (ModelState.IsValid)
            {
                serviceRequest.TechnicianId = null; // Set Technician Id to null (manager will assign later)
                serviceRequest.RequestDate = DateTime.Now; // Set Request Date to current time
                serviceRequest.RequestStatus = 1; // Set Request Status to 0 (Pending)
                _context.Add(serviceRequest);
                notification.Status = "Unread";
                notification.NotificationText = "A new Service request have been created";
                notification.Type = "New Service Request";
                notification.UserId = serviceRequest.CustomerId;
                _context.Notifications.Add(notification);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Users, "UserId", "UserId", serviceRequest.CustomerId);
            ViewData["ServiceId"] = new SelectList(_context.Services, "ServiceId", "ServiceId", serviceRequest.ServiceId);
            return View(serviceRequest);
        }

        // GET: ServiceRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ServiceRequests == null)
            {
                return NotFound();
            }

            var serviceRequest = await _context.ServiceRequests.FindAsync(id);
            if (serviceRequest == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Users, "UserId", "FullName", serviceRequest.CustomerId);
            ViewData["ServiceId"] = new SelectList(_context.Services, "ServiceId", "ServiceName", serviceRequest.ServiceId);
            ViewData["TechnicianId"] = new SelectList(_context.Users.Where(x => x.UserRole == "Technician"), "UserId", "FullName", serviceRequest.TechnicianId);
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
                    }


                    _context.Update(serviceRequest);
                    await _context.SaveChangesAsync();
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
                _context.ServiceRequests.Remove(serviceRequest);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceRequestExists(int id)
        {
            return _context.ServiceRequests.Any(e => e.RequestId == id);
        }
    }
}
