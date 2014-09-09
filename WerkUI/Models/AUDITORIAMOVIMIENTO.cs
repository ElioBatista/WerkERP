using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class AUDITORIAMOVIMIENTO
    {
        public decimal CODIGO { get; set; }
        public decimal EMPRESA { get; set; }
        public string MOVIMIENTO { get; set; }
        public string SUCURSAL { get; set; }
        public string COMPROBANTE { get; set; }
        public string NUMERO { get; set; }
        public string MONEDA { get; set; }
        public string COTIZACION1 { get; set; }
        public string COTIZACION2 { get; set; }
        public string FECHAMOVIMIENTO { get; set; }
        public string FECHAPROCESO { get; set; }
        public string OBSERVACION { get; set; }
        public string IMPORTE { get; set; }
        public string DETALLE { get; set; }
        public System.DateTime FECHA { get; set; }
        public string USUARIO { get; set; }
        public string NIVEL { get; set; }
        public byte INSERTAR { get; set; }
        public byte MODIFICAR { get; set; }
        public byte ELIMINAR { get; set; }
        public virtual EMPRESA EMPRESA1 { get; set; }
    }
}
