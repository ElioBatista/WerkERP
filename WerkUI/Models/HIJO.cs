using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class HIJO
    {
        public decimal CODHIJO { get; set; }
        public decimal CODEMPLEADO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODSEXO { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<System.DateTime> FECHANACIMIENTO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual EMPLEADO EMPLEADO { get; set; }
        public virtual SEXO SEXO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
