using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class SUPERVISORVENTA
    {
        public SUPERVISORVENTA()
        {
            this.VENDEDORs = new List<VENDEDOR>();
        }

        public decimal CODSUPERVISOR { get; set; }
        public string NUMSUPERVISOR { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<decimal> CODZONA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public string TELEFONO { get; set; }
        public string CELULAR { get; set; }
        public Nullable<decimal> MAXIMO { get; set; }
        public Nullable<decimal> MINIMO { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ZONA ZONA { get; set; }
        public virtual ICollection<VENDEDOR> VENDEDORs { get; set; }
    }
}
