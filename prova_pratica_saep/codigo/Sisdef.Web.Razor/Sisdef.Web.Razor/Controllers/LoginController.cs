using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sisdef.Web.Razor.Contextos;
using Sisdef.Web.Razor.Dominios;

namespace Sisdef.Web.Razor.Controllers
{
    public class LoginController : Controller
    {
        private readonly SisdefContexto _context;

        public LoginController(SisdefContexto context)
        {
            _context = context;
        }

        // GET: Login/Create
        public IActionResult Create()
        {
            HttpContext.Session.Clear();

            return View();
        }

        // POST: Login/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Email,Senha")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                Usuario usuarioBuscado = await _context.Usuario.FirstOrDefaultAsync(u => u.Email == usuario.Email.ToLower() && u.Senha == usuario.Senha);

                if (usuarioBuscado == null)
                {
                    ViewBag.Mensagem = "ERRO: usuário e/ou senha incorretos.";
                    return View(usuario);
                }

                HttpContext.Session.SetString("Email", usuario.Email);

                return RedirectToAction("Create", "Defeitos");
            }
            return View(usuario);
        }
    }
}
