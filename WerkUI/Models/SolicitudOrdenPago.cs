using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class SolicitudOrdenPago
    {
        public SolicitudOrdenPago()
        {
            this.Cheques = new List<Cheque>();
            this.OrdenesPagoes = new List<OrdenesPago>();
            this.SolicitudOrdenPagoDetalles = new List<SolicitudOrdenPagoDetalle>();
        }

        public int id_solicitud_orden_pago { get; set; }
        public decimal nro_comprobante { get; set; }
        public System.DateTime fecha_solicitud { get; set; }
        public short id_estado { get; set; }
        public Nullable<int> cod_usuario { get; set; }
        public virtual ICollection<Cheque> Cheques { get; set; }
        public virtual EstadoSolicitud EstadoSolicitud { get; set; }
        public virtual ICollection<OrdenesPago> OrdenesPagoes { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<SolicitudOrdenPagoDetalle> SolicitudOrdenPagoDetalles { get; set; }
    }
}
