using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class EMPRESA
    {
        public decimal CODEMPRESA { get; set; }
        public Nullable<decimal> USUGRA { get; set; }
        public string NOMFANTASIA { get; set; }
        public string NOMCONTRIBUYENTE { get; set; }
        public string RUCCONTRIBUYENTE { get; set; }
        public string DESEMPRESA { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public string EMAIL { get; set; }
        public string NUMREGPATRONAL { get; set; }
        public Nullable<byte> RETENTOR { get; set; }
        public string NOMREPRESENTANTE { get; set; }
        public string RUCREPRESENTANTE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
    }
}
