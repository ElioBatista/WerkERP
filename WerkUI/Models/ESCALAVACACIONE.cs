using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ESCALAVACACIONE
    {
        public decimal CODVACACION { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> DESDE { get; set; }
        public Nullable<decimal> HASTA { get; set; }
        public Nullable<decimal> CANTIDADDIAS { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
