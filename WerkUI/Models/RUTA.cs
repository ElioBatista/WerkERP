using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class RUTA
    {
        public RUTA()
        {
            this.REPARTOes = new List<REPARTO>();
        }

        public decimal CODRUTA { get; set; }
        public string NUMRUTA { get; set; }
        public string DESRUTA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<REPARTO> REPARTOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
