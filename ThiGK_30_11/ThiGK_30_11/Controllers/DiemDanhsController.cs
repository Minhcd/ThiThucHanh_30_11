using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThiGK_30_11.Models;

namespace ThiGK_30_11.Controllers
{
    public class DiemDanhsController : Controller
    {
        private readonly MyDbContext _context;

        public DiemDanhsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: DiemDanhs
        public async Task<IActionResult> Index()
        {
            return View(await _context.DiemDanh.ToListAsync());
        }

        // GET: DiemDanhs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diemDanh = await _context.DiemDanh
                .FirstOrDefaultAsync(m => m.MaDD == id);
            if (diemDanh == null)
            {
                return NotFound();
            }

            return View(diemDanh);
        }

        // GET: DiemDanhs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DiemDanhs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaDD,Thang,Tuan,TenNV,T2,T3,T4,T5,T6")] DiemDanh diemDanh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diemDanh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diemDanh);
        }

        // GET: DiemDanhs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diemDanh = await _context.DiemDanh.FindAsync(id);
            if (diemDanh == null)
            {
                return NotFound();
            }
            return View(diemDanh);
        }

        // POST: DiemDanhs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaDD,Thang,Tuan,TenNV,T2,T3,T4,T5,T6")] DiemDanh diemDanh)
        {
            if (id != diemDanh.MaDD)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diemDanh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiemDanhExists(diemDanh.MaDD))
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
            return View(diemDanh);
        }

        // GET: DiemDanhs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diemDanh = await _context.DiemDanh
                .FirstOrDefaultAsync(m => m.MaDD == id);
            if (diemDanh == null)
            {
                return NotFound();
            }

            return View(diemDanh);
        }

        // POST: DiemDanhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diemDanh = await _context.DiemDanh.FindAsync(id);
            _context.DiemDanh.Remove(diemDanh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiemDanhExists(int id)
        {
            return _context.DiemDanh.Any(e => e.MaDD == id);
        }
    }
}
