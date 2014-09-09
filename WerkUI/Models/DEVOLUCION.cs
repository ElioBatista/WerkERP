using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DEVOLUCION
    {
        public DEVOLUCION()
        {
            this.DEVOLUCIONDETALLEs = new List<DEVOLUCIONDETALLE>();
        }

        public decimal CODDEVOLUCION { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODCLIENTE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODVENTA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public string NUMDEVOLUCION { get; set; }
        public Nullable<System.DateTime> FECHADEVOLUCION { get; set; }
        public Nullable<decimal> TOTALEXENTA { get; set; }
        public Nullable<decimal> TOTALGRAVADA { get; set; }
        public Nullable<decimal> TOTALIVA { get; set; }
        public Nullable<decimal> TOTALDESCUENTO { get; set; }
        public Nullable<decimal> PORCENTAJEDESCUENTO { get; set; }
        public Nullable<decimal> TOTALDEVOLUCION { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODVENDEDOR { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual VENDEDOR VENDEDOR { get; set; }
        public virtual ICollection<DEVOLUCIONDETALLE> DEVOLUCIONDETALLEs { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual VENTA VENTA { get; set; }
    }
}
