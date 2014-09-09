using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PEDIDOAJUSTE
    {
        public decimal CODPEDIDOAJUSTE { get; set; }
        public string NUMPEDIDOAJUSTE { get; set; }
        public Nullable<decimal> IMPORTEPEDIDO { get; set; }
        public Nullable<decimal> CODDESPACHOINTERNO { get; set; }
        public Nullable<decimal> CODPROPOSITO { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<System.DateTime> FECHADEPEDIDO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public virtual DESPACHOINTERNO DESPACHOINTERNO { get; set; }
        public virtual PROPOSITOCHEQUE PROPOSITOCHEQUE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
