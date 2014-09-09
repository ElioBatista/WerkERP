using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CONCEPTOSLIQUIDACION
    {
        public decimal CODCONLIQUIDACION { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMCONLIQUIDACION { get; set; }
        public string DESCONLIQUIDACION { get; set; }
        public Nullable<byte> GRUPOIMPRESION { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
    }
}
