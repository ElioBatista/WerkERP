using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CREDITO
    {
        public CREDITO()
        {
            this.COBRANZAS = new List<COBRANZA>();
            this.CREDITORECIBIDOes = new List<CREDITORECIBIDO>();
            this.MOVIASIENTOMOVIs = new List<MOVIASIENTOMOVI>();
        }

        public decimal CODCREDITO { get; set; }
        public string NUMCUENTA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODTIPOCREDITO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> NUMDEPOSITO { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string NUMCEDULA { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> EFECTIVO { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<System.DateTime> FECHACONCILIACION { get; set; }
        public Nullable<decimal> CODBANCO { get; set; }
        public string DETALLE { get; set; }
        public Nullable<System.DateTime> FECHAVENTA { get; set; }
        public virtual ICollection<COBRANZA> COBRANZAS { get; set; }
        public virtual ICollection<CREDITORECIBIDO> CREDITORECIBIDOes { get; set; }
        public virtual CUENTABANCARIA CUENTABANCARIA { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual TIPOCREDITO TIPOCREDITO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<MOVIASIENTOMOVI> MOVIASIENTOMOVIs { get; set; }
    }
}
