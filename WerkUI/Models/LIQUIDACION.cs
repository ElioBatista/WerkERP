using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class LIQUIDACION
    {
        public decimal CODLIQUIDACION { get; set; }
        public decimal SECUENCIAINTERNA { get; set; }
        public string COMENTARIO { get; set; }
        public Nullable<decimal> CODCONLIQUIDACION { get; set; }
        public string DESCONLIQUIDACION { get; set; }
        public Nullable<byte> GRUPOIMPRESION { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
    }
}
