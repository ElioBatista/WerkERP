using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CHOFERE
    {
        public CHOFERE()
        {
            this.REPARTOes = new List<REPARTO>();
            this.VEHICULOS = new List<VEHICULO>();
        }

        public decimal CODCHOFER { get; set; }
        public string NUMCHOFER { get; set; }
        public string DESCHOFER { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<REPARTO> REPARTOes { get; set; }
        public virtual ICollection<VEHICULO> VEHICULOS { get; set; }
    }
}
