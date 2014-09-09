using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CUPONE
    {
        public CUPONE()
        {
            this.DEPOSITOCUPONs = new List<DEPOSITOCUPON>();
            this.COBROSCUPONES = new List<COBROSCUPONE>();
        }

        public decimal CODCUPON { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public decimal CODEMISORA { get; set; }
        public Nullable<decimal> CODESTADOCUPON { get; set; }
        public Nullable<System.DateTime> FECREC { get; set; }
        public Nullable<decimal> NUMCUOTA { get; set; }
        public Nullable<decimal> CANCUOTA { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual EMISORA EMISORA { get; set; }
        public virtual ESTADOCUPON ESTADOCUPON { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<DEPOSITOCUPON> DEPOSITOCUPONs { get; set; }
        public virtual ICollection<COBROSCUPONE> COBROSCUPONES { get; set; }
    }
}
