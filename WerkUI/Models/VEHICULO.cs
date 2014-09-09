using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class VEHICULO
    {
        public VEHICULO()
        {
            this.REPARTOes = new List<REPARTO>();
        }

        public string NUMVEHICULO { get; set; }
        public decimal CODVEHICULO { get; set; }
        public string DESVEHICULO { get; set; }
        public Nullable<byte> PROPIEDAD { get; set; }
        public Nullable<decimal> CODCHOFER { get; set; }
        public string CHAPANRO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual CHOFERE CHOFERE { get; set; }
        public virtual ICollection<REPARTO> REPARTOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
