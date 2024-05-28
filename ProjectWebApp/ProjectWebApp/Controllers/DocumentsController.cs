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
    public class DocumentsController : Controller
    {
        private readonly HomeCareDBContext _context;

        public DocumentsController(HomeCareDBContext context)
        {
            _context = context;
        }

        // GET: Documents
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userEmail = User.Identity.GetUserName();
            IEnumerable<Document> homeCareDBContext = null;
            if (User.IsInRole("User"))
            {
                homeCareDBContext = _context.Documents.Include(s => s.Request).ThenInclude(r => r.Customer).Where(s => s.Request.Customer.Email == userEmail);
            }
            //Get requests related to technican
            else if (User.IsInRole("Technician"))
            {
                homeCareDBContext = _context.Documents.Include(s => s.Request).ThenInclude(r => r.Customer).Include(s => s.Request).ThenInclude(r => r.Technician).Where(s => s.Request.Technician.Email == userEmail);
            }
            //Get requests related to manager 
            else if (User.IsInRole("Manager"))
            {
                homeCareDBContext = _context.Documents.Include(s => s.Request).ThenInclude(r => r.Customer).Include(s => s.Request).ThenInclude(r => r.Service).ThenInclude(s => s.Category).ThenInclude(c => c.Manager).Where(s => s.Request.Service.Category.Manager.Email == userEmail);
            }
            //Get all requests for admin
            else if (User.IsInRole("Admin"))
            {
                homeCareDBContext = _context.Documents.Include(s => s.Request).ThenInclude(r => r.Customer).Include(s => s.Request).ThenInclude(r => r.Technician).Include(s => s.Request).ThenInclude(r => r.Service).ThenInclude(s => s.Category).ThenInclude(c => c.Manager);
            }
            
            return View(homeCareDBContext);
        }

        // GET: Documents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Documents == null)
            {
                return NotFound();
            }

            var document = await _context.Documents
                .Include(d => d.Request)
                .FirstOrDefaultAsync(m => m.DocumentId == id);
            if (document == null)
            {
                return NotFound();
            }

            return View(document);
        }

        // GET: Documents/Create
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
            return View();
        }

        // POST: Documents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile file, int requestId)
        {
            if (ModelState.IsValid)
            {
                var filename = Path.GetFileNameWithoutExtension(file.FileName);
                var ext = Path.GetExtension(file.FileName);
                try
                {
                    Document document = new Document
                    {
                        DocumentName = filename,
                        UploadDate = DateTime.Now,
                        DocumentType = ext,
                        RequestId = requestId,
                    };
                    using (var dataStream = new MemoryStream())
                    {
                        await file.CopyToAsync(dataStream);
                        document.BinaryData = dataStream.ToArray();
                    }
                    _context.Add(document);
                    await _context.SaveChangesAsync();
                    TempData["Success"] = "Document Uploaded Successfully";
                    return RedirectToAction(nameof(Index));
                
                }catch(NullReferenceException ex)
                {
                    return BadRequest(ex);
                }
                catch(Exception ex) {
                    return BadRequest(ex.ToString());
                }
            }
            ViewData["RequestId"] = new SelectList(_context.ServiceRequests, "RequestId", "RequestId", requestId);
            return View(file);
        }

        // GET: Documents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Documents == null)
            {
                return NotFound();
            }

            var document = await _context.Documents
                .Include(d => d.Request)
                .FirstOrDefaultAsync(m => m.DocumentId == id);
            if (document == null)
            {
                return NotFound();
            }

            return View(document);
        }

        // POST: Documents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Documents == null)
            {
                return Problem("Entity set 'HomeCareDBContext.Documents'  is null.");
            }
            var document = await _context.Documents.FindAsync(id);
            if (document != null)
            {
                _context.Documents.Remove(document);
            }
            
            await _context.SaveChangesAsync();
            TempData["Success"] = "Document Deleted Successfully";
            return RedirectToAction(nameof(Index));
        }

        private bool DocumentExists(int id)
        {
          return _context.Documents.Any(e => e.DocumentId == id);
        }
    }
}
