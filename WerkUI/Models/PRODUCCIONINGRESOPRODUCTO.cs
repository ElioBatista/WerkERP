using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PRODUCCIONINGRESOPRODUCTO
    {
        public PRODUCCIONINGRESOPRODUCTO()
        {
            this.PRODUCCIONINGRESOPRODUCTODETs = new List<PRODUCCIONINGRESOPRODUCTODET>();
        }

        public decimal CODINGRESOPROTER { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODPROVEEDOR { get; set; }
        public Nullable<decimal> NUMCOMPROBANTE { get; set; }
        public Nullable<System.DateTime> FECHACOMPROBANTE { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<PRODUCCIONINGRESOPRODUCTODET> PRODUCCIONINGRESOPRODUCTODETs { get; set; }
    }
}
