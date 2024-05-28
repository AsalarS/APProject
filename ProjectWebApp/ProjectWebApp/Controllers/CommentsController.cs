using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HomeCareObjects.Model;
using Microsoft.AspNet.Identity;

namespace HomeCareWebApp.Controllers
{
    public class CommentsController : Controller
    {
        private readonly HomeCareDBContext _context;

        public CommentsController(HomeCareDBContext context)
        {
            _context = context;
        }

        // GET: Comments
        public async Task<IActionResult> Index()
        {
            var userEmail = User.Identity.GetUserName();
            IEnumerable<Comment> homeCareDBContext = null;
            if (User.IsInRole("User"))
            {
                homeCareDBContext = _context.Comments.Include(s => s.Request).ThenInclude(r => r.Customer).Where(s => s.Request.Customer.Email == userEmail);
            }
            //Get requests related to technican
            else if (User.IsInRole("Technician"))
            {
                homeCareDBContext = _context.Comments.Include(s => s.Request).ThenInclude(r => r.Technician).Where(s => s.Request.Technician.Email == userEmail);
            }
            //Get requests related to manager 
            else if (User.IsInRole("Manager"))
            {
                homeCareDBContext = _context.Comments.Include(s => s.Request).ThenInclude(r => r.Customer).Include(s => s.Request).ThenInclude(r => r.Service).ThenInclude(s => s.Category).ThenInclude(c => c.Manager).Where(s => s.Request.Service.Category.Manager.Email == userEmail);
            }
            //Get all requests for admin
            else if (User.IsInRole("Admin"))
            {
                homeCareDBContext = _context.Comments.Include(s => s.Request).ThenInclude(r => r.Customer).Include(s => s.Request).ThenInclude(r => r.Technician).Include(s => s.Request).ThenInclude(r => r.Service).ThenInclude(s => s.Category).ThenInclude(c => c.Manager);
            }
            return View(homeCareDBContext);
        }

        // GET: Comments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Comments == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments
                .Include(c => c.Request)
                .FirstOrDefaultAsync(m => m.CommentId == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // GET: Comments/Create
        public IActionResult Create()
        {
            var userEmail = User.Identity.GetUserName();
            if (User.IsInRole("User"))
            {
                ViewData["RequestId"] = new SelectList(_context.ServiceRequests.Where(x => x.Customer.Email == userEmail), "RequestId", "RequestId");
            }
            else if (User.IsInRole("Technician"))
            {

                ViewData["RequestId"] = new SelectList(_context.ServiceRequests.Where(x => x.Technician.Email == userEmail), "RequestId", "RequestId");
            }
            else if (User.IsInRole("Manager"))
            {
                ViewData["RequestId"] = new SelectList(_context.ServiceRequests.Where(x => x.Service.Category.Manager.Email == userEmail), "RequestId", "RequestId");

            }
            ViewData["UserId"] = new SelectList(_context.Users.Where(x => x.Email == userEmail), "UserId", "FullName");
            return View();
        }

        // POST: Comments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CommentId,CommentText,CommentDate,RequestId")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                comment.CommentDate = DateTime.Now;
                _context.Add(comment);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Comment Added Successfully";
                return RedirectToAction(nameof(Index));
            }
            ViewData["RequestId"] = new SelectList(_context.ServiceRequests, "RequestId", "RequestId", comment.RequestId);
            return View(comment);
        }

        // GET: Comments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Comments == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            ViewData["RequestId"] = new SelectList(_context.ServiceRequests, "RequestId", "RequestId", comment.RequestId);
            return View(comment);
        }

        // POST: Comments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CommentId,CommentText,CommentDate,RequestId")] Comment comment)
        {
            if (id != comment.CommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentExists(comment.CommentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                TempData["Success"] = "Comment Edited Successfully";
                return RedirectToAction(nameof(Index));
            }
            ViewData["RequestId"] = new SelectList(_context.ServiceRequests, "RequestId", "RequestId", comment.RequestId);
            return View(comment);
        }

        // GET: Comments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Comments == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments
                .Include(c => c.Request)
                .FirstOrDefaultAsync(m => m.CommentId == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // POST: Comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Comments == null)
            {
                return Problem("Entity set 'HomeCareDBContext.Comments'  is null.");
            }
            var comment = await _context.Comments.FindAsync(id);
            if (comment != null)
            {
                _context.Comments.Remove(comment);
            }
            
            await _context.SaveChangesAsync();
            TempData["Success"] = "Comment Deleted Successfully";
            return RedirectToAction(nameof(Index));
        }

        private bool CommentExists(int id)
        {
          return _context.Comments.Any(e => e.CommentId == id);
        }
    }
}
