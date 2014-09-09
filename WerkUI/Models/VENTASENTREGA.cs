using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class VENTASENTREGA
    {
        public decimal CODENTREGA { get; set; }
        public Nullable<decimal> CODVENTA { get; set; }
        public Nullable<decimal> CODPRODUCTO { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<System.DateTime> FECHAENTREGA { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
