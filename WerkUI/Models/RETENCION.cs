using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class RETENCION
    {
        public decimal CODRETENCION { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> USUGRA { get; set; }
        public string DESRETENCION { get; set; }
        public Nullable<decimal> VALRETENCION { get; set; }
        public Nullable<decimal> CUALRETENCION { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public virtual EMPRESA EMPRESA { get; set; }
    }
}
