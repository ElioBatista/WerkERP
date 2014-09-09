using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class SALARIO
    {
        public decimal CODSALARIO { get; set; }
        public decimal CODEMPLEADO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<byte> TIPOSALARIO { get; set; }
        public Nullable<System.DateTime> FECHAVIGENCIADESDE { get; set; }
        public Nullable<System.DateTime> FECHAVIGENCIAHASTA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODIVA { get; set; }
        public virtual EMPLEADO EMPLEADO { get; set; }
        public virtual IVA IVA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
