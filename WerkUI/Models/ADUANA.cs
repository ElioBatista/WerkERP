using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ADUANA
    {
        public ADUANA()
        {
            this.DESPACHOes = new List<DESPACHO>();
            this.DESPACHOes1 = new List<DESPACHO>();
        }

        public decimal CODADUANA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMADUANA { get; set; }
        public string DESADUANA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<DESPACHO> DESPACHOes { get; set; }
        public virtual ICollection<DESPACHO> DESPACHOes1 { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
