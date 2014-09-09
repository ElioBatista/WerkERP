using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class OrdenPagoDetalle
    {
        public decimal id_orden_pago { get; set; }
        public decimal cod_despacho_interno { get; set; }
        public Nullable<int> secuencia { get; set; }
        public Nullable<int> cod_tipo_pago { get; set; }
        public Nullable<decimal> cod_debito { get; set; }
        public Nullable<int> cod_moneda { get; set; }
        public Nullable<decimal> cod_porposito { get; set; }
        public Nullable<decimal> importe { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<decimal> importe_aceptado { get; set; }
        public Nullable<decimal> cod_venta { get; set; }
        public string observacion { get; set; }
        public virtual OrdenesPago OrdenesPago { get; set; }
    }
}
