using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class OTMANOOBRA
    {
        public decimal CODOT { get; set; }
        public decimal CODDETALLE { get; set; }
        public Nullable<decimal> CODTECNICO { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<System.DateTime> FECHAMOV { get; set; }
        public Nullable<decimal> HORASTRAB { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public virtual OTCABECERA OTCABECERA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
