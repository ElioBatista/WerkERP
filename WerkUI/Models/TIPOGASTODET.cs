using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOGASTODET
    {
        public TIPOGASTODET()
        {
            this.COMPRAS = new List<COMPRA>();
            this.CONCOMPRAS = new List<CONCOMPRA>();
        }

        public decimal CODTIPOGASTO { get; set; }
        public decimal CODTIPOGASTODET { get; set; }
        public string NUMTIPOGASTODET { get; set; }
        public Nullable<byte> PREDETERMINADO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public string DESTIPOGASTODET { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public virtual ICollection<COMPRA> COMPRAS { get; set; }
        public virtual ICollection<CONCOMPRA> CONCOMPRAS { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual TIPOGASTO TIPOGASTO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
