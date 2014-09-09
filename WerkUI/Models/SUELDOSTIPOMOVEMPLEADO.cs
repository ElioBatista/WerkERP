using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class SUELDOSTIPOMOVEMPLEADO
    {
        public decimal CODDETALLE { get; set; }
        public Nullable<decimal> CODTIPOMOV { get; set; }
        public Nullable<decimal> CODEMPLEADO { get; set; }
        public Nullable<System.DateTime> FECHAINICIO { get; set; }
        public Nullable<System.DateTime> FECHAVENCIMIENTO { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> CODIVA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public virtual EMPLEADO EMPLEADO { get; set; }
        public virtual IVA IVA { get; set; }
        public virtual TIPOMOVIMIENTOSUELDO TIPOMOVIMIENTOSUELDO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
