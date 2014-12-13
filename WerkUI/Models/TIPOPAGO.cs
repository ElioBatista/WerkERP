using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class TIPOPAGO
    {
        public decimal CODTIPOPAGO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public string NUMTIPOPAGO { get; set; }
        public string DESTIPOPAGO { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
    }
}
