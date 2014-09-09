using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class EMISORA
    {
        public EMISORA()
        {
            this.COBROSCUPONES = new List<COBROSCUPONE>();
            this.CUPONES = new List<CUPONE>();
            this.DIASEMISORAs = new List<DIASEMISORA>();
        }

        public decimal CODEMISORA { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMEMISORA { get; set; }
        public string DESEMISORA { get; set; }
        public Nullable<decimal> COMISION { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public Nullable<decimal> RETENCIONRENTA { get; set; }
        public Nullable<decimal> RETENCIONIVA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<COBROSCUPONE> COBROSCUPONES { get; set; }
        public virtual ICollection<CUPONE> CUPONES { get; set; }
        public virtual ICollection<DIASEMISORA> DIASEMISORAs { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
