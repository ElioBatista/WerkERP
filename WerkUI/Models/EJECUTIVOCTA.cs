using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class EJECUTIVOCTA
    {
        public EJECUTIVOCTA()
        {
            this.CLIENTES = new List<CLIENTE>();
        }

        public decimal CODEJECUTIVOCTA { get; set; }
        public string NUMEJECUTIVO { get; set; }
        public string DESEJECUTIVO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<CLIENTE> CLIENTES { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
