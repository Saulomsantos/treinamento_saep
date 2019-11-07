using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sisdef.Web.Razor.Contextos;
using Sisdef.Web.Razor.Dominios;

namespace Sisdef.Web.Razor.Controllers
{
    public class DefeitosController : Controller
    {
        private readonly SisdefContexto _context;

        public DefeitosController(SisdefContexto context)
        {
            _context = context;
        }

        // GET: Defeitos
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("Create", "Login");
            }

            var sisdefContexto = _context.Defeito.Include(d => d.Equipamento).Include("Equipamento.TipoEquipamento").Include(d => d.TipoDefeito);
            return View(await sisdefContexto.ToListAsync());
        }

        // GET: Defeitos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("Create", "Login");
            }

            if (id == null)
            {
                return NotFound();
            }

            var defeito = await _context.Defeito
                .Include(d => d.Equipamento)
                .Include(d => d.TipoDefeito)
                .FirstOrDefaultAsync(m => m.DefeitoId == id);
            if (defeito == null)
            {
                return NotFound();
            }

            return View(defeito);
        }

        // GET: Defeitos/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("Create", "Login");
            }

            ViewData["EquipamentoId"] = new SelectList(_context.Equipamento.Include(u => u.TipoEquipamento), "EquipamentoId", "TipoEquipamento.Nome");
            ViewData["TipoDefeitoId"] = new SelectList(_context.TipoDefeito, "TipoDefeitoId", "Titulo");
            return View();
        }

        // POST: Defeitos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DefeitoId,DataDefeito,EquipamentoId,TipoDefeitoId,DataInicio,DataFinal")] Defeito defeito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(defeito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipamentoId"] = new SelectList(_context.Equipamento.Include("TipoEquipamento"), "EquipamentoId", "Nome", defeito.Equipamento.TipoEquipamentoId);
            ViewData["TipoDefeitoId"] = new SelectList(_context.TipoDefeito, "TipoDefeitoId", "Titulo", defeito.TipoDefeitoId);
            return View(defeito);
        }

        // GET: Defeitos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var defeito = await _context.Defeito.FindAsync(id);
            if (defeito == null)
            {
                return NotFound();
            }
            ViewData["EquipamentoId"] = new SelectList(_context.Equipamento, "EquipamentoId", "EquipamentoId", defeito.EquipamentoId);
            ViewData["TipoDefeitoId"] = new SelectList(_context.TipoDefeito, "TipoDefeitoId", "Titulo", defeito.TipoDefeitoId);
            return View(defeito);
        }

        // POST: Defeitos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DefeitoId,DataDefeito,EquipamentoId,TipoDefeitoId,DataInicio,DataFinal")] Defeito defeito)
        {
            if (id != defeito.DefeitoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(defeito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DefeitoExists(defeito.DefeitoId))
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
            ViewData["EquipamentoId"] = new SelectList(_context.Equipamento, "EquipamentoId", "EquipamentoId", defeito.EquipamentoId);
            ViewData["TipoDefeitoId"] = new SelectList(_context.TipoDefeito, "TipoDefeitoId", "Titulo", defeito.TipoDefeitoId);
            return View(defeito);
        }

        // GET: Defeitos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("Create", "Login");
            }

            if (id == null)
            {
                return NotFound();
            }

            var defeito = await _context.Defeito
                .Include(d => d.Equipamento)
                .Include(d => d.TipoDefeito)
                .FirstOrDefaultAsync(m => m.DefeitoId == id);
            if (defeito == null)
            {
                return NotFound();
            }

            return View(defeito);
        }

        // POST: Defeitos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var defeito = await _context.Defeito.FindAsync(id);
            _context.Defeito.Remove(defeito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DefeitoExists(int id)
        {
            return _context.Defeito.Any(e => e.DefeitoId == id);
        }
    }
}
