using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class TIPOCLIENTE
    {
        public decimal CODTIPOCLIENTE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMTIPOCLIENTE { get; set; }
        public string DESTIPOCLIENTE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public string RUC { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
    }
}
