using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class FACTURAPAGAR
    {
        public FACTURAPAGAR()
        {
            this.CAJAEGRESOS = new List<CAJAEGRESO>();
            this.FACTURAPAGOAFECTADAs = new List<FACTURAPAGOAFECTADA>();
            this.ORDENPAGOCHEQUEs = new List<ORDENPAGOCHEQUE>();
        }

        public decimal NUMEROCUOTA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public decimal CODCOMPRA { get; set; }
        public Nullable<System.DateTime> FECHAVCTO { get; set; }
        public Nullable<decimal> SALDOCUOTA { get; set; }
        public Nullable<decimal> IMPORTECUOTA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<CAJAEGRESO> CAJAEGRESOS { get; set; }
        public virtual COMPRA COMPRA { get; set; }
        public virtual ICollection<FACTURAPAGOAFECTADA> FACTURAPAGOAFECTADAs { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<ORDENPAGOCHEQUE> ORDENPAGOCHEQUEs { get; set; }
    }
}
