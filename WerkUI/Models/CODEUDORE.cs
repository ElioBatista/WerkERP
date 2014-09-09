using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CODEUDORE
    {
        public CODEUDORE()
        {
            this.PAGAREs = new List<PAGARE>();
        }

        public string CEDULA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public Nullable<decimal> CODCIVIL { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string DIRECCION { get; set; }
        public Nullable<System.DateTime> FECHANACIMIENTO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ESTADOCIVIL ESTADOCIVIL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<PAGARE> PAGAREs { get; set; }
    }
}
