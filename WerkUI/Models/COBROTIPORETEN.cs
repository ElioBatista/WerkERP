using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COBROTIPORETEN
    {
        public decimal CODCOMPRARETEN { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public decimal CODTIPORETEN { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> PORCENTAJE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual COBRORETENCION COBRORETENCION { get; set; }
        public virtual TIPORETENCION TIPORETENCION { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
