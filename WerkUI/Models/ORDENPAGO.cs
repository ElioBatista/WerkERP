using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ORDENPAGO
    {
        public ORDENPAGO()
        {
            this.ORDENPAGOCHEQUEs = new List<ORDENPAGOCHEQUE>();
        }

        public decimal NROORDEN { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<System.DateTime> FECORDEN { get; set; }
        public string CONCEPTO { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODPROVEEDOR { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> CODCOMPRA { get; set; }
        public Nullable<decimal> NUMEROCUOTA { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public virtual COMPRA COMPRA { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<ORDENPAGOCHEQUE> ORDENPAGOCHEQUEs { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
    }
}
