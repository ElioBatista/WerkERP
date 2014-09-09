using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class NIVELESTUDIO
    {
        public NIVELESTUDIO()
        {
            this.EMPLEADOes = new List<EMPLEADO>();
        }

        public decimal CODNIVEL { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMNIVEL { get; set; }
        public string DESNIVEL { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<EMPLEADO> EMPLEADOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
