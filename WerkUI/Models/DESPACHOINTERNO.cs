using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class DESPACHOINTERNO
    {
        public decimal CODDESPACHOINTERNO { get; set; }
        public string NUMDESPACHOINTERNO { get; set; }
        public Nullable<decimal> CODCONOCIMIENTO { get; set; }
        public Nullable<decimal> CODDESPACHANTE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODCLIENTE { get; set; }
        public string CONTENIDO { get; set; }
        public Nullable<System.DateTime> FECHAINGRESO { get; set; }
        public Nullable<decimal> CODTIPOMOVIMIENTO { get; set; }
        public string FACTURACOMERCIAL { get; set; }
        public string TIPOFACTURACOMERCIAL { get; set; }
        public Nullable<byte> TIPOCONOCIMIENTO { get; set; }
        public Nullable<byte> DIACTIVO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<decimal> CODDOCFACTCOMERCIAL { get; set; }
        public Nullable<decimal> NUMEROFACTURACOMERCIAL { get; set; }
        public string CONOCIMIENTO { get; set; }
        public Nullable<decimal> CODTIPOCONOCIMIENTO { get; set; }
    }
}
