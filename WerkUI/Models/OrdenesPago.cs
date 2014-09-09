using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class OrdenesPago
    {
        public OrdenesPago()
        {
            this.OrdenPagoDetalles = new List<OrdenPagoDetalle>();
        }

        public decimal id_orden_pago { get; set; }
        public Nullable<decimal> cod_comprobante { get; set; }
        public Nullable<decimal> cod_empresa { get; set; }
        public Nullable<decimal> nro_comprobante { get; set; }
        public System.DateTime fecha { get; set; }
        public string aprobado { get; set; }
        public Nullable<int> cod_usuario_aprobado { get; set; }
        public virtual ICollection<OrdenPagoDetalle> OrdenPagoDetalles { get; set; }
    }
}
