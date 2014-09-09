using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CAJANOTACREDITO
    {
        public decimal CODFORMACOBRO { get; set; }
        public decimal CODINGRESO { get; set; }
        public decimal CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODDEVOLUCION { get; set; }
        public decimal NUMNOTACREDITO { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public virtual CAJAFORMACOBRO CAJAFORMACOBRO { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
    }
}
