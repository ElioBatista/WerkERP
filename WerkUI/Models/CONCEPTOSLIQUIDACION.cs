using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class ConceptosLiquidacion
    {
        public ConceptosLiquidacion()
        {
            this.SolicitudOrdenPagoDetalles = new List<SolicitudOrdenPagoDetalle>();
        }

        public decimal cod_concepto_liquidacion { get; set; }
        public Nullable<decimal> cod_empresa { get; set; }
        public string nro_concepto { get; set; }
        public string descripcion { get; set; }
        public Nullable<byte> grupo_impresion { get; set; }
        public virtual ICollection<SolicitudOrdenPagoDetalle> SolicitudOrdenPagoDetalles { get; set; }
    }
}
