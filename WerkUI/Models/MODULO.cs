using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class MODULO
    {
        public MODULO()
        {
            this.MODULOUSUARIOs = new List<MODULOUSUARIO>();
        }

        public decimal CODMODULO { get; set; }
        public Nullable<decimal> CODSISTEMAS { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string DESMODULO { get; set; }
        public Nullable<decimal> USUARIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual EMPRESA EMPRESA { get; set; }
        public virtual SISTEMA SISTEMA { get; set; }
        public virtual SISTEMA SISTEMA1 { get; set; }
        public virtual ICollection<MODULOUSUARIO> MODULOUSUARIOs { get; set; }
    }
}
