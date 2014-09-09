using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DEPOSITOCUPON
    {
        public decimal CODCUPON { get; set; }
        public decimal CODSUCURSAL { get; set; }
        public decimal CODEMPRESA { get; set; }
        public decimal CODEMISORA { get; set; }
        public decimal CODDEPOSITO { get; set; }
        public virtual CUPONE CUPONE { get; set; }
        public virtual DEPOSITADO DEPOSITADO { get; set; }
    }
}
