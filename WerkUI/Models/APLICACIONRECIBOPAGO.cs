using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class APLICACIONRECIBOPAGO
    {
        public decimal CODAPLICACION { get; set; }
        public decimal CODPAGOAFECTADA { get; set; }
        public decimal CODPAGANZAS { get; set; }
        public decimal CODMONEDA { get; set; }
        public decimal CODTIPOPAGO { get; set; }
        public Nullable<System.DateTime> FECHAAPLICACION { get; set; }
        public byte TIPOAFECTADO { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> COTIZACION1REC { get; set; }
        public Nullable<decimal> COTIZACION2REC { get; set; }
        public Nullable<decimal> CODCOMPRA { get; set; }
        public Nullable<decimal> NUMEROCUOTA { get; set; }
        public Nullable<decimal> IMPMONPAGO { get; set; }
        public virtual PAGANZA PAGANZA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
