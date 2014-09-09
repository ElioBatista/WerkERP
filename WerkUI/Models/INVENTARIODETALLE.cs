using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class INVENTARIODETALLE
    {
        public INVENTARIODETALLE()
        {
            this.INVENTARIOSUBDETALLEs = new List<INVENTARIOSUBDETALLE>();
        }

        public decimal CODPRODUCTO { get; set; }
        public decimal CODINVENTARIO { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public Nullable<decimal> COSTOPP { get; set; }
        public Nullable<decimal> COSTOULTIMO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public decimal LINEANUMERO { get; set; }
        public virtual INVENTARIO INVENTARIO { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual ICollection<INVENTARIOSUBDETALLE> INVENTARIOSUBDETALLEs { get; set; }
    }
}
