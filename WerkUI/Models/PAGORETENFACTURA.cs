using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PAGORETENFACTURA
    {
        public decimal CODRETEN { get; set; }
        public decimal CODTIPORETEN { get; set; }
        public decimal CODCOMPRA { get; set; }
        public Nullable<decimal> IMPMONEDACOMPRA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public virtual COMPRA COMPRA { get; set; }
        public virtual PAGOTIPORETEN PAGOTIPORETEN { get; set; }
    }
}
