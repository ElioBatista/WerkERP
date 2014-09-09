using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ESTADOCIVIL
    {
        public ESTADOCIVIL()
        {
            this.CODEUDORES = new List<CODEUDORE>();
            this.EMPLEADOes = new List<EMPLEADO>();
        }

        public decimal CODCIVIL { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMCIVIL { get; set; }
        public string DESCIVIL { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<CODEUDORE> CODEUDORES { get; set; }
        public virtual ICollection<EMPLEADO> EMPLEADOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
