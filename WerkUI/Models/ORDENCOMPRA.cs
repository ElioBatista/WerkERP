using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ORDENCOMPRA
    {
        public ORDENCOMPRA()
        {
            this.COMPRASORDENCOMPRAs = new List<COMPRASORDENCOMPRA>();
            this.ORDENCOMPRADETALLEs = new List<ORDENCOMPRADETALLE>();
        }

        public decimal CODORDENCOMPRA { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<System.DateTime> FECHAORDEN { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODTRANSPORTE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> USUAUTORI { get; set; }
        public Nullable<decimal> EMPAUTORI { get; set; }
        public Nullable<decimal> NUMORDENCOMPRA { get; set; }
        public string PLAZOENTREGA { get; set; }
        public Nullable<System.DateTime> FECHAAUTORI { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> CODPROVEEDOR { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<COMPRASORDENCOMPRA> COMPRASORDENCOMPRAs { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual TIPOTRANSPORTE TIPOTRANSPORTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual USUARIO USUARIO1 { get; set; }
        public virtual ICollection<ORDENCOMPRADETALLE> ORDENCOMPRADETALLEs { get; set; }
    }
}
