using System;
using System.Collections.Generic;

namespace Sisdef.Web.Razor.Dominios
{
    public partial class TipoEquipamento
    {
        public TipoEquipamento()
        {
            Equipamento = new HashSet<Equipamento>();
        }

        public int TipoEquipamentoId { get; set; }
        public string Nome { get; set; }

        public ICollection<Equipamento> Equipamento { get; set; }
    }
}
