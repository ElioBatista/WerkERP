using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CONOCIMIENTO
    {
        public CONOCIMIENTO()
        {
            this.DESPACHOINTERNOes = new List<DESPACHOINTERNO>();
        }

        public decimal CODCONOCIMIENTO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMCONOCIMIENTO { get; set; }
        public string DESCONOCIMIENTO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<DESPACHOINTERNO> DESPACHOINTERNOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
