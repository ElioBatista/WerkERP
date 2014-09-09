using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PAGONCCONCEPTO
    {
        public PAGONCCONCEPTO()
        {
            this.PAGONOTACREDITOes = new List<PAGONOTACREDITO>();
        }

        public decimal CODCONCEPTO { get; set; }
        public string NUMCONCEPTO { get; set; }
        public string DESCONCEPTO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<PAGONOTACREDITO> PAGONOTACREDITOes { get; set; }
    }
}
