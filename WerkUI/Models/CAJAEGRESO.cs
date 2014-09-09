using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CAJAEGRESO
    {
        public decimal CODEGRESO { get; set; }
        public Nullable<decimal> CODTIPOEGRESO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODPAGANZAS { get; set; }
        public Nullable<decimal> NUMEROCUOTA { get; set; }
        public Nullable<decimal> CODCOMPRA { get; set; }
        public Nullable<decimal> NUMCAJA { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<System.DateTime> FECHAMOVIMIENTO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public string OBSERVACION { get; set; }
        public virtual CAJA CAJA { get; set; }
        public virtual FACTURAPAGAR FACTURAPAGAR { get; set; }
        public virtual TIPOEGRESO TIPOEGRESO { get; set; }
        public virtual MONEDA MONEDA { get; set; }
    }
}
