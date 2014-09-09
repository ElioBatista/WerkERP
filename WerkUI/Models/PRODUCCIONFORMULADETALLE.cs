using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PRODUCCIONFORMULADETALLE
    {
        public decimal CODFORMULA { get; set; }
        public decimal CODLINEA { get; set; }
        public Nullable<decimal> CODPRODUCTO { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public Nullable<decimal> CODMEDIDA { get; set; }
        public virtual PRODUCCIONFORMULA PRODUCCIONFORMULA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual UNIDADMEDIDA UNIDADMEDIDA { get; set; }
    }
}
