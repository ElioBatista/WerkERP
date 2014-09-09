using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COMPRASTARJETA
    {
        public decimal CODPAGO { get; set; }
        public decimal CODCOMPRA { get; set; }
        public decimal CODTARJETA { get; set; }
        public decimal NUMTARJETA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public virtual COMPRASFORMAPAGO COMPRASFORMAPAGO { get; set; }
        public virtual MONEDA MONEDA { get; set; }
    }
}
