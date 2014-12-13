using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public partial class CLIENTE
    {
        public decimal CODCLIENTE { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODPLANCUENTA { get; set; }
        public Nullable<decimal> CODZONA { get; set; }
        public Nullable<decimal> CODCOBRADOR { get; set; }
        public Nullable<decimal> CODVENDEDOR { get; set; }
        public Nullable<decimal> CODTIPOCLIENTE { get; set; }
        public string NUMCLIENTE { get; set; }
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
        public Nullable<decimal> LIMCREDITO { get; set; }
        public Nullable<System.DateTime> FECHAINGRESO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> PORCENTAJE { get; set; }
        public string OBSERVACION { get; set; }
        public Nullable<decimal> DIASVENCIMIENTO { get; set; }
        public string CONDICIONVENTA { get; set; }
        public string DIRENVIO { get; set; }
        public Nullable<byte> CLIENTEEXENTO { get; set; }
        public string CODIGOCOMISION { get; set; }
        public string NUMEROTOL { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<System.DateTime> FECHANACIMIENTO { get; set; }
        public Nullable<decimal> CODEJECUTIVOCTA { get; set; }
        public Nullable<decimal> CODCIRCUITO { get; set; }
        public Nullable<decimal> PORRETENCIONIVA { get; set; }
        public Nullable<byte> IVAGASTOS { get; set; }
        public Nullable<byte> IVAHONORARIOS { get; set; }
    }
}
