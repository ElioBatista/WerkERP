using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOASIENTO
    {
        public TIPOASIENTO()
        {
            this.DEBEHABERs = new List<DEBEHABER>();
        }

        public decimal CODTIPOASIENTO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public string DESTIPOASIENTO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<DEBEHABER> DEBEHABERs { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
