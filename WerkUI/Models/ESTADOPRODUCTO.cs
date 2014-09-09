using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ESTADOPRODUCTO
    {
        public ESTADOPRODUCTO()
        {
            this.PRODUCTOS = new List<PRODUCTO>();
        }

        public decimal CODESTADOPRODUCTO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMESTADOPRODUCTO { get; set; }
        public string DESESTADOPRODUCTO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTOS { get; set; }
    }
}
