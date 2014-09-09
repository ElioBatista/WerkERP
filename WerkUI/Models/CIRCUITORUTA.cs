using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CIRCUITORUTA
    {
        public decimal CODRUTA { get; set; }
        public string NUMRUTA { get; set; }
        public string DESRUTA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
