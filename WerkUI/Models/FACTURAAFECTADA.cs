using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class FACTURAAFECTADA
    {
        public decimal CODAFECTADA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODCOBRANZA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODFORCOBRO { get; set; }
        public Nullable<decimal> CODNUMEROCUOTA { get; set; }
        public Nullable<decimal> CODVENTA { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual COBRANZA COBRANZA { get; set; }
        public virtual FACTURACOBRAR FACTURACOBRAR { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
