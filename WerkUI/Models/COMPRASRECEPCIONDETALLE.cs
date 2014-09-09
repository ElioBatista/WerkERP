using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COMPRASRECEPCIONDETALLE
    {
        public decimal CODDETRECEPCION { get; set; }
        public decimal CODRECEPCION { get; set; }
        public Nullable<decimal> CODPRODUCTO { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<decimal> CODCOMPRA { get; set; }
        public virtual COMPRA COMPRA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
