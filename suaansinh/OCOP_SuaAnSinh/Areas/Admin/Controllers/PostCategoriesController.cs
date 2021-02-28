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
    public class PostCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PostCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/PostCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.PostCategories.ToListAsync());
        }

        // GET: Admin/PostCategories/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postCategory = await _context.PostCategories
                .FirstOrDefaultAsync(m => m.PostCategoryId == id);
            if (postCategory == null)
            {
                return NotFound();
            }

            return View(postCategory);
        }

        // GET: Admin/PostCategories/Create
        public PartialViewResult Create()
        {
            return PartialView();
        }

        // POST: Admin/PostCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,OrderBy")] PostCategory postCategory)
        {
            if (ModelState.IsValid)
            {
                postCategory.PostCategoryId = Guid.NewGuid();
                postCategory.IsActive = false;
                postCategory.PathUrl = Helper.ConvertToUnSign(postCategory.Name.Trim());
                postCategory.Language = "vi";
                _context.Add(postCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(postCategory);
        }

        // GET: Admin/PostCategories/Edit/5
        public PartialViewResult Edit(Guid? id)
        {
            var postCategory = _context.PostCategories.Find(id);
            return PartialView(postCategory);
        }

        // POST: Admin/PostCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("PostCategoryId,Name,OrderBy")] PostCategory postCategory)
        {
            if (id != postCategory.PostCategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(postCategory);
                    _context.Entry(postCategory).Property(x => x.IsActive).IsModified = false;
                    _context.Entry(postCategory).Property(x => x.PathUrl).IsModified = false;
                    _context.Entry(postCategory).Property(x => x.Language).IsModified = false;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostCategoryExists(postCategory.PostCategoryId))
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
            return View(postCategory);
        }

        // GET: Admin/PostCategories/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            var postCategory = await _context.PostCategories.FindAsync(id);
            if(postCategory == null)
                return Json(new { status = "error", message = "Đối tượng không tồn tại." });
            _context.PostCategories.Remove(postCategory);
            await _context.SaveChangesAsync();
            return Json(new { status = "success", message = "Xóa thành công." });
        }

        private bool PostCategoryExists(Guid id)
        {
            return _context.PostCategories.Any(e => e.PostCategoryId == id);
        }
    }
}
