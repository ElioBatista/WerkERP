using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TARJETA
    {
        public decimal CODCOBRANZA { get; set; }
        public decimal CODMONEDA { get; set; }
        public decimal CODFORCOBRO { get; set; }
        public decimal CODTARJETA { get; set; }
        public string NUMTARJETA { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public Nullable<decimal> CODMONEDATAR { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public virtual COBRANZA COBRANZA { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual TIPOTARJETA TIPOTARJETA { get; set; }
    }
}
