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
    public class ChamCongsController : Controller
    {
        private readonly MyDbContext _context;

        public ChamCongsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: ChamCongs
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.ChamCongs.Include(c => c.nhanvien).Include(c => c.phongban);
            return View(await myDbContext.ToListAsync());
        }

        // GET: ChamCongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chamCong = await _context.ChamCongs
                .Include(c => c.nhanvien)
                .Include(c => c.phongban)
                .FirstOrDefaultAsync(m => m.MaCC == id);
            if (chamCong == null)
            {
                return NotFound();
            }

            return View(chamCong);
        }

        // GET: ChamCongs/Create
        public IActionResult Create()
        {
            ViewData["MaNV"] = new SelectList(_context.NhanViens, "MaNV", "TenNV");
            ViewData["MaPB"] = new SelectList(_context.PhongBans, "MaPB", "TenPB");
            return View();
        }

        // POST: ChamCongs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaCC,TenNV,Thang,Nam,SoNgayLamTrongThang,TongLuong,MaPB,MaNV")] ChamCong chamCong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chamCong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaNV"] = new SelectList(_context.NhanViens, "MaNV", "TenNV", chamCong.MaNV);
            ViewData["MaPB"] = new SelectList(_context.PhongBans, "MaPB", "TenPB", chamCong.MaPB);
            return View(chamCong);
        }

        // GET: ChamCongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chamCong = await _context.ChamCongs.FindAsync(id);
            if (chamCong == null)
            {
                return NotFound();
            }
            ViewData["MaNV"] = new SelectList(_context.NhanViens, "MaNV", "TenNV", chamCong.MaNV);
            ViewData["MaPB"] = new SelectList(_context.PhongBans, "MaPB", "TenPB", chamCong.MaPB);
            return View(chamCong);
        }

        // POST: ChamCongs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaCC,TenNV,Thang,Nam,SoNgayLamTrongThang,TongLuong,MaPB,MaNV")] ChamCong chamCong)
        {
            if (id != chamCong.MaCC)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chamCong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChamCongExists(chamCong.MaCC))
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
            ViewData["MaNV"] = new SelectList(_context.NhanViens, "MaNV", "TenNV", chamCong.MaNV);
            ViewData["MaPB"] = new SelectList(_context.PhongBans, "MaPB", "TenPB", chamCong.MaPB);
            return View(chamCong);
        }

        // GET: ChamCongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chamCong = await _context.ChamCongs
                .Include(c => c.nhanvien)
                .Include(c => c.phongban)
                .FirstOrDefaultAsync(m => m.MaCC == id);
            if (chamCong == null)
            {
                return NotFound();
            }

            return View(chamCong);
        }

        // POST: ChamCongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chamCong = await _context.ChamCongs.FindAsync(id);
            _context.ChamCongs.Remove(chamCong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChamCongExists(int id)
        {
            return _context.ChamCongs.Any(e => e.MaCC == id);
        }
    }
}
