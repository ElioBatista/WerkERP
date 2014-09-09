using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DEBEHABER
    {
        public decimal CODPLANCUENTA { get; set; }
        public decimal CODTIPOASIENTO { get; set; }
        public Nullable<byte> LADO { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual TIPOASIENTO TIPOASIENTO { get; set; }
    }
}
