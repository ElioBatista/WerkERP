using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class V_FACTURAS_LEGACY
    {
        public string Nro__Factura { get; set; }
        public string Nro__Despacho { get; set; }
        public Nullable<decimal> Nro__Liquidación { get; set; }
        public string Nro__Despacho_Interno { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<decimal> Total_IVA { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Importe_Descuentos { get; set; }
        public Nullable<decimal> Importe_Gastos { get; set; }
        public Nullable<decimal> Importe_Honorarios { get; set; }
        public string Tipo { get; set; }
        public string Despachante { get; set; }
        public string Cliente { get; set; }
        public string Moneda { get; set; }
        public Nullable<decimal> Cod__Despachante { get; set; }
        public string Technology { get; set; }
        public string Tipo_Movimiento { get; set; }
        public Nullable<decimal> Cod__Liquidación { get; set; }
    }
}
