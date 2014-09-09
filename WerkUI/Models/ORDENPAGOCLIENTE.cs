using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class ORDENPAGOCLIENTE
    {
        public ORDENPAGOCLIENTE()
        {
            this.ORDENPAGOCLIENTEDETALLEs = new List<ORDENPAGOCLIENTEDETALLE>();
        }

        public decimal CODORDENPAGOCLIENTE { get; set; }
        public Nullable<decimal> CODCOMPROBANTE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMEROCOMPROBANTE { get; set; }
        public Nullable<System.DateTime> FECHAMOVIMIENTO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIOACEPTA { get; set; }
        public Nullable<decimal> CODUSUARIODIF { get; set; }
        public virtual ICollection<ORDENPAGOCLIENTEDETALLE> ORDENPAGOCLIENTEDETALLEs { get; set; }
        public virtual TIPOCOMPROBANTE TIPOCOMPROBANTE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual USUARIO USUARIO1 { get; set; }
        public virtual USUARIO USUARIO2 { get; set; }
    }
}
