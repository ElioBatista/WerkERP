using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class Liquidacione
    {
        public Liquidacione()
        {
            this.LiquidacionDetalles = new List<LiquidacionDetalle>();
        }

        public decimal cod_liquidacion { get; set; }
        public decimal num_liquidacion { get; set; }
        public System.DateTime fecha { get; set; }
        public decimal importe_total { get; set; }
        public int cod_usuario { get; set; }
        public int cod_empresa { get; set; }
        public byte estado { get; set; }
        public System.DateTime fecha_cierre { get; set; }
        public decimal iva_gastos { get; set; }
        public decimal iva_honorarios { get; set; }
        public decimal iva_retencion { get; set; }
        public decimal iva_gastos_retencion { get; set; }
        public decimal iva_honorarios_retencion { get; set; }
        public virtual ICollection<LiquidacionDetalle> LiquidacionDetalles { get; set; }
    }
}
