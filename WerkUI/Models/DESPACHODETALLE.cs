using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DESPACHODETALLE
    {
        public DESPACHODETALLE()
        {
            this.DESPACHOTEXTOes = new List<DESPACHOTEXTO>();
        }

        public decimal CODDESPACHO { get; set; }
        public decimal SECUENCIAINTERNA { get; set; }
        public string MARCA { get; set; }
        public string NUMERO { get; set; }
        public string CANTIDADBULTO { get; set; }
        public Nullable<decimal> VALMONEDAEXT { get; set; }
        public Nullable<decimal> FACTORCAMBIO { get; set; }
        public Nullable<decimal> VALORGUARANI { get; set; }
        public Nullable<decimal> VALORFOB { get; set; }
        public Nullable<decimal> VALORIMPONIBLE { get; set; }
        public Nullable<decimal> CODBULTO { get; set; }
        public virtual BULTO BULTO { get; set; }
        public virtual DESPACHO DESPACHO { get; set; }
        public virtual ICollection<DESPACHOTEXTO> DESPACHOTEXTOes { get; set; }
    }
}
