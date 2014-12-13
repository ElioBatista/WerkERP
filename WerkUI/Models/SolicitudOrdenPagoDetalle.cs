using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WerkUI.Models
{
    public partial class SolicitudOrdenPagoDetalle
    {
        public long id_solicitud_orden_pago_detalle { get; set; }
        public int id_solicitud_orden_pago { get; set; }
        public decimal nro_despacho_interno { get; set; }

        
        public decimal importe { get; set; }
        public string observacion { get; set; }
        public string nro_concepto { get; set; }
        public int cod_moneda { get; set; }
        public Nullable<decimal> importe_aprobado { get; set; }
        public Nullable<long> id_cheque { get; set; }
        public virtual Moneda Moneda { get; set; }
        public virtual Cheque Cheque { get; set; }
        public virtual ConceptosLiquidacion ConceptosLiquidacion { get; set; }
        public virtual SolicitudOrdenPago SolicitudOrdenPago { get; set; }
    }
}
