using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DETNOTACONCEPTO
    {
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public decimal CODNOTACONCEPTO { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual NOTACONCEPTO NOTACONCEPTO { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
