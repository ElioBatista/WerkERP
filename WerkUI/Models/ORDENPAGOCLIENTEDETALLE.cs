using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ORDENPAGOCLIENTEDETALLE
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
        public virtual DEBITO DEBITO { get; set; }
        public virtual DEBITO DEBITO1 { get; set; }
        public virtual DESPACHOINTERNO DESPACHOINTERNO { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual ORDENPAGOCLIENTE ORDENPAGOCLIENTE { get; set; }
        public virtual PROPOSITOCHEQUE PROPOSITOCHEQUE { get; set; }
        public virtual TIPOPAGO TIPOPAGO { get; set; }
    }
}
