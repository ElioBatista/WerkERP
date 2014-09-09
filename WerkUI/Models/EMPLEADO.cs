using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class EMPLEADO
    {
        public EMPLEADO()
        {
            this.DOCUMENTOS = new List<DOCUMENTO>();
            this.SUELDOSTIPOMOVEMPLEADOes = new List<SUELDOSTIPOMOVEMPLEADO>();
            this.SALARIOs = new List<SALARIO>();
            this.SALARIOADICIONALs = new List<SALARIOADICIONAL>();
            this.HIJOS = new List<HIJO>();
            this.HORARIOs = new List<HORARIO>();
            this.LEGAJOes = new List<LEGAJO>();
            this.MOVISUELDODETALLEs = new List<MOVISUELDODETALLE>();
        }

        public decimal CODEMPLEADO { get; set; }
        public Nullable<decimal> CODCOBRADOR { get; set; }
        public Nullable<decimal> CODLIQUIDACION { get; set; }
        public Nullable<decimal> CODCLIENTE { get; set; }
        public Nullable<decimal> CODVENDEDOR { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODDEPARTAMENTO { get; set; }
        public Nullable<decimal> CODPROFESION { get; set; }
        public Nullable<decimal> CODTIPOSALARIO { get; set; }
        public Nullable<decimal> CODCATEGORIA { get; set; }
        public Nullable<decimal> CODDIVISION { get; set; }
        public Nullable<decimal> CODCARGO { get; set; }
        public Nullable<decimal> CODSEXO { get; set; }
        public Nullable<decimal> CODNACIONALIDAD { get; set; }
        public Nullable<decimal> CODNIVEL { get; set; }
        public Nullable<decimal> CODCIVIL { get; set; }
        public string NUMEMPLEADO { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string DIRECCION { get; set; }
        public string DOCUMENTOIDENTIDAD { get; set; }
        public Nullable<System.DateTime> FECHANACIMIENTO { get; set; }
        public Nullable<decimal> CANTIDADHIJOS { get; set; }
        public Nullable<System.DateTime> FECHAINGRESO { get; set; }
        public Nullable<System.DateTime> FECHAINGRESOIPS { get; set; }
        public string NUMEROIPS { get; set; }
        public Nullable<System.DateTime> FECHASALIDA { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<byte> BONIFICACION { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public string TELEFONO { get; set; }
        public string CELULAR { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public byte[] FOTO { get; set; }
        public virtual CARGO CARGO { get; set; }
        public virtual CATEGORIA CATEGORIA { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual COBRADOR COBRADOR { get; set; }
        public virtual DEPARTAMENTOEMPRESA DEPARTAMENTOEMPRESA { get; set; }
        public virtual DIVISIONEMPRESA DIVISIONEMPRESA { get; set; }
        public virtual ICollection<DOCUMENTO> DOCUMENTOS { get; set; }
        public virtual ICollection<SUELDOSTIPOMOVEMPLEADO> SUELDOSTIPOMOVEMPLEADOes { get; set; }
        public virtual TIPOSALARIO TIPOSALARIO { get; set; }
        public virtual PROFESION PROFESION { get; set; }
        public virtual ICollection<SALARIO> SALARIOs { get; set; }
        public virtual ICollection<SALARIOADICIONAL> SALARIOADICIONALs { get; set; }
        public virtual ICollection<HIJO> HIJOS { get; set; }
        public virtual ICollection<HORARIO> HORARIOs { get; set; }
        public virtual ICollection<LEGAJO> LEGAJOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ESTADOCIVIL ESTADOCIVIL { get; set; }
        public virtual NIVELESTUDIO NIVELESTUDIO { get; set; }
        public virtual VENDEDOR VENDEDOR { get; set; }
        public virtual TIPOLIQUIDACION TIPOLIQUIDACION { get; set; }
        public virtual NACIONALIDAD NACIONALIDAD { get; set; }
        public virtual ICollection<MOVISUELDODETALLE> MOVISUELDODETALLEs { get; set; }
        public virtual SEXO SEXO { get; set; }
    }
}
