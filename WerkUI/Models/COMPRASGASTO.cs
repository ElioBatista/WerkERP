using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COMPRASGASTO
    {
        public decimal CODCOMPRA { get; set; }
        public decimal CODGASTO { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
    }
}
