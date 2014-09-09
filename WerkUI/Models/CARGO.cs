using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CARGO
    {
        public CARGO()
        {
            this.EMPLEADOes = new List<EMPLEADO>();
        }

        public decimal CODCARGO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMCARGO { get; set; }
        public string DESCARGO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<EMPLEADO> EMPLEADOes { get; set; }
    }
}
