using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class MODULOUSUARIO
    {
        public decimal CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public decimal CODMODULO { get; set; }
        public Nullable<byte> SELECT { get; set; }
        public Nullable<byte> INSERT { get; set; }
        public Nullable<byte> UPDATE { get; set; }
        public Nullable<byte> DELETE { get; set; }
        public Nullable<byte> PRINT { get; set; }
        public Nullable<byte> VENCIDAS { get; set; }
        public Nullable<byte> LIMITECREDITO { get; set; }
        public Nullable<byte> DESC { get; set; }
        public Nullable<byte> ANULAR { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual MODULO MODULO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
