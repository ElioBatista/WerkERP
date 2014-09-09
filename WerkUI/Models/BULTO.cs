using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class BULTO
    {
        public BULTO()
        {
            this.DESPACHODETALLEs = new List<DESPACHODETALLE>();
        }

        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMBULTO { get; set; }
        public string DESBULTO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public decimal CODBULTO { get; set; }
        public virtual ICollection<DESPACHODETALLE> DESPACHODETALLEs { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
