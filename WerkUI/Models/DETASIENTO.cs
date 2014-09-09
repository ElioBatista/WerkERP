using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DETASIENTO
    {
        public decimal CODDETASIENTO { get; set; }
        public decimal CODASIENTO { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public string COMENTARIO { get; set; }
        public Nullable<decimal> IMPORTED { get; set; }
        public Nullable<decimal> IMPORTEH { get; set; }
        public Nullable<byte> ELIMINADO { get; set; }
        public virtual ASIENTO ASIENTO { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
    }
}
