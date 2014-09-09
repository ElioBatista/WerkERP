using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CAJACIERRE
    {
        public CAJACIERRE()
        {
            this.CAJASALDOes = new List<CAJASALDO>();
        }

        public decimal NUMCIERRE { get; set; }
        public Nullable<decimal> NUMCAJA { get; set; }
        public Nullable<decimal> CODCOBRADOR { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECAPERTURA { get; set; }
        public Nullable<System.DateTime> FECCIERRE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual CAJA CAJA { get; set; }
        public virtual COBRADOR COBRADOR { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<CAJASALDO> CAJASALDOes { get; set; }
    }
}
