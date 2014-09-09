using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class SISTEMA
    {
        public SISTEMA()
        {
            this.MODULOS = new List<MODULO>();
            this.MODULOS1 = new List<MODULO>();
            this.MOVIASIENTOes = new List<MOVIASIENTO>();
        }

        public decimal CODSISTEMAS { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMSISTEMAS { get; set; }
        public string DESSISTEMAS { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<MODULO> MODULOS { get; set; }
        public virtual ICollection<MODULO> MODULOS1 { get; set; }
        public virtual ICollection<MOVIASIENTO> MOVIASIENTOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
