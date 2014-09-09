using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOCUENTA
    {
        public TIPOCUENTA()
        {
            this.CUENTABANCARIAs = new List<CUENTABANCARIA>();
        }

        public decimal CODTIPOCUENTA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMTIPOCUENTA { get; set; }
        public string DESTIPOCUENTA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public virtual ICollection<CUENTABANCARIA> CUENTABANCARIAs { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
