using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rantau.DAL;
using Rantau.Models;
using Rantau.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rantau.Controllers
{
    public class InfoRekamMedisController : Controller
    {
        private readonly RantauContext _context;

        public InfoRekamMedisController(RantauContext context)
        {
            _context = context;
        }

        // GET: InfoRekamMedis
        public async Task<IActionResult> Index()
        {
            return View(await _context.infoRekamMedis.ToListAsync());
        }

        // GET: InfoRekamMedisList        
        public async Task<IActionResult> IndexById(int? id)
        {
            if (id == null) return NotFound();

            var pasien = await _context.pasien.FindAsync(id);
            if (pasien == null) return NotFound();

            return View(await _context.infoRekamMedis.Where(m => m.NoRekamMedis == pasien.NoRekamMedis).ToListAsync());
        }

        // GET: InfoRekamMedis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoRekamMedis = await _context.infoRekamMedis.FirstOrDefaultAsync(m => m.InfoRekamMedisID == id);
            if (infoRekamMedis == null) return NotFound();

            var iRM = new InfoRekamMedisVM();
            iRM.infoRekamMedis = infoRekamMedis;

            var pasien = await _context.pasien.FirstOrDefaultAsync(p => p.NoRekamMedis == infoRekamMedis.NoRekamMedis);
            if (pasien == null) return NotFound();

            iRM.pasien = pasien;

            var historiPesan = new HistoriPesan();
            historiPesan.NamaSapaan = pasien.JenisKelamin == Enumerations.JenisKelamin.Pria ? "Bapak" : "Ibu";
            historiPesan.NamaPasien = pasien.NamaDepan;
            historiPesan.NoTelepon = pasien.NoTeleponUtama;
            historiPesan.JarakAnjuran = infoRekamMedis.JarakUjiJalan.ToString();
            historiPesan.SumberPesan = Enumerations.SumberHistoriPesan.PesanInfoMedisUtama;

            iRM.historiPesan = historiPesan;

            return View(iRM);
        }

        // GET: InfoRekamMedis/Create
        public IActionResult Create(Pasien pasien)
        {
            var rm = new InfoRekamMedisVM();
            rm.infoRekamMedis = new InfoRekamMedis();
            rm.infoRekamMedis.NoRekamMedis = pasien.NoRekamMedis;
            rm.infoRekamMedis.TanggalPemeriksaan = DateTime.Now;

            rm.historiPesan = new HistoriPesan();
            rm.historiPesan.NamaPasien = pasien.NamaDepan;
            rm.historiPesan.NamaSapaan = pasien.JenisKelamin == Enumerations.JenisKelamin.Pria ? "Bapak" : "Ibu";
            rm.historiPesan.NoTelepon = pasien.NoTeleponUtama;

            return View(rm);
        }

        // POST: InfoRekamMedis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InfoRekamMedisID,NoRekamMedis,TanggalPemeriksaan,BeratBadan,TinggiBadan,IndeksMassaTubuh,DenyutNadi,TekananDarahSistolik,TekananDarahDiastolik,Saturasi,JarakUjiJalan,JarakUjiWaktu,VO2Max,METs,Pemeriksa,CreatedBy,CreatedDate")] InfoRekamMedis infoRekamMedis)
        {
            infoRekamMedis.CreatedBy = "System";
            infoRekamMedis.Pemeriksa = "dr. Arini Putriheryanti";
            infoRekamMedis.CreatedDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                _context.Add(infoRekamMedis);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details), new { id = infoRekamMedis.InfoRekamMedisID });
            }
            return View(infoRekamMedis);
        }

        // GET: InfoRekamMedis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoRekamMedis = await _context.infoRekamMedis.FindAsync(id);
            if (infoRekamMedis == null)
            {
                return NotFound();
            }
            return View(infoRekamMedis);
        }

        // POST: InfoRekamMedis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InfoRekamMedisID,NoRekamMedis,TanggalPemeriksaan,BeratBadan,TinggiBadan,IndeksMassaTubuh,DenyutNadi,TekananDarahSistolik,TekananDarahDiastolik,Saturasi,JarakUjiJalan,JarakUjiWaktu,VO2Max,METs,Pemeriksa,CreatedBy,CreatedDate")] InfoRekamMedis infoRekamMedis)
        {
            if (id != infoRekamMedis.InfoRekamMedisID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(infoRekamMedis);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InfoRekamMedisExists(infoRekamMedis.InfoRekamMedisID))
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
            return View(infoRekamMedis);
        }

        // GET: InfoRekamMedis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoRekamMedis = await _context.infoRekamMedis
                .FirstOrDefaultAsync(m => m.InfoRekamMedisID == id);
            if (infoRekamMedis == null)
            {
                return NotFound();
            }

            return View(infoRekamMedis);
        }

        // POST: InfoRekamMedis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var infoRekamMedis = await _context.infoRekamMedis.FindAsync(id);
            _context.infoRekamMedis.Remove(infoRekamMedis);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InfoRekamMedisExists(int id)
        {
            return _context.infoRekamMedis.Any(e => e.InfoRekamMedisID == id);
        }

        //public async Task<IActionResult> LihatRekamMedis(string noRekamMedis)
        //{
        //    var infoRekamMedis = await _context.infoRekamMedis.Select(m => m.NoRekamMedis == noRekamMedis).ToListAsync();
        //    return RedirectToAction(nameof(Index), infoRekamMedis);
        //}
    }
}
