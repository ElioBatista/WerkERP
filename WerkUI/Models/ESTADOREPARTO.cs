using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ESTADOREPARTO
    {
        public decimal CODESTADOREPARTO { get; set; }
        public string NUMESTADOREPARTO { get; set; }
        public string DESESTADOREPARTO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
