using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TRANSFERENCIASDETALLERANGO
    {
        public decimal CODRANGO { get; set; }
        public Nullable<decimal> CODTRANSFERENCIA { get; set; }
        public Nullable<decimal> CODPRODUCTO { get; set; }
        public string RANGO1 { get; set; }
        public string RANGO2 { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public virtual TRANSFERENCIASDETALLE TRANSFERENCIASDETALLE { get; set; }
    }
}
