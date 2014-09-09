using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DESCUENTOCLIENTEPRODUCTO
    {
        public decimal CODCLIENTE { get; set; }
        public decimal CODPRODUCTO { get; set; }
        public decimal CODDESCUENTO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual DESCUENTOPRODUCTO DESCUENTOPRODUCTO { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
