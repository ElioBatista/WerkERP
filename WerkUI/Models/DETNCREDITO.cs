using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DETNCREDITO
    {
        public decimal NUMNCREDITO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public decimal CODNOTACONCEPTO { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> PORCENTAJEIVA { get; set; }
        public Nullable<decimal> PORCENDESC { get; set; }
        public virtual NCREDITO NCREDITO { get; set; }
        public virtual NOTACONCEPTO NOTACONCEPTO { get; set; }
    }
}
