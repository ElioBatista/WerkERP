using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class VIDAUTIL
    {
        public VIDAUTIL()
        {
            this.ACTIVOFIJOes = new List<ACTIVOFIJO>();
        }

        public decimal CODVIDAUTIL { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string DESVIDAUTIL { get; set; }
        public Nullable<decimal> CANTIDADANHO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<ACTIVOFIJO> ACTIVOFIJOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
