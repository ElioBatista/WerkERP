using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class Resultado
    {
        public decimal CODPAIS { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMPAIS { get; set; }
        public string DESPAIS { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
    }
}
