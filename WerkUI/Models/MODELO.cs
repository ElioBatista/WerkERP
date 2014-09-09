using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class MODELO
    {
        public MODELO()
        {
            this.CONPARAMETROes = new List<CONPARAMETRO>();
            this.PLANES = new List<PLANE>();
        }

        public decimal CODMODELO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string DESMODELO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<CONPARAMETRO> CONPARAMETROes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<PLANE> PLANES { get; set; }
    }
}
