using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DEPOSITADO
    {
        public DEPOSITADO()
        {
            this.COBROSCUPONES = new List<COBROSCUPONE>();
            this.DEPOSITOCUPONs = new List<DEPOSITOCUPON>();
        }

        public decimal CODDEPOSITO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string DESDEPOSITO { get; set; }
        public Nullable<System.DateTime> FECDEPOSITO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<COBROSCUPONE> COBROSCUPONES { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<DEPOSITOCUPON> DEPOSITOCUPONs { get; set; }
    }
}
