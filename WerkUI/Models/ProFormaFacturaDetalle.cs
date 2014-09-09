using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ProFormaFacturaDetalle
    {
        public decimal cod_proFormaFactura { get; set; }
        public decimal secuencia_interna { get; set; }
        public string comentario { get; set; }
        public Nullable<decimal> cod_con_liquidacion { get; set; }
        public string descripcion { get; set; }
        public byte grupo_impresion { get; set; }
        public decimal importe { get; set; }
        public Nullable<bool> Facturado { get; set; }
        public virtual Factura Factura { get; set; }
    }
}
