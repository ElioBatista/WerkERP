using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOVENDEDOR
    {
        public TIPOVENDEDOR()
        {
            this.VENDEDORs = new List<VENDEDOR>();
        }

        public decimal CODTIPOVENDEDOR { get; set; }
        public string NUMTIPOVENDEDOR { get; set; }
        public string DESTIPOVENDEDOR { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<VENDEDOR> VENDEDORs { get; set; }
    }
}
