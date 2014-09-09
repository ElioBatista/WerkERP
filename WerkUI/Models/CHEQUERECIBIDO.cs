using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CHEQUERECIBIDO
    {
        public string NUMCHEQUE { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public decimal CODBANCO { get; set; }
        public Nullable<decimal> CODCOBRANZA { get; set; }
        public Nullable<decimal> COB_CODMONEDA { get; set; }
        public Nullable<decimal> CODFORCOBRO { get; set; }
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
        public virtual COBRANZA COBRANZA { get; set; }
        public virtual ESTADOCHEQUE ESTADOCHEQUE { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
