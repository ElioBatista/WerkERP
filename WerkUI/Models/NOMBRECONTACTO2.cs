using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class NOMBRECONTACTO2
    {
        public decimal CODNOMBRECONTACTO2 { get; set; }
        public Nullable<decimal> CODCARGO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODCLIENTE { get; set; }
        public string NUMCONTACTO { get; set; }
        public string DESNOMBRECONTACTO2 { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual CARGOCONTACTO CARGOCONTACTO { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
