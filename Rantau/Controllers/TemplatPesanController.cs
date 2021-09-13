using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rantau.DAL;
using Rantau.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Rantau.Controllers
{
    public class TemplatPesanController : Controller
    {
        private readonly RantauContext _context;

        public TemplatPesanController(RantauContext context)
        {
            _context = context;
        }

        // GET: TemplatPesan
        public async Task<IActionResult> Index()
        {
            return View(await _context.templatPesan.OrderBy(x => x.TemplatePesanCode).ToListAsync());
        }

        // GET: TemplatPesan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var templatPesan = await _context.templatPesan
                .FirstOrDefaultAsync(m => m.TemplatePesanID == id);
            if (templatPesan == null)
            {
                return NotFound();
            }

            return View(templatPesan);
        }

        // GET: TemplatPesan/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TemplatPesan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TemplatePesanID,TemplatePesanCode,TemplatePesanDescription,CreatedBy,CreatedDate")] TemplatPesan templatPesan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(templatPesan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(templatPesan);
        }

        // GET: TemplatPesan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var templatPesan = await _context.templatPesan.FindAsync(id);
            if (templatPesan == null)
            {
                return NotFound();
            }
            return View(templatPesan);
        }

        // POST: TemplatPesan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TemplatePesanID,TemplatePesanCode,TemplatePesanDescription,CreatedBy,CreatedDate")] TemplatPesan templatPesan)
        {
            if (id != templatPesan.TemplatePesanID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(templatPesan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TemplatPesanExists(templatPesan.TemplatePesanID))
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
            return View(templatPesan);
        }

        // GET: TemplatPesan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var templatPesan = await _context.templatPesan
                .FirstOrDefaultAsync(m => m.TemplatePesanID == id);
            if (templatPesan == null)
            {
                return NotFound();
            }

            return View(templatPesan);
        }

        // POST: TemplatPesan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var templatPesan = await _context.templatPesan.FindAsync(id);
            _context.templatPesan.Remove(templatPesan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TemplatPesanExists(int id)
        {
            return _context.templatPesan.Any(e => e.TemplatePesanID == id);
        }


        public IActionResult KirimPesan()
        {
            return View();
        }

    }
}
