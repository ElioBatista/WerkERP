using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class OTCABECERA
    {
        public OTCABECERA()
        {
            this.OTMANOOBRAs = new List<OTMANOOBRA>();
            this.OTPEDIDOCABECERAs = new List<OTPEDIDOCABECERA>();
            this.OTPEDIDOCABECERAs1 = new List<OTPEDIDOCABECERA>();
            this.OTPROBLEMADETALLEs = new List<OTPROBLEMADETALLE>();
            this.OTPROBLEMASOLUCIONs = new List<OTPROBLEMASOLUCION>();
        }

        public decimal CODOT { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODCLIENTE { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODTECNICO { get; set; }
        public Nullable<decimal> NUMOT { get; set; }
        public Nullable<System.DateTime> FECHAMOVIMIENTO { get; set; }
        public Nullable<System.DateTime> FECHAPROCESO { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<System.DateTime> FECHAAUTORI { get; set; }
        public Nullable<System.DateTime> FECHACIERRE { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public string MARCA { get; set; }
        public string MODELO { get; set; }
        public string ESN { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> TOTALOT { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<OTMANOOBRA> OTMANOOBRAs { get; set; }
        public virtual ICollection<OTPEDIDOCABECERA> OTPEDIDOCABECERAs { get; set; }
        public virtual ICollection<OTPEDIDOCABECERA> OTPEDIDOCABECERAs1 { get; set; }
        public virtual ICollection<OTPROBLEMADETALLE> OTPROBLEMADETALLEs { get; set; }
        public virtual ICollection<OTPROBLEMASOLUCION> OTPROBLEMASOLUCIONs { get; set; }
    }
}
