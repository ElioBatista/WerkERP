using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CIRCUITODIA
    {
        public CIRCUITODIA()
        {
            this.CIRCUITOVISITAS = new List<CIRCUITOVISITA>();
        }

        public decimal CODDIAS { get; set; }
        public string NUMDIAS { get; set; }
        public string DESDIAS { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<CIRCUITOVISITA> CIRCUITOVISITAS { get; set; }
    }
}
