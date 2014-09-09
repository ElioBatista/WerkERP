using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOGASTO
    {
        public TIPOGASTO()
        {
            this.TIPOGASTODETs = new List<TIPOGASTODET>();
        }

        public decimal CODTIPOGASTO { get; set; }
        public string NUMTIPOGASTO { get; set; }
        public string DESTIPOGASTO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<TIPOGASTODET> TIPOGASTODETs { get; set; }
    }
}
