using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class VENDEDOR
    {
        public decimal CODVENDEDOR { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMVENDEDOR { get; set; }
        public Nullable<decimal> USUARIO { get; set; }
        public string DESVENDEDOR { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public string CELULAR { get; set; }
        public Nullable<decimal> CODTIPOVENDEDOR { get; set; }
        public Nullable<decimal> CODSUCURSALPERTENECE { get; set; }
        public Nullable<decimal> CODSUCURSALPRODUCTO { get; set; }
        public Nullable<decimal> CODSUPERVISOR { get; set; }
        public string CEDULA { get; set; }
        public Nullable<decimal> CODCOBRADOR { get; set; }
        public Nullable<decimal> MAXIMO { get; set; }
        public Nullable<decimal> MINIMO { get; set; }
    }
}
