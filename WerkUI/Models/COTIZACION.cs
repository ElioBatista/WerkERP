using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COTIZACION
    {
        public System.DateTime FECHAMOVIMIENTO { get; set; }
        public decimal CODMONEDA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public Nullable<decimal> FACTORVENTA { get; set; }
        public Nullable<decimal> FACTORCOBRO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
