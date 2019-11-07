using System.ComponentModel.DataAnnotations;

namespace Sisdef.Web.Razor.Dominios
{
    public partial class Usuario
    {
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Informe o e-mail")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
