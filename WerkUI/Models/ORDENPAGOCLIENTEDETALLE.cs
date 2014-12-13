using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class ORDENPAGOCLIENTEDETALLE
    {
        public decimal CODORDENPAGOCLIENTE { get; set; }
        public decimal CODDESPACHOINTERNO { get; set; }
        public decimal SECUENCIA { get; set; }
        public Nullable<decimal> CODTIPOPAGO { get; set; }
        public Nullable<decimal> CODDEBITO { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODPROPOSITO { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> NUMEROTALON { get; set; }
        public Nullable<System.DateTime> FECHAPRESENTACION { get; set; }
        public Nullable<System.DateTime> FECHARETIRO { get; set; }
        public Nullable<decimal> IMPORTEACEPTADO { get; set; }
        public Nullable<decimal> CODVENTA { get; set; }
        public string OBSERVACION { get; set; }
    }
}
