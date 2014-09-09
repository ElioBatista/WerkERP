using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class REPARTO
    {
        public decimal CODREPARTO { get; set; }
        public string NUMREPARTO { get; set; }
        public Nullable<decimal> CODVEHICULO { get; set; }
        public Nullable<decimal> CODCHOFER { get; set; }
        public Nullable<decimal> CODRUTA { get; set; }
        public Nullable<System.DateTime> FECHAREPARTO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual CHOFERE CHOFERE { get; set; }
        public virtual RUTA RUTA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual VEHICULO VEHICULO { get; set; }
    }
}
