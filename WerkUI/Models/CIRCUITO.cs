using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CIRCUITO
    {
        public CIRCUITO()
        {
            this.CIRCUITOVISITAS = new List<CIRCUITOVISITA>();
            this.CLIENTES = new List<CLIENTE>();
        }

        public decimal CODCIRCUITO { get; set; }
        public string NUMCIRCUITO { get; set; }
        public string DESCIRCUITO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODRUTA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<CIRCUITOVISITA> CIRCUITOVISITAS { get; set; }
        public virtual ICollection<CLIENTE> CLIENTES { get; set; }
    }
}
