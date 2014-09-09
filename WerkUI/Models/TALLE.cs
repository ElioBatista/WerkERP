using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TALLE
    {
        public TALLE()
        {
            this.PRODUCTOS = new List<PRODUCTO>();
        }

        public string NUMTALLE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public string DESTALLE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTOS { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
