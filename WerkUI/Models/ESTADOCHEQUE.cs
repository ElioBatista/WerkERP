using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ESTADOCHEQUE
    {
        public ESTADOCHEQUE()
        {
            this.CAJACHEQUESRECIBIDOS = new List<CAJACHEQUESRECIBIDO>();
            this.CHEQUERECIBIDOes = new List<CHEQUERECIBIDO>();
        }

        public decimal CODESTADO { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMESTADO { get; set; }
        public string DESESTADO { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<CAJACHEQUESRECIBIDO> CAJACHEQUESRECIBIDOS { get; set; }
        public virtual ICollection<CHEQUERECIBIDO> CHEQUERECIBIDOes { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
