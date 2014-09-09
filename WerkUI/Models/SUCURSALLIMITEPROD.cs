using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class SUCURSALLIMITEPROD
    {
        public decimal CODSUCURSAL { get; set; }
        public decimal CODPRODUCTO { get; set; }
        public Nullable<decimal> CANTIDADMAXIMA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
