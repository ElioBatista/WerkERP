using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COBRORETENCION
    {
        public COBRORETENCION()
        {
            this.COBROTIPORETENs = new List<COBROTIPORETEN>();
            this.COBRANZAS = new List<COBRANZA>();
        }

        public decimal CODCOMPRARETEN { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string CONCEPTO { get; set; }
        public Nullable<decimal> VALORRENTA { get; set; }
        public Nullable<decimal> VALORRENTA2 { get; set; }
        public Nullable<decimal> VALORIVA { get; set; }
        public Nullable<decimal> MONTO { get; set; }
        public Nullable<decimal> BASE { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public string RESPONSABLE { get; set; }
        public string RUCCI { get; set; }
        public string NUMCOMPRARETEN { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODCLIENTE { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<COBROTIPORETEN> COBROTIPORETENs { get; set; }
        public virtual ICollection<COBRANZA> COBRANZAS { get; set; }
    }
}
