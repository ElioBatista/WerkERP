using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DEPRECIACION
    {
        public decimal ANHODEPRE { get; set; }
        public decimal MESDEPRE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> TASADEPRE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
