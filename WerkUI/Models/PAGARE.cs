using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PAGARE
    {
        public PAGARE()
        {
            this.PAGARECUOTAS = new List<PAGARECUOTA>();
            this.CODEUDORES = new List<CODEUDORE>();
        }

        public decimal CODPAGARE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODCLIENTE { get; set; }
        public Nullable<decimal> NUMPAGARE { get; set; }
        public string DESPAGARE { get; set; }
        public Nullable<System.DateTime> FECHAEMISION { get; set; }
        public Nullable<System.DateTime> FECHAVCTO { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> SALDOPAGARE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODOPERACION { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual ICollection<PAGARECUOTA> PAGARECUOTAS { get; set; }
        public virtual ICollection<CODEUDORE> CODEUDORES { get; set; }
    }
}
