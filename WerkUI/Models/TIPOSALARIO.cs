using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOSALARIO
    {
        public TIPOSALARIO()
        {
            this.EMPLEADOes = new List<EMPLEADO>();
        }

        public decimal CODTIPOSALARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMTIPOSALARIO { get; set; }
        public string DESTIPOSALARIO { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<EMPLEADO> EMPLEADOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
