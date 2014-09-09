using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CARGOCONTACTO
    {
        public CARGOCONTACTO()
        {
            this.NOMBRECONTACTO2 = new List<NOMBRECONTACTO2>();
            this.NOMBRECONTACTOes = new List<NOMBRECONTACTO>();
        }

        public decimal CODCARGO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMCARGO { get; set; }
        public string DESCARGO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<NOMBRECONTACTO2> NOMBRECONTACTO2 { get; set; }
        public virtual ICollection<NOMBRECONTACTO> NOMBRECONTACTOes { get; set; }
    }
}
