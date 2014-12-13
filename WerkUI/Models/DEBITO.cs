using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class DEBITO
    {
        public decimal CODDEBITO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMCUENTA { get; set; }
        public Nullable<decimal> CODTIPODEBITO { get; set; }
        public Nullable<decimal> NUMBOLETA { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public string NUMCEDULA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string AUTORIZADO { get; set; }
        public string CIAUTORIZADO { get; set; }
        public string NOMBREBENE { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<System.DateTime> FECHACONCILIACION { get; set; }
        public Nullable<decimal> CODTIPOCHEQUE { get; set; }
        public Nullable<System.DateTime> FECHAVENCIMIENTO { get; set; }
        public Nullable<byte> DEBITADO { get; set; }
        public decimal CODBANCO { get; set; }
        public Nullable<decimal> CODEMPRESA_CHEQUERA { get; set; }
        public Nullable<byte> ANULADO { get; set; }
    }
}
