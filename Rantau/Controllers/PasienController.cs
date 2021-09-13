using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rantau.DAL;
using Rantau.Models;
using Rantau.ViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Rantau.Controllers
{
    public class PasienController : Controller
    {
        private readonly RantauContext _context;

        public PasienController(RantauContext context)
        {
            _context = context;
        }

        // GET: Pasien
        public async Task<IActionResult> Index()
        {
            return View(await _context.pasien.ToListAsync());
        }

        // GET: Pasien/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pasien = await _context.pasien
                .FirstOrDefaultAsync(m => m.PasienID == id);
            if (pasien == null)
            {
                return NotFound();
            }

            var pasienVM = new PasienVM();
            var historiPesan = new HistoriPesan();

            historiPesan.NamaPasien = pasien.NamaDepan;
            historiPesan.NamaSapaan = pasien.JenisKelamin == Enumerations.JenisKelamin.Pria ? "Bapak" : "Ibu";
            historiPesan.NoTelepon = pasien.NoTeleponUtama;

            pasienVM.pasien = pasien;
            pasienVM.historiPesan = historiPesan;

            return View(pasienVM);
        }

        // GET: Pasien/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pasien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PasienID,NoRekamMedis,NamaDepan,NamaBelakang,TanggalLahir,JenisKelamin,Alamat,NoTeleponUtama,NoTeleponAlternatif,JenisPembayaran,StatusPernikahan,TingkatPendidikan,RiwayatMerokok,WaktuTempuhRS,Pemeriksa,CreatedBy,CreatedDate")] Pasien pasien)
        {
            if (ModelState.IsValid)
            {
                pasien.Pemeriksa = "Arini Putriheryanti";
                pasien.CreatedBy = "Arini Putriheryanti";
                pasien.CreatedDate = DateTime.Now;
                pasien.NoTeleponUtama = (pasien.NoTeleponUtama.Substring(0, 1) == "+" || pasien.NoTeleponUtama.Substring(0, 3) == "+62")
                                        ? pasien.NoTeleponUtama
                                        : String.Concat("+62", pasien.NoTeleponUtama.Substring(1));

                _context.Add(pasien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pasien);
        }

        // GET: Pasien/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pasien = await _context.pasien.FindAsync(id);
            if (pasien == null)
            {
                return NotFound();
            }
            return View(pasien);
        }

        // POST: Pasien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PasienID,NoRekamMedis,NamaDepan,NamaBelakang,TanggalLahir,JenisKelamin,Alamat,NoTeleponUtama,NoTeleponAlternatif,JenisPembayaran,StatusPernikahan,TingkatPendidikan,RiwayatMerokok,WaktuTempuhRS,Pemeriksa,CreatedBy,CreatedDate")] Pasien pasien)
        {
            if (id != pasien.PasienID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pasien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PasienExists(pasien.PasienID))
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
            return View(pasien);
        }

        // GET: Pasien/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pasien = await _context.pasien
                .FirstOrDefaultAsync(m => m.PasienID == id);
            if (pasien == null)
            {
                return NotFound();
            }

            return View(pasien);
        }

        // POST: Pasien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pasien = await _context.pasien.FindAsync(id);
            _context.pasien.Remove(pasien);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PasienExists(int id)
        {
            return _context.pasien.Any(e => e.PasienID == id);
        }


        public async Task<IActionResult> AddRekamMedis(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pasien = await _context.pasien.FindAsync(id);
            if (pasien == null)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Create), nameof(InfoRekamMedis), pasien);
        }

        public IActionResult LihatRekamMedis(int? id)
        {
            return RedirectToAction("IndexById", nameof(InfoRekamMedis), id);
        }

    }
}
