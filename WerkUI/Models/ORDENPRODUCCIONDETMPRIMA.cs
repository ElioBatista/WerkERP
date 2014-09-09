using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ORDENPRODUCCIONDETMPRIMA
    {
        public decimal CODORDENPRODUCCION { get; set; }
        public decimal CODLINEA { get; set; }
        public decimal CODPRODUCTO { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public Nullable<decimal> COSTO { get; set; }
        public Nullable<decimal> CODMEDIDA { get; set; }
        public virtual ORDENPRODUCCIONDETALLE ORDENPRODUCCIONDETALLE { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual UNIDADMEDIDA UNIDADMEDIDA { get; set; }
    }
}
