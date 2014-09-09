using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class TIPOMOVIMIENTOSUELDO
    {
        public TIPOMOVIMIENTOSUELDO()
        {
            this.CONCEPTOTIPOMOVIMIENTOS = new List<CONCEPTOTIPOMOVIMIENTO>();
            this.MOVISUELDOes = new List<MOVISUELDO>();
            this.SUELDOSTIPOMOVEMPLEADOes = new List<SUELDOSTIPOMOVEMPLEADO>();
            this.TIPOMOVIMIENTOSUELDODETALLEs = new List<TIPOMOVIMIENTOSUELDODETALLE>();
        }

        public decimal CODTIPOMOV { get; set; }
        public Nullable<decimal> CODPLANCUENTAS { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public string NUMTIPOMOV { get; set; }
        public string DESTIPOMOV { get; set; }
        public Nullable<byte> SUMARESTA { get; set; }
        public Nullable<byte> ENRECIBO { get; set; }
        public Nullable<byte> LIBROS { get; set; }
        public Nullable<decimal> IMPORTE { get; set; }
        public Nullable<decimal> PORCENTAJE { get; set; }
        public Nullable<byte> SALARIOMINIMO { get; set; }
        public Nullable<byte> SALARIOBASICO { get; set; }
        public Nullable<byte> TOTALSALARIO { get; set; }
        public Nullable<byte> NINGUNO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual ICollection<CONCEPTOTIPOMOVIMIENTO> CONCEPTOTIPOMOVIMIENTOS { get; set; }
        public virtual ICollection<MOVISUELDO> MOVISUELDOes { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual ICollection<SUELDOSTIPOMOVEMPLEADO> SUELDOSTIPOMOVEMPLEADOes { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ICollection<TIPOMOVIMIENTOSUELDODETALLE> TIPOMOVIMIENTOSUELDODETALLEs { get; set; }
    }
}
