using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CONCEPTO
    {
        public CONCEPTO()
        {
            this.AJUSTEs = new List<AJUSTE>();
        }

        public decimal CODCONCEPTO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMCONCEPTO { get; set; }
        public string DESCONCEPTO { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<AJUSTE> AJUSTEs { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
