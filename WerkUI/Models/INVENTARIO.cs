using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class INVENTARIO
    {
        public INVENTARIO()
        {
            this.INVENTARIODETALLEs = new List<INVENTARIODETALLE>();
        }

        public decimal CODINVENTARIO { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMINVENTARIO { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public Nullable<byte> TIPOINVENTARIO { get; set; }
        public Nullable<System.DateTime> FECHAINVENTARIO { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public virtual ICollection<INVENTARIODETALLE> INVENTARIODETALLEs { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual MONEDA MONEDA { get; set; }
    }
}
