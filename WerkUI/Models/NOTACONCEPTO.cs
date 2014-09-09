using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class NOTACONCEPTO
    {
        public NOTACONCEPTO()
        {
            this.DETNCREDITOes = new List<DETNCREDITO>();
            this.DETNDEBITOes = new List<DETNDEBITO>();
            this.DETNOTACONCEPTOes = new List<DETNOTACONCEPTO>();
        }

        public decimal CODNOTACONCEPTO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMNOTACONCEPTO { get; set; }
        public string DESNOTACONCEPTO { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public Nullable<byte> DEBITO { get; set; }
        public Nullable<byte> CREDITO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<DETNCREDITO> DETNCREDITOes { get; set; }
        public virtual ICollection<DETNDEBITO> DETNDEBITOes { get; set; }
        public virtual ICollection<DETNOTACONCEPTO> DETNOTACONCEPTOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
