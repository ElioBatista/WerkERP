using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class DESPACHO
    {
        public decimal CODDESPACHO { get; set; }
        public Nullable<decimal> CODDESPACHOINTERNO { get; set; }
        public string NUMDESPACHO { get; set; }
        public string NUMEROEXPEDIENTE { get; set; }
        public Nullable<System.DateTime> FECHADEINGRESO { get; set; }
        public string CONSIGNADOA { get; set; }
        public Nullable<decimal> NUMEROPROFORMA { get; set; }
        public Nullable<decimal> CODCLASE { get; set; }
        public Nullable<decimal> CODPROCEDENCIA { get; set; }
        public string NUMEROORDENPEDIDO { get; set; }
        public string REGISTRO { get; set; }
        public Nullable<System.DateTime> FECHAREGISTRO { get; set; }
        public string NOTADEPOSITOFISCAL { get; set; }
        public Nullable<decimal> CODADUANA { get; set; }
        public string COMPANIASEGURO { get; set; }
        public Nullable<decimal> CODORIGENMER { get; set; }
        public Nullable<System.DateTime> FECHADESPACHO { get; set; }
        public Nullable<decimal> CODDESTINO { get; set; }
        public string AGENTEDELSEGURO { get; set; }
        public Nullable<System.DateTime> FECHAPAGODESPACHO { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODTRANSPORTE { get; set; }
        public Nullable<decimal> CODDEPOSITO { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<decimal> CODORIGENMER1 { get; set; }
        public Nullable<decimal> CODORIGENMER2 { get; set; }
    }
}
