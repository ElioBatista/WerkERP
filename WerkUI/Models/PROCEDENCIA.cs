using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PROCEDENCIA
    {
        public PROCEDENCIA()
        {
            this.DESPACHOes = new List<DESPACHO>();
            this.DESPACHOes1 = new List<DESPACHO>();
            this.DESPACHOes2 = new List<DESPACHO>();
            this.DESPACHOes3 = new List<DESPACHO>();
            this.DESPACHOes4 = new List<DESPACHO>();
        }

        public decimal CODPROCEDENCIA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMPROCEDENCIA { get; set; }
        public string DESPROCEDENCIA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<DESPACHO> DESPACHOes { get; set; }
        public virtual ICollection<DESPACHO> DESPACHOes1 { get; set; }
        public virtual ICollection<DESPACHO> DESPACHOes2 { get; set; }
        public virtual ICollection<DESPACHO> DESPACHOes3 { get; set; }
        public virtual ICollection<DESPACHO> DESPACHOes4 { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
