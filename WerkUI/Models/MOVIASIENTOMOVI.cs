using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class MOVIASIENTOMOVI
    {
        public decimal CODMOVIMIENTO { get; set; }
        public Nullable<decimal> CODCOMPRA { get; set; }
        public Nullable<decimal> CODVENTA { get; set; }
        public Nullable<decimal> CODCOBRANZA { get; set; }
        public Nullable<decimal> CODMONEDACOB { get; set; }
        public Nullable<decimal> CODFORCOBRO { get; set; }
        public Nullable<decimal> CODPAGANZAS { get; set; }
        public Nullable<decimal> CODMONEDAPAG { get; set; }
        public Nullable<decimal> CODTIPOPAGO { get; set; }
        public Nullable<decimal> CODDEBITO { get; set; }
        public Nullable<decimal> CODCREDITO { get; set; }
        public Nullable<decimal> CODDEVOLUCION { get; set; }
        public Nullable<decimal> CODTRANSFERENCIA { get; set; }
        public Nullable<decimal> CODAJUSTE { get; set; }
        public Nullable<decimal> CODASIENTO { get; set; }
        public Nullable<decimal> NROORDEN { get; set; }
        public Nullable<decimal> CODEMPRESAORD { get; set; }
        public virtual AJUSTE AJUSTE { get; set; }
        public virtual COBRANZA COBRANZA { get; set; }
        public virtual COMPRA COMPRA { get; set; }
        public virtual CREDITO CREDITO { get; set; }
        public virtual DEBITO DEBITO { get; set; }
        public virtual MOVIASIENTO MOVIASIENTO { get; set; }
        public virtual PAGANZA PAGANZA { get; set; }
        public virtual TRANFERENCIA TRANFERENCIA { get; set; }
        public virtual VENTA VENTA { get; set; }
    }
}
