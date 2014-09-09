using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ORDENPAGOCHEQUE
    {
        public decimal CODAFECTADA { get; set; }
        public Nullable<decimal> CODDEBITO { get; set; }
        public Nullable<decimal> NROORDEN { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> CODCOMPRA { get; set; }
        public Nullable<decimal> NUMEROCUOTA { get; set; }
        public Nullable<decimal> IMPORTEPAGO { get; set; }
        public virtual DEBITO DEBITO { get; set; }
        public virtual FACTURAPAGAR FACTURAPAGAR { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual ORDENPAGO ORDENPAGO { get; set; }
    }
}
