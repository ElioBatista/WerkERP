using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOCOBRO
    {
        public TIPOCOBRO()
        {
            this.COBROSCUPONES = new List<COBROSCUPONE>();
        }

        public decimal CODCOBRO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMCOBRO { get; set; }
        public string DESCOBRO { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<COBROSCUPONE> COBROSCUPONES { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
