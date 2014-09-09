using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COMPRASNOTACREDITO
    {
        public decimal CODPAGO { get; set; }
        public decimal CODCOMPRA { get; set; }
        public decimal CODCOMPROBANTE { get; set; }
        public decimal NUMNOTACREDITO { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public virtual COMPRASFORMAPAGO COMPRASFORMAPAGO { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
    }
}
