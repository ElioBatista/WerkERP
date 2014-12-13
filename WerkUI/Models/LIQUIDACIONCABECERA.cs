using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class LIQUIDACIONCABECERA
    {
        public decimal CODLIQUIDACION { get; set; }
        public Nullable<decimal> CODDESPACHO { get; set; }
        public Nullable<decimal> CODDESPACHOINTERNO { get; set; }
        public Nullable<decimal> NUMLIQUIDACION { get; set; }
        public Nullable<System.DateTime> FECHALIQUIDACION { get; set; }
        public Nullable<decimal> IMPORTETOTAL { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public Nullable<System.DateTime> FECHACIERRE { get; set; }
        public Nullable<decimal> IMPORTEIVAGASTOS { get; set; }
        public Nullable<decimal> IMPORTEIVAHONORARIOS { get; set; }
        public Nullable<decimal> PORRETENCIONIVA { get; set; }
        public Nullable<decimal> RETIVAGASTOS { get; set; }
        public Nullable<decimal> RETIVAHONORARIOS { get; set; }
    }
}
