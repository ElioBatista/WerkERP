using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ORDENPRODUCCIONCABECERA
    {
        public ORDENPRODUCCIONCABECERA()
        {
            this.ORDENPRODUCCIONDETALLEs = new List<ORDENPRODUCCIONDETALLE>();
        }

        public decimal CODORDENPRODUCCION { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> NUMEROOP { get; set; }
        public Nullable<System.DateTime> FECHAOP { get; set; }
        public Nullable<decimal> CODPROVEEDOR { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<ORDENPRODUCCIONDETALLE> ORDENPRODUCCIONDETALLEs { get; set; }
    }
}
