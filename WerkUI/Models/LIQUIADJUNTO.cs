using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class LIQUIADJUNTO
    {
        public decimal CODDESPACHO { get; set; }
        public decimal SECUENCIAINTERNA { get; set; }
        public Nullable<decimal> CODADJUNTO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public virtual ADJUNTO ADJUNTO { get; set; }
        public virtual DESPACHO DESPACHO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
