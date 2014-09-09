using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CONCEPTOTIPOMOVIMIENTO
    {
        public decimal CODTIPOMOVDET { get; set; }
        public decimal CODTIPOMOVCABECERA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string OPERACION { get; set; }
        public decimal CODTIPOMOV { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual TIPOMOVIMIENTOSUELDODETALLE TIPOMOVIMIENTOSUELDODETALLE { get; set; }
        public virtual TIPOMOVIMIENTOSUELDO TIPOMOVIMIENTOSUELDO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
