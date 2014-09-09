using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CHEQUEEMITIDO
    {
        public decimal NUMEROCHEQUE { get; set; }
        public string NUMCUENTA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECHAVCTO { get; set; }
        public Nullable<System.DateTime> EFECTIVIZACION { get; set; }
        public Nullable<System.DateTime> CONCILIACION { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public string BENEFICIARIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public decimal CODBANCO { get; set; }
        public Nullable<decimal> CODPAGANZAS { get; set; }
        public Nullable<decimal> CODTIPOPAGO { get; set; }
        public Nullable<decimal> PAG_CODMONEDA { get; set; }
        public Nullable<decimal> BAN__CODBANCO { get; set; }
        public Nullable<decimal> BAN_CODBANCO { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual CUENTABANCARIA CUENTABANCARIA { get; set; }
        public virtual PAGANZA PAGANZA { get; set; }
    }
}
