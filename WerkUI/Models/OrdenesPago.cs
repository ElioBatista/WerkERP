using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class OrdenesPago
    {
        public OrdenesPago()
        {
            this.OrdenPagoDetalles = new List<OrdenPagoDetalle>();
        }

        public decimal id_orden_pago { get; set; }
        public decimal cod_empresa { get; set; }
        public decimal nro_comprobante { get; set; }
        public System.DateTime fecha { get; set; }
        public string aprobado { get; set; }
        public int cod_usuario_aprobado { get; set; }
        public int id_solicitud_orden_pago { get; set; }
        public virtual SolicitudOrdenPago SolicitudOrdenPago { get; set; }
        public virtual ICollection<OrdenPagoDetalle> OrdenPagoDetalles { get; set; }
    }
}
