using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DIASHABILESPORME
    {
        public Nullable<decimal> CODDIAS { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal MES { get; set; }
        public decimal ANUAL { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
