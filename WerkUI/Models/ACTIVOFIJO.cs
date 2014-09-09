using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ACTIVOFIJO
    {
        public ACTIVOFIJO()
        {
            this.REVALUOs = new List<REVALUO>();
        }

        public decimal CODACTIVO { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODPROVEEDOR { get; set; }
        public Nullable<decimal> CODCENTRO { get; set; }
        public Nullable<decimal> CUENTAACTIVO { get; set; }
        public Nullable<decimal> CUENTADEPRECIA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODVIDAUTIL { get; set; }
        public Nullable<decimal> CODCONCOMPRA { get; set; }
        public string NUMCOMPROBANTE { get; set; }
        public string NUMACTIVO { get; set; }
        public string DESACTIVO { get; set; }
        public Nullable<System.DateTime> FECADQUISICION { get; set; }
        public Nullable<decimal> COSTO { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> COHEFIACTUAL { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual CENTROCOSTO CENTROCOSTO { get; set; }
        public virtual CONCOMPRA CONCOMPRA { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual PLANCUENTA PLANCUENTA1 { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual VIDAUTIL VIDAUTIL { get; set; }
        public virtual ICollection<REVALUO> REVALUOs { get; set; }
    }
}
