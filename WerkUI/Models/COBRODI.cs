using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COBRODI
    {
        public decimal CODDESPACHOINTERNO { get; set; }
        public decimal CODCOBRANZA { get; set; }
        public decimal MON_CODMONEDA { get; set; }
        public decimal CODFORCOBRO { get; set; }
        public Nullable<decimal> IMPORTEDI { get; set; }
        public virtual COBRANZA COBRANZA { get; set; }
        public virtual DESPACHOINTERNO DESPACHOINTERNO { get; set; }
    }
}
