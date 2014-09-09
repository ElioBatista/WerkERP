using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class MOVISUELDODETALLE
    {
        public decimal CODMOVIDETALLE { get; set; }
        public decimal CODMOVI { get; set; }
        public Nullable<decimal> CODEMPLEADO { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> DIAS { get; set; }
        public Nullable<decimal> HORAS { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<System.DateTime> FECHADESDE { get; set; }
        public Nullable<System.DateTime> FECHAHASTA { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<decimal> CODIVA { get; set; }
        public virtual EMPLEADO EMPLEADO { get; set; }
        public virtual IVA IVA { get; set; }
        public virtual MOVISUELDO MOVISUELDO { get; set; }
    }
}
