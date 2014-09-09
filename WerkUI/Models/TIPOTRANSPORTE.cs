using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOTRANSPORTE
    {
        public TIPOTRANSPORTE()
        {
            this.ORDENCOMPRAs = new List<ORDENCOMPRA>();
        }

        public decimal CODTRANSPORTE { get; set; }
        public string NUMTRANSPORTE { get; set; }
        public string DESTRANSPORTE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<ORDENCOMPRA> ORDENCOMPRAs { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
