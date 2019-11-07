using System;
using System.ComponentModel.DataAnnotations;

namespace Sisdef.Web.Razor.Dominios
{
    public partial class Defeito
    {
        public int DefeitoId { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Informe uma data")]
        [Display(Name = ("Data"))]
        public DateTime DataDefeito { get; set; }

        [Required(ErrorMessage = "Informe o equipamento")]
        [Display(Name = ("Equipamento"))]
        public int? EquipamentoId { get; set; }

        [Required(ErrorMessage = "Informe o tipo de defeito")]
        [Display(Name = ("Tipo Defeito"))]
        public int? TipoDefeitoId { get; set; }

        [DataType(DataType.Time)]
        [Required(ErrorMessage = "Informe a hora inicial do defeito")]
        [Display(Name = ("Horário Início Defeito"))]
        public TimeSpan DataInicio { get; set; }

        [DataType(DataType.Time)]
        [Required(ErrorMessage = "Informe a hora final do defeito")]
        [Display(Name = ("Horário Final Defeito"))]
        public TimeSpan DataFinal { get; set; }

        [Display(Name = ("Equipamento"))]
        public Equipamento Equipamento { get; set; }

        [Display(Name = ("Tipo Defeito"))]
        public TipoDefeito TipoDefeito { get; set; }
    }
}
