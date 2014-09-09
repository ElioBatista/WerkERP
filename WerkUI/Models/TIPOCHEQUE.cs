using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOCHEQUE
    {
        public TIPOCHEQUE()
        {
            this.CHEQUERAs = new List<CHEQUERA>();
            this.DEBITOS = new List<DEBITO>();
        }

        public decimal CODTIPOCHEQUE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMTIPOCHEQUE { get; set; }
        public string DESTIPOCHEQUE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public virtual ICollection<CHEQUERA> CHEQUERAs { get; set; }
        public virtual ICollection<DEBITO> DEBITOS { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
