using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PRODUCCIONINGRESOPRODUCTODET
    {
        public decimal CODINGRESOPROTER { get; set; }
        public decimal CODLINEA { get; set; }
        public Nullable<decimal> CODPRODUCTO { get; set; }
        public Nullable<decimal> CODORDENPRODUCCION { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public Nullable<decimal> COSTO { get; set; }
        public virtual PRODUCCIONINGRESOPRODUCTO PRODUCCIONINGRESOPRODUCTO { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
