using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COLOR
    {
        public COLOR()
        {
            this.PRODUCTOS = new List<PRODUCTO>();
        }

        public string NUMCOLOR { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public string DESCOLOR { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTOS { get; set; }
    }
}
