using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class OTPROBLEMADETALLE
    {
        public decimal CODDETALLE { get; set; }
        public decimal CODOT { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public virtual OTCABECERA OTCABECERA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
