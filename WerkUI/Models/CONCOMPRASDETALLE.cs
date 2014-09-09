using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CONCOMPRASDETALLE
    {
        public decimal CODCONCOMPRA { get; set; }
        public decimal CONLINEA { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public Nullable<decimal> IMPORTEEXENTO { get; set; }
        public Nullable<decimal> IMPORTENETOGRAVADO { get; set; }
        public Nullable<byte> TIPOMOVIMIENTO { get; set; }
        public string COMENTARIO { get; set; }
        public virtual CONCOMPRA CONCOMPRA { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
    }
}
