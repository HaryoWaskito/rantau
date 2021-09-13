using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class HistoriPesanController : Controller
    {
        private readonly RantauContext _context;

        public HistoriPesanController(RantauContext context)
        {
            _context = context;
        }

        // GET: HistoriPesan
        public async Task<IActionResult> Index()
        {
            return View(await _context.historiPesan.ToListAsync());
        }

        // GET: HistoriPesan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historiPesan = await _context.historiPesan
                .FirstOrDefaultAsync(m => m.HistoriPesanID == id);
            if (historiPesan == null)
            {
                return NotFound();
            }

            return View(historiPesan);
        }

        // GET: HistoriPesan/Create
        public IActionResult Create(HistoriPesan historiPesan)
        {
            string sapaan = historiPesan.NamaSapaan;
            string namaPasien = historiPesan.NamaPasien;
            string jarak = historiPesan.JarakAnjuran;
            var vm = new HistoriPesanVM();

            vm.historiPesan = historiPesan;
            vm.templatPesanList = _context.templatPesan
                                    .Select(a => new SelectListItem()
                                    {
                                        Value = a.TemplatePesanDescription.Contains("{2}") ? String.Format(a.TemplatePesanDescription, sapaan, namaPasien, jarak) :
                                                a.TemplatePesanDescription.Contains("{1}") ? String.Format(a.TemplatePesanDescription, sapaan, namaPasien) :
                                                String.Format(a.TemplatePesanDescription, sapaan),
                                        Text = a.TemplatePesanCode
                                    }).OrderBy(t => t.Text).ToList();

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SimpanDanKirimPesan(InfoRekamMedisVM irm)
        {
            irm.infoRekamMedis.CreatedBy = "System";
            irm.infoRekamMedis.Pemeriksa = "dr. Arini Putriheryanti";
            irm.infoRekamMedis.CreatedDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                _context.Add(irm.infoRekamMedis);
                await _context.SaveChangesAsync();

                //return RedirectToAction("Create", "HistoriPesan", irm.historiPesan);
            }
            return View(irm);
        }

        // POST: HistoriPesan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("HistoriPesanID,SumberPesan,IsiPesan,CreatedBy,CreatedDate")] HistoriPesanVM historiPesanVM)
        public async Task<IActionResult> Create(HistoriPesanVM historiPesanVM)
        {
            if (ModelState.IsValid)
            {
                historiPesanVM.historiPesan.CreatedDate = DateTime.Now;
                historiPesanVM.historiPesan.NoTelepon = (historiPesanVM.historiPesan.NoTelepon.Substring(0, 1) == "+" || historiPesanVM.historiPesan.NoTelepon.Substring(0, 3) == "+62")
                                                        ? historiPesanVM.historiPesan.NoTelepon
                                                        : String.Concat("+62", historiPesanVM.historiPesan.NoTelepon.Substring(1));

                _context.Add(historiPesanVM.historiPesan);
                await _context.SaveChangesAsync();

                string waMsg = string.Format("https://api.whatsapp.com/send?phone={0}&text={1}", historiPesanVM.historiPesan.NoTelepon, Uri.EscapeUriString(historiPesanVM.historiPesan.IsiPesan));

                return Redirect(waMsg);

                //return RedirectToAction(nameof(Index));
            }

            return View(historiPesanVM.historiPesan);
        }

        [HttpPost]
        public IActionResult GetSelectedTemplatePesan(string description)
        {
            return Ok(description);
        }

        // GET: HistoriPesan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historiPesan = await _context.historiPesan.FindAsync(id);
            if (historiPesan == null)
            {
                return NotFound();
            }
            return View(historiPesan);
        }

        // POST: HistoriPesan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HistoriPesanID,SumberPesan,IsiPesan,CreatedBy,CreatedDate")] HistoriPesan historiPesan)
        {
            if (id != historiPesan.HistoriPesanID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(historiPesan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistoriPesanExists(historiPesan.HistoriPesanID))
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
            return View(historiPesan);
        }

        // GET: HistoriPesan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historiPesan = await _context.historiPesan
                .FirstOrDefaultAsync(m => m.HistoriPesanID == id);
            if (historiPesan == null)
            {
                return NotFound();
            }

            return View(historiPesan);
        }

        // POST: HistoriPesan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var historiPesan = await _context.historiPesan.FindAsync(id);
            _context.historiPesan.Remove(historiPesan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistoriPesanExists(int id)
        {
            return _context.historiPesan.Any(e => e.HistoriPesanID == id);
        }
    }
}
