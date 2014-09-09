using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ORDENCOMPRAORIGEN
    {
        public ORDENCOMPRAORIGEN()
        {
            this.ORDENCOMPRAPROVEEDORs = new List<ORDENCOMPRAPROVEEDOR>();
        }

        public decimal CODORIGEN { get; set; }
        public string NUMORIGEN { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<ORDENCOMPRAPROVEEDOR> ORDENCOMPRAPROVEEDORs { get; set; }
    }
}
