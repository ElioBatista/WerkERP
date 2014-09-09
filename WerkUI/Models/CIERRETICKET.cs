using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CIERRETICKET
    {
        public decimal CODIGO { get; set; }
        public System.DateTime FECHAPROCESO { get; set; }
        public System.DateTime HORA { get; set; }
        public string PRIMERNUMERO { get; set; }
        public string ULTIMONUMERO { get; set; }
        public decimal CANTIDAD { get; set; }
        public decimal TOTALGRAVADA { get; set; }
        public decimal TOTALEXENTA { get; set; }
        public decimal TOTALIVA { get; set; }
        public decimal TOTALGENERAL { get; set; }
        public decimal NROZETA { get; set; }
        public decimal CODSUCURSAL { get; set; }
        public decimal CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public byte IMPRESO { get; set; }
        public string NROTICKET { get; set; }
        public Nullable<decimal> NUMCAJA { get; set; }
        public virtual CAJA CAJA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
