using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PAGAREFACTURA
    {
        public decimal CODPAGARE { get; set; }
        public decimal NUMEROCUOTAPAGARE { get; set; }
        public decimal CODNUMEROCUOTA { get; set; }
        public decimal CODVENTA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual FACTURACOBRAR FACTURACOBRAR { get; set; }
        public virtual PAGARECUOTA PAGARECUOTA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
