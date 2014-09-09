using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class BANCO
    {
        public BANCO()
        {
            this.CAJACHEQUESRECIBIDOS = new List<CAJACHEQUESRECIBIDO>();
            this.CHEQUERECIBIDOes = new List<CHEQUERECIBIDO>();
            this.CUENTABANCARIAs = new List<CUENTABANCARIA>();
            this.DEBITOS = new List<DEBITO>();
        }

        public decimal CODBANCO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMBANCO { get; set; }
        public string DESBANCO { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public string WEB { get; set; }
        public string EMAIL { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<CAJACHEQUESRECIBIDO> CAJACHEQUESRECIBIDOS { get; set; }
        public virtual ICollection<CHEQUERECIBIDO> CHEQUERECIBIDOes { get; set; }
        public virtual ICollection<CUENTABANCARIA> CUENTABANCARIAs { get; set; }
        public virtual ICollection<DEBITO> DEBITOS { get; set; }
    }
}
