using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class FERIADO
    {
        public decimal CODFERIADO { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string DESFERIADO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
