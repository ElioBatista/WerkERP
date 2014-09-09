using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class RESPONSABLE
    {
        public RESPONSABLE()
        {
            this.COMPRAS = new List<COMPRA>();
        }

        public string NUMRESPONSABLE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public string DESRESPONSABLE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<COMPRA> COMPRAS { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
