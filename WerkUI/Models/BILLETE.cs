using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class BILLETE
    {
        public BILLETE()
        {
            this.DESGLOSEBILLETEDETs = new List<DESGLOSEBILLETEDET>();
        }

        public decimal CODBILLETE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMBILLETE { get; set; }
        public Nullable<decimal> MONTO { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<DESGLOSEBILLETEDET> DESGLOSEBILLETEDETs { get; set; }
    }
}
