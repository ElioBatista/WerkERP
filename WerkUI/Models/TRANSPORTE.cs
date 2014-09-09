using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TRANSPORTE
    {
        public TRANSPORTE()
        {
            this.DESPACHOes = new List<DESPACHO>();
        }

        public decimal CODTRANSPORTE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMTRANSPORTE { get; set; }
        public string DESTRANSPORTE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<DESPACHO> DESPACHOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
