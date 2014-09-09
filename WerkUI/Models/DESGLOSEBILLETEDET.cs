using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DESGLOSEBILLETEDET
    {
        public decimal CODDESGLOSE { get; set; }
        public decimal CODBILLETE { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual BILLETE BILLETE { get; set; }
        public virtual DESGLOSEBILLETE DESGLOSEBILLETE { get; set; }
    }
}
