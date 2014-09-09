using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CREDITORECIBIDO
    {
        public decimal CODCREDITO { get; set; }
        public string NUMCHEQUE { get; set; }
        public virtual CREDITO CREDITO { get; set; }
    }
}
