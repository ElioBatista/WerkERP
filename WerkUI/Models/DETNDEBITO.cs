using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DETNDEBITO
    {
        public decimal CODNOTACONCEPTO { get; set; }
        public decimal NUMNDEBITO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> PORCENTAJEIVA { get; set; }
        public Nullable<decimal> PORCENDESC { get; set; }
        public virtual NDEBITO NDEBITO { get; set; }
        public virtual NOTACONCEPTO NOTACONCEPTO { get; set; }
    }
}
