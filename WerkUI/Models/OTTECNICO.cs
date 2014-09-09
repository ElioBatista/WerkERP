using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class OTTECNICO
    {
        public OTTECNICO()
        {
            this.OTPEDIDOCABECERAs = new List<OTPEDIDOCABECERA>();
        }

        public decimal CODTECNICO { get; set; }
        public string NUMTECNICO { get; set; }
        public string DESTECNICO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<byte> RECEPCION { get; set; }
        public virtual ICollection<OTPEDIDOCABECERA> OTPEDIDOCABECERAs { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
