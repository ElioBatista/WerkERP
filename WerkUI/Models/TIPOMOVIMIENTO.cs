using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOMOVIMIENTO
    {
        public TIPOMOVIMIENTO()
        {
            this.DESPACHOINTERNOes = new List<DESPACHOINTERNO>();
        }

        public decimal CODTIPOMOVIMIENTO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMTIPOMOVIMIENTO { get; set; }
        public string DESTIPOMOVIMIENTO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<DESPACHOINTERNO> DESPACHOINTERNOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
