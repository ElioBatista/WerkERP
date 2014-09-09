using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CIUDAD
    {
        public CIUDAD()
        {
            this.ZONAs = new List<ZONA>();
        }

        public decimal CODCIUDAD { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODDEPARTAMENTO { get; set; }
        public string NUMCIUDAD { get; set; }
        public string DESCIUDAD { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual DEPARTAMENTO DEPARTAMENTO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<ZONA> ZONAs { get; set; }
    }
}
