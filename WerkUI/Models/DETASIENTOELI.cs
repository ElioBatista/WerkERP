using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DETASIENTOELI
    {
        public decimal CODDETASIENTOELI { get; set; }
        public decimal CODASIENTOELI { get; set; }
        public decimal CODASIENTO { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public Nullable<decimal> IMPORTED { get; set; }
        public Nullable<decimal> IMPORTEH { get; set; }
        public string COMENTARIO { get; set; }
        public virtual ASIENTOSELI ASIENTOSELI { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
    }
}
