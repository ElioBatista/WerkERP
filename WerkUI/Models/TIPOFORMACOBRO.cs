using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOFORMACOBRO
    {
        public TIPOFORMACOBRO()
        {
            this.CAJAFORMACOBROes = new List<CAJAFORMACOBRO>();
            this.COBRANZAS1 = new List<COBRANZA>();
            this.COBROSANULADOS = new List<COBROSANULADO>();
        }

        public decimal CODFORCOBRO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public string NUMFORCOBRO { get; set; }
        public string DESFORCOBRO { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public Nullable<byte> COBRANZAS { get; set; }
        public Nullable<byte> CAJA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<CAJAFORMACOBRO> CAJAFORMACOBROes { get; set; }
        public virtual ICollection<COBRANZA> COBRANZAS1 { get; set; }
        public virtual ICollection<COBROSANULADO> COBROSANULADOS { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
