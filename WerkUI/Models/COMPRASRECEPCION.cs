using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COMPRASRECEPCION
    {
        public decimal CODRECEPCION { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODPROVEEDOR { get; set; }
        public Nullable<decimal> NUMRECEPCION { get; set; }
        public Nullable<System.DateTime> FECHARECEPCION { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
