using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Senai.LanHouse.Web.Razor.Contextos;
using Senai.LanHouse.Web.Razor.Dominios;

namespace Senai.LanHouse.Web.Razor.Controllers
{
    public class LoginController : Controller
    {
        private readonly LanHouseContext _context;

        public LoginController(LanHouseContext context)
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
                    ViewBag.Mensagem = "E-mail ou senha inválidos! Tente novamente";
                    return View(usuario);
                }

                HttpContext.Session.SetString("Email", usuario.Email);

                return RedirectToAction("Index","Defeitos");
            }
            return View(usuario);
        }

    }
}
