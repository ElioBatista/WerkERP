using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class SALARIOSMINIMO
    {
        public decimal CODSALARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<System.DateTime> FECHADESDE { get; set; }
        public Nullable<System.DateTime> FECHAHASTA { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
