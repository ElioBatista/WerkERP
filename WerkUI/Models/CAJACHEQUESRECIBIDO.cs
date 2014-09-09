using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CAJACHEQUESRECIBIDO
    {
        public Nullable<decimal> CODFORMACOBRO { get; set; }
        public Nullable<decimal> CODINGRESO { get; set; }
        public decimal CODBANCO { get; set; }
        public string NUMCHEQUE { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODESTADO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECHAVCTO { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public string LIBRADOR { get; set; }
        public virtual BANCO BANCO { get; set; }
        public virtual CAJAFORMACOBRO CAJAFORMACOBRO { get; set; }
        public virtual ESTADOCHEQUE ESTADOCHEQUE { get; set; }
        public virtual MONEDA MONEDA { get; set; }
    }
}
