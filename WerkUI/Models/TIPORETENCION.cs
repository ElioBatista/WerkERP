using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPORETENCION
    {
        public TIPORETENCION()
        {
            this.COBROTIPORETENs = new List<COBROTIPORETEN>();
            this.PAGOTIPORETENs = new List<PAGOTIPORETEN>();
        }

        public decimal CODTIPORETEN { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMTIPORETEN { get; set; }
        public string DESTIPORETEN { get; set; }
        public Nullable<decimal> PORCENTAJE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public virtual ICollection<COBROTIPORETEN> COBROTIPORETENs { get; set; }
        public virtual ICollection<PAGOTIPORETEN> PAGOTIPORETENs { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
