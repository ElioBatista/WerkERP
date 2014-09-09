using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DEVOLUCIONSUBDETALLE
    {
        public decimal CODDEVOLUCION { get; set; }
        public decimal CODPRODUCTO { get; set; }
        public decimal CODSUBDETALLE { get; set; }
        public Nullable<decimal> CODTPY { get; set; }
        public Nullable<decimal> CODEQUIPO { get; set; }
        public Nullable<decimal> CODSIMCARD { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual EQUIPOSSTOCK EQUIPOSSTOCK { get; set; }
        public virtual SIMCCARDSTOCK SIMCCARDSTOCK { get; set; }
        public virtual TPYSTOCK TPYSTOCK { get; set; }
    }
}
