using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class LEGAJO
    {
        public decimal CODLEGAJO { get; set; }
        public decimal CODEMPLEADO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual EMPLEADO EMPLEADO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
