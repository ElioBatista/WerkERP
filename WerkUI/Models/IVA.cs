using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class IVA
    {
        public IVA()
        {
            this.CONCOMPRAS = new List<CONCOMPRA>();
            this.CONVENTAS = new List<CONVENTA>();
            this.MagicIVAs = new List<MagicIVA>();
            this.MOVISUELDODETALLEs = new List<MOVISUELDODETALLE>();
            this.ORDENCOMPRAPROVEEDORDETALLEs = new List<ORDENCOMPRAPROVEEDORDETALLE>();
            this.PRODUCTOS = new List<PRODUCTO>();
            this.SALARIOs = new List<SALARIO>();
            this.SUELDOSTIPOMOVEMPLEADOes = new List<SUELDOSTIPOMOVEMPLEADO>();
        }

        public decimal CODIVA { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMIVA { get; set; }
        public string DESIVA { get; set; }
        public Nullable<decimal> PORCENTAJEIVA { get; set; }
        public Nullable<decimal> COHEFICIENTE { get; set; }
        public Nullable<byte> PRIORIDAD { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> CUENTADEBE { get; set; }
        public Nullable<decimal> CUENTAHABER { get; set; }
        public virtual ICollection<CONCOMPRA> CONCOMPRAS { get; set; }
        public virtual ICollection<CONVENTA> CONVENTAS { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<MagicIVA> MagicIVAs { get; set; }
        public virtual ICollection<MOVISUELDODETALLE> MOVISUELDODETALLEs { get; set; }
        public virtual ICollection<ORDENCOMPRAPROVEEDORDETALLE> ORDENCOMPRAPROVEEDORDETALLEs { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTOS { get; set; }
        public virtual ICollection<SALARIO> SALARIOs { get; set; }
        public virtual ICollection<SUELDOSTIPOMOVEMPLEADO> SUELDOSTIPOMOVEMPLEADOes { get; set; }
        public virtual PLANCUENTA PLANCUENTA1 { get; set; }
    }
}
