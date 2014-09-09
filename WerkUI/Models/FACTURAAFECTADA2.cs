using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class FACTURAAFECTADA2
    {
        public decimal CODAFECTADA2 { get; set; }
        public Nullable<decimal> NUMEROCUOTA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODPAGARE { get; set; }
        public Nullable<decimal> CODCOBRANZA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODFORCOBRO { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual COBRANZA COBRANZA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual PAGARECUOTA PAGARECUOTA { get; set; }
    }
}
