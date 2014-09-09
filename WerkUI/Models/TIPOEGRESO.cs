using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOEGRESO
    {
        public TIPOEGRESO()
        {
            this.CAJAEGRESOS = new List<CAJAEGRESO>();
            this.CAJAINGRESOS = new List<CAJAINGRESO1>();
        }

        public decimal CODTIPOEGRESO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public string NUMTIPOEGRESO { get; set; }
        public string DESTIPOEGRESO { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<CAJAEGRESO> CAJAEGRESOS { get; set; }
        public virtual ICollection<CAJAINGRESO1> CAJAINGRESOS { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
