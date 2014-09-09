using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ORDENCOMPRAPROVEEDOR
    {
        public ORDENCOMPRAPROVEEDOR()
        {
            this.ORDENCOMPRAPROVEEDORDETALLEs = new List<ORDENCOMPRAPROVEEDORDETALLE>();
        }

        public decimal CODORDENCOMPRA { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> NUMEROORDEN { get; set; }
        public Nullable<System.DateTime> FECHAORDEN { get; set; }
        public Nullable<decimal> CODPROVEEDOR { get; set; }
        public Nullable<decimal> CODRESPONSABLE { get; set; }
        public Nullable<byte> ESTADOORDEN { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> CODUSUARIOAUTORI { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<System.DateTime> FECHAAUTORIZADO { get; set; }
        public Nullable<decimal> CODORIGEN { get; set; }
        public Nullable<decimal> TOTALIMPORTE { get; set; }
        public Nullable<decimal> TOTALIVA { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODEMPRESAAUTORI { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual ORDENCOMPRAORIGEN ORDENCOMPRAORIGEN { get; set; }
        public virtual ORDENCOMPRARESPONSABLE ORDENCOMPRARESPONSABLE { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual USUARIO USUARIO1 { get; set; }
        public virtual ICollection<ORDENCOMPRAPROVEEDORDETALLE> ORDENCOMPRAPROVEEDORDETALLEs { get; set; }
    }
}
