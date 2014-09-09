using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PROPOSITOCHEQUE
    {
        public PROPOSITOCHEQUE()
        {
            this.ORDENPAGOCLIENTEDETALLEs = new List<ORDENPAGOCLIENTEDETALLE>();
            this.PEDIDOAJUSTEs = new List<PEDIDOAJUSTE>();
        }

        public decimal CODPROPOSITO { get; set; }
        public Nullable<decimal> CODCONLIQUIDACION { get; set; }
        public Nullable<decimal> CODRUBRO1 { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMPROPOSITO { get; set; }
        public string DESPROPOSITO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<byte> ESTADO { get; set; }
        public virtual CONCEPTOSLIQUIDACION CONCEPTOSLIQUIDACION { get; set; }
        public virtual ICollection<ORDENPAGOCLIENTEDETALLE> ORDENPAGOCLIENTEDETALLEs { get; set; }
        public virtual ICollection<PEDIDOAJUSTE> PEDIDOAJUSTEs { get; set; }
        public virtual RUBRO1 RUBRO1 { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
