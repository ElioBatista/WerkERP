using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class TiposChequera
    {
        public TiposChequera()
        {
            this.Chequeras = new List<Chequera>();
        }

        public short id_tipo_chequera { get; set; }
        public string tipo_chequera { get; set; }
        public virtual ICollection<Chequera> Chequeras { get; set; }
    }
}
