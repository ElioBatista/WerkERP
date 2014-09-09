using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPODEBITO
    {
        public TIPODEBITO()
        {
            this.DEBITOS = new List<DEBITO>();
        }

        public decimal CODTIPODEBITO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMTIPODEBITO { get; set; }
        public string DESTIPODEBITO { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public Nullable<byte> IMPRIMECHEQUE { get; set; }
        public virtual ICollection<DEBITO> DEBITOS { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
