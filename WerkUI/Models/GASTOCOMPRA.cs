using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class GASTOCOMPRA
    {
        public decimal CODGASTO { get; set; }
        public string NUMGASTO { get; set; }
        public string DESGASTO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
