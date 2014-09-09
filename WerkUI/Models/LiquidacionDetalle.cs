using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class LiquidacionDetalle
    {
        public decimal cod_liquidacion { get; set; }
        public decimal secuencia_interna { get; set; }
        public string comentario { get; set; }
        public Nullable<decimal> cod_con_liquidacion { get; set; }
        public string des_con_liquidacion { get; set; }
        public byte grupo_impresion { get; set; }
        public decimal importe { get; set; }
        public virtual Liquidacione Liquidacione { get; set; }
    }
}
