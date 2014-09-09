using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CHEQUERA
    {
        public CHEQUERA()
        {
            this.DEBITOS = new List<DEBITO>();
        }

        public decimal CODTIPOCHEQUE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public string NUMCUENTA { get; set; }
        public Nullable<decimal> RANGO1 { get; set; }
        public Nullable<decimal> RANGO2 { get; set; }
        public Nullable<decimal> ULTIMONUMERO { get; set; }
        public string NOMREPORT { get; set; }
        public decimal CODBANCO { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public virtual CUENTABANCARIA CUENTABANCARIA { get; set; }
        public virtual TIPOCHEQUE TIPOCHEQUE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual ICollection<DEBITO> DEBITOS { get; set; }
    }
}
