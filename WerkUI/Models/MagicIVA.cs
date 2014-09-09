using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class MagicIVA
    {
        public decimal codmagiciva { get; set; }
        public Nullable<decimal> codiva { get; set; }
        public Nullable<decimal> importe { get; set; }
        public Nullable<decimal> codconcompra { get; set; }
        public Nullable<decimal> codconventas { get; set; }
        public Nullable<decimal> IMPUESTO { get; set; }
        public Nullable<decimal> CODCOMPRA { get; set; }
        public Nullable<decimal> CODVENTA { get; set; }
        public Nullable<decimal> CODNCREDITO { get; set; }
        public virtual COMPRA COMPRA { get; set; }
        public virtual CONCOMPRA CONCOMPRA { get; set; }
        public virtual CONVENTA CONVENTA { get; set; }
        public virtual IVA IVA { get; set; }
        public virtual PAGONOTACREDITO PAGONOTACREDITO { get; set; }
        public virtual VENTA VENTA { get; set; }
    }
}
