using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class RESPONSABLERECEPCION
    {
        public decimal CODRESPONSABLERECEPCION { get; set; }
        public string NUMRESPONSABLERECEPCION { get; set; }
        public string DESRESPONSABLERECEPCION { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
