using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class AUTORIZACION
    {
        public string IP { get; set; }
        public decimal CODEMPRESA { get; set; }
        public decimal CODSUCURSAL { get; set; }
        public Nullable<decimal> CODCLIENTE { get; set; }
        public Nullable<decimal> USUFAC { get; set; }
        public Nullable<decimal> USUAUT { get; set; }
        public Nullable<System.DateTime> FECAUT { get; set; }
        public Nullable<decimal> TOTALFACTURA { get; set; }
        public Nullable<byte> SOLICITAVENCIMIENTO { get; set; }
        public Nullable<byte> SOLICITALIMITE { get; set; }
        public Nullable<byte> AUTORIZAVENCIMIENTO { get; set; }
        public Nullable<byte> AUTORIZALIMITE { get; set; }
    }
}
