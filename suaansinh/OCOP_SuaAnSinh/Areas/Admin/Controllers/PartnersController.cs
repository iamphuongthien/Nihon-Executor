using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OCOP_SuaAnSinh.Data;
using OCOP_SuaAnSinh.Models;
using OCOP_SuaAnSinh.Utilities;

namespace OCOP_SuaAnSinh.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PartnersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PartnersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Partners
        public async Task<IActionResult> Index()
        {
            return View(await _context.Partners.ToListAsync());
        }

        // GET: Admin/Partners/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners
                .FirstOrDefaultAsync(m => m.PartnerId == id);
            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);
        }

        // GET: Admin/Partners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Partners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PartnerId,Name,ImageUrl,Url,IsActive,OrderBy,PathUrl,Language")] Partner partner)
        {
            if (ModelState.IsValid)
            {
                partner.PartnerId = Guid.NewGuid();
                partner.IsActive = false;
                partner.PathUrl = Helper.ConvertToUnSign(partner.Name.Trim());
                partner.Language = "vi";
                _context.Add(partner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(partner);
        }

        // GET: Admin/Partners/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners.FindAsync(id);
            if (partner == null)
            {
                return NotFound();
            }
            return View(partner);
        }

        // POST: Admin/Partners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("PartnerId,Name,ImageUrl,Url,IsActive,OrderBy,PathUrl,Language")] Partner partner)
        {
            if (id != partner.PartnerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(partner);
                    _context.Entry(partner).Property(x => x.IsActive).IsModified = false;
                    _context.Entry(partner).Property(x => x.PathUrl).IsModified = false;
                    _context.Entry(partner).Property(x => x.Language).IsModified = false;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!partnerExists(partner.PartnerId))
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
            return View(partner);
        }

        private bool partnerExists(Guid partnerId)
        {
            throw new NotImplementedException();
        }

        // GET: Admin/Partners/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            var partner = await _context.Partners.FindAsync(id);
            if (partner == null)
                return Json(new { status = "error", message = "Đối tượng không tồn tại." });
            _context.Partners.Remove(partner);
            await _context.SaveChangesAsync();
            return Json(new { status = "success", message = "Xóa thành công." });
        }

        private bool PostCategoryExists(Guid id)
        {
            return _context.Partners.Any(e => e.PartnerId == id);
        }

        // POST: Admin/Partners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var partner = await _context.Partners.FindAsync(id);
            _context.Partners.Remove(partner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartnerExists(Guid id)
        {
            return _context.Partners.Any(e => e.PartnerId == id);
        }
    }
}
