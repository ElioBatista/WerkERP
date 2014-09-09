using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CAJATARJETA
    {
        public decimal CODFORMACOBRO { get; set; }
        public decimal CODINGRESO { get; set; }
        public decimal CODTARJETA { get; set; }
        public string NUMTARJETA { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public virtual CAJAFORMACOBRO CAJAFORMACOBRO { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual TIPOTARJETA TIPOTARJETA { get; set; }
    }
}
