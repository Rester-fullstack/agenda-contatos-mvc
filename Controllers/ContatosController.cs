using AgendaContatosMVC.Data;
using AgendaContatosMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace AgendaContatosMVC.Controllers
{
    public class ContatosController : Controller
    {
        private readonly AppDbContext _context;

        public ContatosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Contatos
        public async Task<IActionResult> Index(string? searchString)
        {
            var contatos = from c in _context.Contatos
                           select c;

            if (!string.IsNullOrEmpty(searchString))
            {
                contatos = contatos.Where(c => c.Nome != null && c.Nome.Contains(searchString));
            }

            return View(await contatos.ToListAsync());
        }


        // GET: Contatos/Create
        public IActionResult Create() => View();

        // POST: Contatos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }

        // GET: Contatos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var contato = await _context.Contatos.FindAsync(id);
            if (contato == null) return NotFound();
            return View(contato);
        }

        // POST: Contatos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Contato contato)
        {
            if (id != contato.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(contato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }

        // GET: Contatos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var contato = await _context.Contatos.FindAsync(id);
            return View(contato);
        }

        // POST: Contatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contato = await _context.Contatos.FindAsync(id);
            if (contato == null)
            {
                return NotFound();
            }

            _context.Contatos.Remove(contato);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }

        // GET: Contatos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var contato = await _context.Contatos
                .FirstOrDefaultAsync(c => c.Id == id);

            if (contato == null) return NotFound();

            return View(contato);
        }

    }

}
