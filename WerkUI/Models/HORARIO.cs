using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class HORARIO
    {
        public decimal CODHORARIO { get; set; }
        public decimal CODEMPLEADO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> ENTRADA { get; set; }
        public Nullable<System.DateTime> SALIDA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual EMPLEADO EMPLEADO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
