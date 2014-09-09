using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class NOTACREDITO
    {
        public decimal CODCOBRANZA { get; set; }
        public decimal CODMONEDA { get; set; }
        public decimal CODFORCOBRO { get; set; }
        public decimal CODCOMPROBANTE { get; set; }
        public decimal NUMNOTACREDITO { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public Nullable<decimal> CODMONEDANC { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> CODDEVOLUCION { get; set; }
        public virtual COBRANZA COBRANZA { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
    }
}
