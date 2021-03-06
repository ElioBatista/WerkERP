using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class NACIONALIDAD
    {
        public NACIONALIDAD()
        {
            this.EMPLEADOes = new List<EMPLEADO>();
        }

        public decimal CODNACIONALIDAD { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMNACIONALIDAD { get; set; }
        public string DESNACIONALIDAD { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<EMPLEADO> EMPLEADOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
