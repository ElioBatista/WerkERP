using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CATEGORIA
    {
        public CATEGORIA()
        {
            this.EMPLEADOes = new List<EMPLEADO>();
        }

        public decimal CODCATEGORIA { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMCATEGORIA { get; set; }
        public string DESCATEGORIA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<EMPLEADO> EMPLEADOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
