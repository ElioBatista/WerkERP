using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class SEXO
    {
        public SEXO()
        {
            this.EMPLEADOes = new List<EMPLEADO>();
            this.HIJOS = new List<HIJO>();
        }

        public decimal CODSEXO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMSEXO { get; set; }
        public string DESSEXO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<EMPLEADO> EMPLEADOes { get; set; }
        public virtual ICollection<HIJO> HIJOS { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
