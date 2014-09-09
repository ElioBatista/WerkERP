using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ORDENPLANDECUENTA
    {
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public Nullable<byte> ACTIVO { get; set; }
        public Nullable<byte> PASIVO { get; set; }
        public Nullable<byte> INGRESOS { get; set; }
        public Nullable<byte> EGRESOS { get; set; }
        public Nullable<decimal> RESULTADO { get; set; }
        public Nullable<decimal> PATRIMONIO { get; set; }
        public Nullable<byte> FUTURO1 { get; set; }
        public Nullable<byte> FUTURO2 { get; set; }
        public Nullable<byte> FUTURO3 { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
