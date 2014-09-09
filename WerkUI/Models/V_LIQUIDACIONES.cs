using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class V_LIQUIDACIONES
    {
        public decimal Cod__Liquidación { get; set; }
        public Nullable<decimal> Nro__Liquidación { get; set; }
        public string Nro__Despacho { get; set; }
        public string Nro__Despacho_Interno { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Usuario { get; set; }
        public string Empresa { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public Nullable<System.DateTime> Cierre { get; set; }
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
        public Nullable<decimal> CODDESPACHANTE { get; set; }
        public Nullable<decimal> CODCLIENTE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string Tipo_Movimiento { get; set; }
    }
}
