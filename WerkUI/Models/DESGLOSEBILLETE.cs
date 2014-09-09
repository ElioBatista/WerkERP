using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DESGLOSEBILLETE
    {
        public DESGLOSEBILLETE()
        {
            this.DESGLOSEBILLETEDETs = new List<DESGLOSEBILLETEDET>();
        }

        public decimal CODDESGLOSE { get; set; }
        public string NUMDESGLOSE { get; set; }
        public Nullable<decimal> CODBANCO { get; set; }
        public string NUMCUENTA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual CUENTABANCARIA CUENTABANCARIA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<DESGLOSEBILLETEDET> DESGLOSEBILLETEDETs { get; set; }
    }
}
