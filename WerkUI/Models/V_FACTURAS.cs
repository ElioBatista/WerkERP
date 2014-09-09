using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class V_FACTURAS
    {
        public int cod_factura { get; set; }
        public string Nro__Factura { get; set; }
        public string Nro__Despacho { get; set; }
        public Nullable<int> Nro__Liquidación { get; set; }
        public Nullable<int> Nro__Despacho_Interno { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> IVA_Gastos { get; set; }
        public Nullable<decimal> IVA_Honorarios { get; set; }
        public Nullable<decimal> IVA_Retención { get; set; }
        public Nullable<decimal> IVA_Ret__Gastos { get; set; }
        public Nullable<decimal> IVA_Ret__Honorarios { get; set; }
        public string Cliente { get; set; }
        public string Dirección { get; set; }
        public string Teléfono { get; set; }
        public string R_U_C_ { get; set; }
        public string Despachante { get; set; }
        public string R_U_C__Despachante { get; set; }
        public string Tipo_Factura { get; set; }
        public string moneda { get; set; }
        public string Estado { get; set; }
        public Nullable<int> Cod__Despachante { get; set; }
        public Nullable<decimal> Importe_Gastos { get; set; }
        public Nullable<decimal> Importe_Honorarios { get; set; }
        public Nullable<decimal> Importe_Descuentos { get; set; }
        public Nullable<decimal> Total_IVA { get; set; }
        public string Technology { get; set; }
        public string Tipo_Movimiento { get; set; }
    }
}
