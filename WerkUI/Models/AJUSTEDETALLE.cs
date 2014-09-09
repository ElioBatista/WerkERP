using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class AJUSTEDETALLE
    {
        public AJUSTEDETALLE()
        {
            this.AJUSTESUBDETALLEs = new List<AJUSTESUBDETALLE>();
        }

        public decimal CODAJUSTE { get; set; }
        public decimal CODPRODUCTO { get; set; }
        public Nullable<decimal> CANTIDADAJUSTE { get; set; }
        public Nullable<decimal> COSTOPROMEDIO { get; set; }
        public Nullable<decimal> COSTOULTIMO { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public decimal LINEANUMERO { get; set; }
        public virtual AJUSTE AJUSTE { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual ICollection<AJUSTESUBDETALLE> AJUSTESUBDETALLEs { get; set; }
    }
}
