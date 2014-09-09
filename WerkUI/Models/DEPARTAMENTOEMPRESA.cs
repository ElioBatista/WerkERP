using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DEPARTAMENTOEMPRESA
    {
        public DEPARTAMENTOEMPRESA()
        {
            this.EMPLEADOes = new List<EMPLEADO>();
        }

        public decimal CODDEPARTAMENTO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMDEPARTAMENTO { get; set; }
        public string DESDEPARTAMENTO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<EMPLEADO> EMPLEADOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
