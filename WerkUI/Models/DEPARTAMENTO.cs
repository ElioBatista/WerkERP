using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DEPARTAMENTO
    {
        public DEPARTAMENTO()
        {
            this.CIUDADs = new List<CIUDAD>();
        }

        public decimal CODDEPARTAMENTO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODPAIS { get; set; }
        public string NUMDEPARTAMENTO { get; set; }
        public string DESDEPARTAMENTO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<CIUDAD> CIUDADs { get; set; }
        public virtual PAI PAI { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
