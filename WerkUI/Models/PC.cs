using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PC
    {
        public PC()
        {
            this.DETPCs = new List<DETPC>();
        }

        public string IP { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public decimal CODSUCURSAL { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<DETPC> DETPCs { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
