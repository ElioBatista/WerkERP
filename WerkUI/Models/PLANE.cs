using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PLANE
    {
        public decimal CODPLANCUENTAMOD { get; set; }
        public Nullable<decimal> CODMODELO { get; set; }
        public Nullable<decimal> NUMPLANCUENTAMOD { get; set; }
        public string DESPLANCUENTAMOD { get; set; }
        public Nullable<decimal> TIPOCUENTAMOD { get; set; }
        public Nullable<byte> ASENTABLEMOD { get; set; }
        public Nullable<decimal> NIVELCUENTAMOD { get; set; }
        public Nullable<decimal> SUBCUENTAMOD { get; set; }
        public Nullable<decimal> USUGRA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public string DESSUBCUENTAMOD { get; set; }
        public virtual MODELO MODELO { get; set; }
    }
}
