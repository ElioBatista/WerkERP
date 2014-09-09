using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class FAMILIA
    {
        public FAMILIA()
        {
            this.LINEAs = new List<LINEA>();
            this.PRODUCTOS = new List<PRODUCTO>();
        }

        public decimal CODFAMILIA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMFAMILIA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public string DESFAMILIA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<LINEA> LINEAs { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTOS { get; set; }
    }
}
