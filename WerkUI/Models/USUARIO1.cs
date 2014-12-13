using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class USUARIO1
    {
        public decimal CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public string DESUSUARIO { get; set; }
        public string PASSUSUARIO { get; set; }
        public Nullable<decimal> NIVELCUENTA { get; set; }
        public Nullable<decimal> USUGRA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
    }
}
