using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ORDENPRODUCCIONDETALLE
    {
        public ORDENPRODUCCIONDETALLE()
        {
            this.ORDENPRODUCCIONDETMPRIMAs = new List<ORDENPRODUCCIONDETMPRIMA>();
        }

        public decimal CODORDENPRODUCCION { get; set; }
        public Nullable<decimal> CODPRODUCTO { get; set; }
        public decimal CODLINEA { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public Nullable<decimal> COSTO { get; set; }
        public virtual ORDENPRODUCCIONCABECERA ORDENPRODUCCIONCABECERA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual ICollection<ORDENPRODUCCIONDETMPRIMA> ORDENPRODUCCIONDETMPRIMAs { get; set; }
    }
}
