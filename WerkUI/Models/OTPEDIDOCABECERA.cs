using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class OTPEDIDOCABECERA
    {
        public decimal CODOTPEDIDO { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODTECNICO { get; set; }
        public Nullable<decimal> CODOT { get; set; }
        public Nullable<System.DateTime> FECHAMOV { get; set; }
        public Nullable<decimal> NUMOTPEDIDO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual OTCABECERA OTCABECERA { get; set; }
        public virtual OTCABECERA OTCABECERA1 { get; set; }
        public virtual OTTECNICO OTTECNICO { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
