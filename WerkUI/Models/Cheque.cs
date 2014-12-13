using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class Cheque
    {
        public Cheque()
        {
            this.SolicitudOrdenPagoDetalles = new List<SolicitudOrdenPagoDetalle>();
        }

        public long id_cheque { get; set; }
        public Nullable<long> id_proveedor { get; set; }
        public int id_chequera { get; set; }
        public long nro_cheque { get; set; }
        public Nullable<System.DateTime> fecha_emision { get; set; }
        public bool anulado { get; set; }
        public Nullable<System.DateTime> fecha_anulacion { get; set; }
        public string motivo_anulacion { get; set; }
        public Nullable<decimal> monto { get; set; }
        public Nullable<int> cod_moneda { get; set; }
        public Nullable<int> id_orden_pago { get; set; }
        public virtual Moneda Moneda { get; set; }
        public virtual Proveedore Proveedore { get; set; }
        public virtual Proveedore Proveedore1 { get; set; }
        public virtual Chequera Chequera { get; set; }
        public virtual Chequera Chequera1 { get; set; }
        public virtual SolicitudOrdenPago SolicitudOrdenPago { get; set; }
        public virtual ICollection<SolicitudOrdenPagoDetalle> SolicitudOrdenPagoDetalles { get; set; }
    }
}
