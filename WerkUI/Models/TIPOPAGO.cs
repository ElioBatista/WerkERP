using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOPAGO
    {
        public TIPOPAGO()
        {
            this.COMPRASFORMAPAGOes = new List<COMPRASFORMAPAGO>();
            this.ORDENPAGOCLIENTEDETALLEs = new List<ORDENPAGOCLIENTEDETALLE>();
            this.PAGANZAS = new List<PAGANZA>();
        }

        public decimal CODTIPOPAGO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public string NUMTIPOPAGO { get; set; }
        public string DESTIPOPAGO { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<COMPRASFORMAPAGO> COMPRASFORMAPAGOes { get; set; }
        public virtual ICollection<ORDENPAGOCLIENTEDETALLE> ORDENPAGOCLIENTEDETALLEs { get; set; }
        public virtual ICollection<PAGANZA> PAGANZAS { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
