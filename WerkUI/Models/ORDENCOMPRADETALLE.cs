using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ORDENCOMPRADETALLE
    {
        public decimal CODORDENCOMPRA { get; set; }
        public decimal CODPRODUCTO { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public Nullable<decimal> COSTO { get; set; }
        public Nullable<decimal> PORCENTAJEIVA { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<decimal> CANTIDADAUTORI { get; set; }
        public Nullable<decimal> CODMONEDAPRODUCTO { get; set; }
        public decimal LINEANUMERO { get; set; }
        public virtual ORDENCOMPRA ORDENCOMPRA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
