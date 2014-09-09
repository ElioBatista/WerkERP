using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CAJAINGRESO1
    {
        public CAJAINGRESO1()
        {
            this.CAJAFACTURASCREDITOes = new List<CAJAFACTURASCREDITO>();
            this.CAJAFORMACOBROes = new List<CAJAFORMACOBRO>();
            this.VENTAS = new List<VENTA>();
        }

        public decimal CODINGRESO { get; set; }
        public Nullable<byte> TIPOINGRESO { get; set; }
        public Nullable<decimal> CODTIPOEGRESO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> NUMCAJA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> VUELTO { get; set; }
        public Nullable<System.DateTime> FECINGRESO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public string OBSERVACION { get; set; }
        public virtual CAJA CAJA { get; set; }
        public virtual ICollection<CAJAFACTURASCREDITO> CAJAFACTURASCREDITOes { get; set; }
        public virtual ICollection<CAJAFORMACOBRO> CAJAFORMACOBROes { get; set; }
        public virtual TIPOEGRESO TIPOEGRESO { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual ICollection<VENTA> VENTAS { get; set; }
    }
}
