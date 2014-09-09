using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CAJASALDO
    {
        public decimal NUMCIERRE { get; set; }
        public decimal CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> SALDOINICIAL { get; set; }
        public Nullable<decimal> SALDOCIERRE { get; set; }
        public virtual CAJACIERRE CAJACIERRE { get; set; }
        public virtual MONEDA MONEDA { get; set; }
    }
}
