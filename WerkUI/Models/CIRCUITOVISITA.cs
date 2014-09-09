using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CIRCUITOVISITA
    {
        public decimal CODCIRCUITO { get; set; }
        public decimal CODDIAS { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public virtual CIRCUITO CIRCUITO { get; set; }
        public virtual CIRCUITODIA CIRCUITODIA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
