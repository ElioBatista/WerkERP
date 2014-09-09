using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DEFINIDO
    {
        public decimal CODDEFINIDO { get; set; }
        public decimal CODCOBRANZA { get; set; }
        public decimal CODMONEDA { get; set; }
        public decimal CODFORCOBRO { get; set; }
        public string DESDEFINIDO { get; set; }
        public virtual COBRANZA COBRANZA { get; set; }
    }
}
