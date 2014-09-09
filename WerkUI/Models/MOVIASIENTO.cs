using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class MOVIASIENTO
    {
        public MOVIASIENTO()
        {
            this.MOVIASIENTODETs = new List<MOVIASIENTODET>();
            this.MOVIASIENTOMOVIs = new List<MOVIASIENTOMOVI>();
        }

        public decimal CODASIENTO { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODSISTEMAS { get; set; }
        public Nullable<decimal> CODMODULO { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODCENTRO { get; set; }
        public decimal NUMMOVIMIENTO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CODMONEDA { get; set; }
        public Nullable<System.DateTime> FECHAASIENTO { get; set; }
        public Nullable<decimal> COTIZACION1 { get; set; }
        public Nullable<decimal> COTIZACION2 { get; set; }
        public Nullable<decimal> TIPASIE { get; set; }
        public Nullable<decimal> CODASIENTOCONTA { get; set; }
        public virtual ASIENTO ASIENTO { get; set; }
        public virtual CENTROCOSTO CENTROCOSTO { get; set; }
        public virtual MONEDA MONEDA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual SISTEMA SISTEMA { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual ICollection<MOVIASIENTODET> MOVIASIENTODETs { get; set; }
        public virtual ICollection<MOVIASIENTOMOVI> MOVIASIENTOMOVIs { get; set; }
    }
}
