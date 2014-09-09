using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CLASE
    {
        public CLASE()
        {
            this.DESPACHOes = new List<DESPACHO>();
        }

        public decimal CODCLASE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMCLASE { get; set; }
        public string DESCLASE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<DESPACHO> DESPACHOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
