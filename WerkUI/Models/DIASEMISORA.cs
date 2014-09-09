using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DIASEMISORA
    {
        public decimal CODDIASEMISORA { get; set; }
        public decimal CODEMISORA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual EMISORA EMISORA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
