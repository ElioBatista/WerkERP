using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COMPRASORDENCOMPRA
    {
        public decimal CODDETORDEN { get; set; }
        public Nullable<decimal> CODORDENCOMPRA { get; set; }
        public Nullable<decimal> CODCOMPRA { get; set; }
        public Nullable<decimal> CODPRODUCTO { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public virtual COMPRA COMPRA { get; set; }
        public virtual ORDENCOMPRA ORDENCOMPRA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
