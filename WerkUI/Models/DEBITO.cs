using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DEBITO
    {
        public DEBITO()
        {
            this.COMPRASCHEQUESEMITIDOS = new List<COMPRASCHEQUESEMITIDO>();
            this.ORDENPAGOCLIENTEDETALLEs = new List<ORDENPAGOCLIENTEDETALLE>();
            this.MOVIASIENTOMOVIs = new List<MOVIASIENTOMOVI>();
            this.ORDENPAGOCHEQUEs = new List<ORDENPAGOCHEQUE>();
            this.ORDENPAGOCLIENTEDETALLEs1 = new List<ORDENPAGOCLIENTEDETALLE>();
        }

        public decimal CODDEBITO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMCUENTA { get; set; }
        public Nullable<decimal> CODTIPODEBITO { get; set; }
        public Nullable<decimal> NUMBOLETA { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public string NUMCEDULA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string AUTORIZADO { get; set; }
        public string CIAUTORIZADO { get; set; }
        public string NOMBREBENE { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<System.DateTime> FECHACONCILIACION { get; set; }
        public Nullable<decimal> CODTIPOCHEQUE { get; set; }
        public Nullable<System.DateTime> FECHAVENCIMIENTO { get; set; }
        public Nullable<byte> DEBITADO { get; set; }
        public decimal CODBANCO { get; set; }
        public Nullable<decimal> CODEMPRESA_CHEQUERA { get; set; }
        public Nullable<byte> ANULADO { get; set; }
        public virtual BANCO BANCO { get; set; }
        public virtual CHEQUERA CHEQUERA { get; set; }
        public virtual ICollection<COMPRASCHEQUESEMITIDO> COMPRASCHEQUESEMITIDOS { get; set; }
        public virtual CUENTABANCARIA CUENTABANCARIA { get; set; }
        public virtual ICollection<ORDENPAGOCLIENTEDETALLE> ORDENPAGOCLIENTEDETALLEs { get; set; }
        public virtual TIPODEBITO TIPODEBITO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual TIPOCHEQUE TIPOCHEQUE { get; set; }
        public virtual ICollection<MOVIASIENTOMOVI> MOVIASIENTOMOVIs { get; set; }
        public virtual ICollection<ORDENPAGOCHEQUE> ORDENPAGOCHEQUEs { get; set; }
        public virtual ICollection<ORDENPAGOCLIENTEDETALLE> ORDENPAGOCLIENTEDETALLEs1 { get; set; }
    }
}
