using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOTARJETA
    {
        public TIPOTARJETA()
        {
            this.CAJATARJETAS = new List<CAJATARJETA>();
            this.TARJETAs = new List<TARJETA>();
        }

        public decimal CODTARJETA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMTIPOTARJE { get; set; }
        public string DESTARJETA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<CAJATARJETA> CAJATARJETAS { get; set; }
        public virtual ICollection<TARJETA> TARJETAs { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
