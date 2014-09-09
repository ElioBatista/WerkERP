using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class COBRADOR
    {
        public COBRADOR()
        {
            this.CAJAs = new List<CAJA>();
            this.CAJACIERREs = new List<CAJACIERRE>();
            this.CLIENTES = new List<CLIENTE>();
            this.COBRANZAS = new List<COBRANZA>();
            this.COBROSANULADOS = new List<COBROSANULADO>();
            this.DETCAJAs = new List<DETCAJA>();
            this.DOCUMENTOSENTREGADOS = new List<DOCUMENTOSENTREGADO>();
            this.DOCUMENTOSDEVUELTOS = new List<DOCUMENTOSDEVUELTO>();
            this.VENDEDORs = new List<VENDEDOR>();
            this.EMPLEADOes = new List<EMPLEADO>();
        }

        public decimal CODCOBRADOR { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public string NUMCOBRADOR { get; set; }
        public Nullable<decimal> USUARIO { get; set; }
        public string DESCOBRADOR { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<CAJA> CAJAs { get; set; }
        public virtual ICollection<CAJACIERRE> CAJACIERREs { get; set; }
        public virtual ICollection<CLIENTE> CLIENTES { get; set; }
        public virtual USUARIO USUARIO1 { get; set; }
        public virtual ICollection<COBRANZA> COBRANZAS { get; set; }
        public virtual ICollection<COBROSANULADO> COBROSANULADOS { get; set; }
        public virtual ICollection<DETCAJA> DETCAJAs { get; set; }
        public virtual ICollection<DOCUMENTOSENTREGADO> DOCUMENTOSENTREGADOS { get; set; }
        public virtual ICollection<DOCUMENTOSDEVUELTO> DOCUMENTOSDEVUELTOS { get; set; }
        public virtual ICollection<VENDEDOR> VENDEDORs { get; set; }
        public virtual ICollection<EMPLEADO> EMPLEADOes { get; set; }
    }
}
