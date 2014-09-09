using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DESPACHOTEXTO
    {
        public decimal CODDESPACHO { get; set; }
        public decimal LINEADETALLE { get; set; }
        public decimal SECUENCIAINTERNA { get; set; }
        public string DESCRIPCION { get; set; }
        public virtual DESPACHODETALLE DESPACHODETALLE { get; set; }
    }
}
