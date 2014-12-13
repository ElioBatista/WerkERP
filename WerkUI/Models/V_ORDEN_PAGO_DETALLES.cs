using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class V_ORDEN_PAGO_DETALLES
    {
        public decimal CODORDENPAGOCLIENTE { get; set; }
        public string NUMDESPACHOINTERNO { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string DESTIPOPAGO { get; set; }
        public string DESPROPOSITO { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<System.DateTime> FECHAPRESENTACION { get; set; }
        public Nullable<System.DateTime> FECHARETIRO { get; set; }
        public string OBSERVACION { get; set; }
    }
}
