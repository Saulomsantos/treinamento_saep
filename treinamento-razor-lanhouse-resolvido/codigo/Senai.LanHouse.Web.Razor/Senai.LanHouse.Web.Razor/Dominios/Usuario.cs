using System;
using System.Collections.Generic;

namespace Senai.LanHouse.Web.Razor.Dominios
{
    public partial class Usuario
    {
        public int UsuarioId { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
