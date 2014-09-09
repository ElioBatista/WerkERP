using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CUENTABANCARIA
    {
        public CUENTABANCARIA()
        {
            this.CHEQUEEMITIDOes = new List<CHEQUEEMITIDO>();
            this.CHEQUERAs = new List<CHEQUERA>();
            this.CREDITOS = new List<CREDITO>();
            this.DEBITOS = new List<DEBITO>();
            this.DESGLOSEBILLETEs = new List<DESGLOSEBILLETE>();
        }

        public string NUMCUENTA { get; set; }
        public Nullable<decimal> CODTIPOCUENTA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public decimal CODBANCO { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<System.DateTime> FECHAAPERTURA { get; set; }
        public Nullable<decimal> SALDOMINIMO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual BANCO BANCO { get; set; }
        public virtual ICollection<CHEQUEEMITIDO> CHEQUEEMITIDOes { get; set; }
        public virtual ICollection<CHEQUERA> CHEQUERAs { get; set; }
        public virtual ICollection<CREDITO> CREDITOS { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual TIPOCUENTA TIPOCUENTA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<DEBITO> DEBITOS { get; set; }
        public virtual ICollection<DESGLOSEBILLETE> DESGLOSEBILLETEs { get; set; }
    }
}
