using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class KIT
    {
        public decimal CODKITS { get; set; }
        public Nullable<decimal> CODPRODUCTO { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
