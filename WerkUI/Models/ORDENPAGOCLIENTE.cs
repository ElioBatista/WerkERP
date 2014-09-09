using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ORDENPAGOCLIENTE
    {
        public decimal CODORDENPAGOCLIENTE { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMEROCOMPROBANTE { get; set; }
        public Nullable<System.DateTime> FECHAMOVIMIENTO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIOACEPTA { get; set; }
        public Nullable<decimal> CODUSUARIODIF { get; set; }
    }
}
