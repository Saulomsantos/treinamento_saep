using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.LanHouse.Web.Razor.Dominios
{
    public partial class Defeito
    {
        public int DefeitoId { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Informe uma data")]
        [Display(Name =("Data do defeito"))]
        public DateTime DataDefeito { get; set; }

        [Required(ErrorMessage = "Informe uma descrição para o defeito")]
        [Display(Name = ("Observação"))]
        public string Observacao { get; set; }

        [Display(Name = ("Tipo do defeito"))]
        public int? TipoDefeitoId { get; set; }

        [Display(Name = ("Equipamento"))]
        public int? EquipamentoId { get; set; }

        [Display(Name = ("Equipamento"))]
        public Equipamento Equipamento { get; set; }

        [Display(Name = ("Tipo do defeito"))]
        public TipoDefeito TipoDefeito { get; set; }
    }
}
