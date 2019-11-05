using System;
using System.Collections.Generic;

namespace Senai.LanHouse.Web.Razor.Dominios
{
    public partial class Defeito
    {
        public int DefeitoId { get; set; }
        public DateTime DataDefeito { get; set; }
        public string Observacao { get; set; }
        public int? TipoDefeitoId { get; set; }
        public int? EquipamentoId { get; set; }

        public Equipamento Equipamento { get; set; }
        public TipoDefeito TipoDefeito { get; set; }
    }
}
