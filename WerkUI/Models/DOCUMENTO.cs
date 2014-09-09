using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DOCUMENTO
    {
        public decimal CODDOCUMENTO { get; set; }
        public decimal CODEMPLEADO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public string DESDOCUMENTO { get; set; }
        public byte[] IMAGEN { get; set; }
        public byte[] ARCHIVO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual EMPLEADO EMPLEADO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
