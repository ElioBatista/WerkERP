using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PROFESION
    {
        public PROFESION()
        {
            this.EMPLEADOes = new List<EMPLEADO>();
        }

        public decimal CODPROFESION { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMPROFESION { get; set; }
        public string DESPROFESION { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<EMPLEADO> EMPLEADOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
