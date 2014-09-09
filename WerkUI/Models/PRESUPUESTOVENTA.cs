using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PRESUPUESTOVENTA
    {
        public PRESUPUESTOVENTA()
        {
            this.PRESUPUESTOVENTASDETALLEs = new List<PRESUPUESTOVENTASDETALLE>();
            this.VENTAS = new List<VENTA>();
        }

        public decimal CODPRESUPUESTO { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODCLIENTE { get; set; }
        public Nullable<decimal> CODVENDEDOR { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> NUMPRESUPUESTO { get; set; }
        public Nullable<System.DateTime> FECHAPRESUPUESTO { get; set; }
        public Nullable<decimal> PORCENTAJEDESCUENTO { get; set; }
        public Nullable<decimal> TOTALEXENTA { get; set; }
        public Nullable<decimal> TOTALGRAVADA { get; set; }
        public Nullable<decimal> TOTALIVA { get; set; }
        public Nullable<decimal> TOTALDESCUENTO { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<byte> MODALIDADPAGO { get; set; }
        public Nullable<byte> TIPOVENTA { get; set; }
        public Nullable<byte> TIPOPRECIO { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public System.DateTime FECGRA { get; set; }
        public Nullable<System.DateTime> FECHAAUTORI { get; set; }
        public Nullable<decimal> USUAUTORI { get; set; }
        public string DIRENVIO { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual VENDEDOR VENDEDOR { get; set; }
        public virtual ICollection<PRESUPUESTOVENTASDETALLE> PRESUPUESTOVENTASDETALLEs { get; set; }
        public virtual ICollection<VENTA> VENTAS { get; set; }
    }
}
