using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class NUMERORECIBO
    {
        public decimal CODCOBRADOR { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public decimal CODCOMPROBANTE { get; set; }
        public Nullable<decimal> RANGO1 { get; set; }
        public Nullable<decimal> RANGO2 { get; set; }
        public Nullable<decimal> ULTIMO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
