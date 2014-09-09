using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class RUBRO
    {
        public RUBRO()
        {
            this.PRODUCTOS = new List<PRODUCTO>();
        }

        public decimal CODRUBRO { get; set; }
        public Nullable<decimal> CODLINEA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMRUBRO { get; set; }
        public string DESRUBRO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual LINEA LINEA { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTOS { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
