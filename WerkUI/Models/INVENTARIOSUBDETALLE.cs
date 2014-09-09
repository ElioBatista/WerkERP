using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class INVENTARIOSUBDETALLE
    {
        public decimal CODPRODUCTO { get; set; }
        public decimal CODINVENTARIO { get; set; }
        public decimal CODSUBDETALLE { get; set; }
        public Nullable<decimal> CODEQUIPO { get; set; }
        public Nullable<decimal> CODTPY { get; set; }
        public Nullable<decimal> CODSIMCARD { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual EQUIPOSSTOCK EQUIPOSSTOCK { get; set; }
        public virtual INVENTARIODETALLE INVENTARIODETALLE { get; set; }
        public virtual SIMCCARDSTOCK SIMCCARDSTOCK { get; set; }
        public virtual TPYSTOCK TPYSTOCK { get; set; }
    }
}
