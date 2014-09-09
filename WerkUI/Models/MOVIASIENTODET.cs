using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class MOVIASIENTODET
    {
        public decimal CODDETASIENTO { get; set; }
        public decimal CODASIENTO { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public string COMENTARIO { get; set; }
        public Nullable<decimal> IMPORTEDEBE { get; set; }
        public Nullable<decimal> IMPORTEHABER { get; set; }
        public virtual MOVIASIENTO MOVIASIENTO { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
    }
}
