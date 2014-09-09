using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PROPOSITOCHEQUE
    {
        public decimal CODPROPOSITO { get; set; }
        public Nullable<decimal> CODCONLIQUIDACION { get; set; }
        public Nullable<decimal> CODRUBRO1 { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMPROPOSITO { get; set; }
        public string DESPROPOSITO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<byte> ESTADO { get; set; }
    }
}
