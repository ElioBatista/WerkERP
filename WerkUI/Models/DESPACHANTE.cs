using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DESPACHANTE
    {
        public decimal CODDESPACHANTE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMDESPACHANTE { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string RUC { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
    }
}
