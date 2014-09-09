using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ProFormaFactura
    {
        public decimal cod_ProFormafactura { get; set; }
        public Nullable<decimal> num_factura { get; set; }
        public Nullable<decimal> cod_cliente { get; set; }
        public Nullable<decimal> cod_liquidacion { get; set; }
        public Nullable<int> cod_moneda { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public Nullable<int> cod_empresa { get; set; }
        public string telefono { get; set; }
        public Nullable<System.Guid> cod_tipo_factura { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<decimal> iva_gastos { get; set; }
        public Nullable<decimal> iva_honorarios { get; set; }
        public Nullable<decimal> retencion_iva { get; set; }
        public Nullable<decimal> retencion_iva_gastos { get; set; }
        public decimal retencion_iva_honorarios { get; set; }
        public Nullable<decimal> nro_despacho_interno { get; set; }
        public string nro_despacho { get; set; }
        public virtual Moneda Moneda { get; set; }
        public virtual TipoFactura TipoFactura { get; set; }
    }
}
