using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class RUBRO1
    {
        public RUBRO1()
        {
            this.PROPOSITOCHEQUEs = new List<PROPOSITOCHEQUE>();
        }

        public decimal CODRUBRO1 { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMRUBRO { get; set; }
        public string DESRUBRO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<PROPOSITOCHEQUE> PROPOSITOCHEQUEs { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
