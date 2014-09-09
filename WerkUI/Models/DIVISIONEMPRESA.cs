using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DIVISIONEMPRESA
    {
        public DIVISIONEMPRESA()
        {
            this.EMPLEADOes = new List<EMPLEADO>();
        }

        public decimal CODDIVISION { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMDIVISION { get; set; }
        public string DESDIVISION { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<EMPLEADO> EMPLEADOes { get; set; }
    }
}
