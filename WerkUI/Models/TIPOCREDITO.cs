using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOCREDITO
    {
        public TIPOCREDITO()
        {
            this.CREDITOS = new List<CREDITO>();
        }

        public decimal CODTIPOCREDITO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMTIPOCREDITO { get; set; }
        public string DESTIPOCREDITO { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public virtual ICollection<CREDITO> CREDITOS { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
