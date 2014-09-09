using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DETPC
    {
        public string IP { get; set; }
        public decimal CODEMPRESA { get; set; }
        public decimal CODSUCURSAL { get; set; }
        public decimal CODCOMPROBANTE { get; set; }
        public Nullable<decimal> RANGO1 { get; set; }
        public Nullable<decimal> RANGO2 { get; set; }
        public Nullable<decimal> ULTIMO { get; set; }
        public string IMPRESORA { get; set; }
        public Nullable<decimal> USUDESCUENTO { get; set; }
        public Nullable<decimal> DESCUENTO { get; set; }
        public Nullable<decimal> TOTALDESCUENTO { get; set; }
        public Nullable<byte> ACTIVO { get; set; }
        public virtual PC PC { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
    }
}
