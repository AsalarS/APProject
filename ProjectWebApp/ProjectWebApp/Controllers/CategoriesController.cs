using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HomeCareObjects.Model;
using Microsoft.AspNetCore.Authorization;
using ProjectWebApp.ViewModels;
using HomeCareWebApp.ViewModels;

namespace HomeCareWebApp.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly HomeCareDBContext _context;

        public CategoriesController(HomeCareDBContext context)
        {
            _context = context;
        }

        // GET: Categories
        public async Task<IActionResult> Index(string SearchString)

        {
            IEnumerable<Category> categories;
            categories = _context.Categories.Include(c => c.Manager);

            if (!String.IsNullOrEmpty(SearchString))
            {
                categories = categories.Where(x => x.CategoryName!.Contains(SearchString));
            }


            return View(categories);
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .Include(c => c.Manager)
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }
            CategoryRequestsViewModel categoryRequestsViewModel = new CategoryRequestsViewModel
            {
                ActiveRequests = _context.ServiceRequests.Count(x => x.Service.CategoryId == category.CategoryId && x.RequestStatus == 2),
                Category = category,
                PendingRequests = _context.ServiceRequests.Count(x => x.Service.CategoryId == category.CategoryId && x.RequestStatus == 1),
                CompletedRequests = _context.ServiceRequests.Count(x => x.Service.CategoryId == category.CategoryId && x.RequestStatus == 3),
                OverdueRequests = _context.ServiceRequests.Count(x => x.Service.CategoryId == category.CategoryId && x.DateNeeded < DateTime.Now)
            };
            return View(categoryRequestsViewModel);
        }

        // GET: Categories/Create

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["ManagerId"] = new SelectList(_context.Users.Where(x => x.UserRole == "Manager"), "UserId", "Email");
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryId,CategoryName,Description,ManagerId")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ManagerId"] = new SelectList(_context.Users.Where(x => x.UserRole == "Manager"), "UserId", "Email", category.ManagerId);
            return View(category);
        }

        // GET: Categories/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            ViewData["ManagerId"] = new SelectList(_context.Users.Where(x => x.UserRole == "Manager"), "UserId", "Email", category.ManagerId);
            return View(category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryId,CategoryName,Description,ManagerId")] Category category)
        {
            if (id != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CategoryId))
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
            ViewData["ManagerId"] = new SelectList(_context.Users, "UserId", "Email", category.ManagerId);
            return View(category);
        }

        // GET: Categories/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .Include(c => c.Manager)
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Categories == null)
            {
                return Problem("Entity set 'HomeCareDBContext.Categories'  is null.");
            }
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return (_context.Categories?.Any(e => e.CategoryId == id)).GetValueOrDefault();
        }
    }
}
