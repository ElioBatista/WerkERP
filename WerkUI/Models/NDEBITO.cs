using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class NDEBITO
    {
        public NDEBITO()
        {
            this.DETNDEBITOes = new List<DETNDEBITO>();
        }

        public decimal NUMNDEBITO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public decimal CODEMPRESA { get; set; }
        public Nullable<decimal> CODVENTA { get; set; }
        public Nullable<decimal> CODCLIENTE { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> IMPORTEIVA { get; set; }
        public Nullable<decimal> IMPORTEDESC { get; set; }
        public Nullable<decimal> TOTALEXENTA { get; set; }
        public Nullable<decimal> TOTALGRAVADA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual ICollection<DETNDEBITO> DETNDEBITOes { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual VENTA VENTA { get; set; }
    }
}
