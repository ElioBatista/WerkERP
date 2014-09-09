using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class PROVEEDOR
    {
        public PROVEEDOR()
        {
            this.ACTIVOFIJOes = new List<ACTIVOFIJO>();
            this.COMPRAS = new List<COMPRA>();
            this.COMPRASRECEPCIONs = new List<COMPRASRECEPCION>();
            this.CONCOMPRAS = new List<CONCOMPRA>();
            this.NOMBRECONTACTOes = new List<NOMBRECONTACTO>();
            this.ORDENCOMPRAs = new List<ORDENCOMPRA>();
            this.ORDENCOMPRAPROVEEDORs = new List<ORDENCOMPRAPROVEEDOR>();
            this.ORDENPAGOes = new List<ORDENPAGO>();
            this.ORDENPRODUCCIONCABECERAs = new List<ORDENPRODUCCIONCABECERA>();
            this.PAGANZAS = new List<PAGANZA>();
            this.PAGONOTACREDITOes = new List<PAGONOTACREDITO>();
            this.PAGORETENCIONs = new List<PAGORETENCION>();
            this.PAGORETENCIONs1 = new List<PAGORETENCION>();
            this.PRODUCCIONINGRESOPRODUCTOes = new List<PRODUCCIONINGRESOPRODUCTO>();
            this.PRODUCTOS = new List<PRODUCTO>();
        }

        public decimal CODPROVEEDOR { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODZONA { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public string NUMPROVEEDOR { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string NUMCEDULA { get; set; }
        public string RUC { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public string CELULAR { get; set; }
        public string FAX { get; set; }
        public string EMAIL { get; set; }
        public string WEB { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public string observacion { get; set; }
        public virtual ICollection<ACTIVOFIJO> ACTIVOFIJOes { get; set; }
        public virtual ICollection<COMPRA> COMPRAS { get; set; }
        public virtual ICollection<COMPRASRECEPCION> COMPRASRECEPCIONs { get; set; }
        public virtual ICollection<CONCOMPRA> CONCOMPRAS { get; set; }
        public virtual ICollection<NOMBRECONTACTO> NOMBRECONTACTOes { get; set; }
        public virtual ICollection<ORDENCOMPRA> ORDENCOMPRAs { get; set; }
        public virtual ICollection<ORDENCOMPRAPROVEEDOR> ORDENCOMPRAPROVEEDORs { get; set; }
        public virtual ICollection<ORDENPAGO> ORDENPAGOes { get; set; }
        public virtual ICollection<ORDENPRODUCCIONCABECERA> ORDENPRODUCCIONCABECERAs { get; set; }
        public virtual ICollection<PAGANZA> PAGANZAS { get; set; }
        public virtual ICollection<PAGONOTACREDITO> PAGONOTACREDITOes { get; set; }
        public virtual ICollection<PAGORETENCION> PAGORETENCIONs { get; set; }
        public virtual ICollection<PAGORETENCION> PAGORETENCIONs1 { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual ICollection<PRODUCCIONINGRESOPRODUCTO> PRODUCCIONINGRESOPRODUCTOes { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTOS { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        public virtual ZONA ZONA { get; set; }
    }
}
