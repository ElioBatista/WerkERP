using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COMPRASDETALLE
    {
        public decimal CODPRODUCTO { get; set; }
        public decimal CODCOMPRA { get; set; }
        public Nullable<decimal> CANTIDADCOMPRA { get; set; }
        public Nullable<decimal> COSTOPROMEDIO { get; set; }
        public Nullable<decimal> COSTOUNITARIO { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public Nullable<decimal> FACTORPROMEDIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> COSTOBRUTO { get; set; }
        public string ORDENFABRICACION { get; set; }
        public Nullable<decimal> COSTOPROMEDIOMAESTRO { get; set; }
        public Nullable<decimal> COSTOPPMAESTRO { get; set; }
        public Nullable<decimal> PRECIOMAY { get; set; }
        public Nullable<decimal> PRECIOMIN { get; set; }
        public decimal LINEANUMERO { get; set; }
        public virtual COMPRA COMPRA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
