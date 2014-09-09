using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class FACTURAPAGOAFECTADA
    {
        public decimal CODPAGOAFECTADA { get; set; }
        public Nullable<decimal> NUMEROCUOTA { get; set; }
        public Nullable<decimal> CODCOMPRA { get; set; }
        public Nullable<decimal> CODPAGANZAS { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODTIPOPAGO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public virtual FACTURAPAGAR FACTURAPAGAR { get; set; }
        public virtual PAGANZA PAGANZA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
