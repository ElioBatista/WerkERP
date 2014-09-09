using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOLIQUIDACION
    {
        public TIPOLIQUIDACION()
        {
            this.EMPLEADOes = new List<EMPLEADO>();
        }

        public decimal CODLIQUIDACION { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public string NUMLIQUIDACION { get; set; }
        public string DESLIQUIDACION { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<EMPLEADO> EMPLEADOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
