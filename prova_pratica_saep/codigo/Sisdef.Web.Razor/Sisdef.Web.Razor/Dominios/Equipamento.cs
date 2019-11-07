using System;
using System.Collections.Generic;

namespace Sisdef.Web.Razor.Dominios
{
    public partial class Equipamento
    {
        public Equipamento()
        {
            Defeito = new HashSet<Defeito>();
        }

        public int EquipamentoId { get; set; }
        public int? TipoEquipamentoId { get; set; }
        public DateTime? DataHora { get; set; }

        public TipoEquipamento TipoEquipamento { get; set; }
        public ICollection<Defeito> Defeito { get; set; }
    }
}
