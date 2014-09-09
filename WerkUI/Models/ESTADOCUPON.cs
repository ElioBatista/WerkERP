using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ESTADOCUPON
    {
        public ESTADOCUPON()
        {
            this.CUPONES = new List<CUPONE>();
        }

        public decimal CODESTADOCUPON { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMESTADOCUPON { get; set; }
        public string DESESTADOCUPON { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<CUPONE> CUPONES { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
