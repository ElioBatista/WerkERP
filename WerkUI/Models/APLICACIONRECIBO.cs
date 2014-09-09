using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class APLICACIONRECIBO
    {
        public decimal CODAPLICACION { get; set; }
        public decimal CODAFECTADA { get; set; }
        public decimal CODCOBRANZA { get; set; }
        public decimal CODMONEDA { get; set; }
        public decimal CODFORCOBRO { get; set; }
        public Nullable<System.DateTime> FECHAAPLICACION { get; set; }
        public byte TIPOAFECTADO { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> COTIZACION1REC { get; set; }
        public Nullable<decimal> COTIZACION2REC { get; set; }
        public Nullable<decimal> CODVENTA { get; set; }
        public Nullable<decimal> CODNUMCUOTA { get; set; }
        public Nullable<decimal> IMPMONCOBRO { get; set; }
        public virtual COBRANZA COBRANZA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
