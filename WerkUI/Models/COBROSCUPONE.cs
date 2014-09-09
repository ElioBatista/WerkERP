using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COBROSCUPONE
    {
        public COBROSCUPONE()
        {
            this.CUPONES = new List<CUPONE>();
        }

        public decimal CODPAGOS { get; set; }
        public Nullable<decimal> CODDEPOSITO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODCOBRO { get; set; }
        public Nullable<decimal> CODEMISORA { get; set; }
        public string NUMCOMPROBANTE { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> IMPORTEIVA { get; set; }
        public Nullable<decimal> IMPORTECOMI { get; set; }
        public Nullable<decimal> IMPORTERENTA { get; set; }
        public Nullable<decimal> RETENCIONIVA { get; set; }
        public Nullable<System.DateTime> FECHACOBRO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual DEPOSITADO DEPOSITADO { get; set; }
        public virtual EMISORA EMISORA { get; set; }
        public virtual TIPOCOBRO TIPOCOBRO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<CUPONE> CUPONES { get; set; }
    }
}
