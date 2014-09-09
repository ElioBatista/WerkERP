using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CAJAFACTURASCREDITO
    {
        public decimal CODFACTURACREDITO { get; set; }
        public Nullable<decimal> CODINGRESO { get; set; }
        public Nullable<decimal> CODCOBRANZA { get; set; }
        public Nullable<decimal> MON_CODMONEDA { get; set; }
        public Nullable<decimal> CODFORCOBRO { get; set; }
        public virtual CAJAINGRESO1 CAJAINGRESO { get; set; }
        public virtual COBRANZA COBRANZA { get; set; }
    }
}
