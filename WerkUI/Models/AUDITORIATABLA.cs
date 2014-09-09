using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class AUDITORIATABLA
    {
        public decimal CODIGO { get; set; }
        public decimal EMPRESA { get; set; }
        public string TABLA { get; set; }
        public string NUMCODIGO { get; set; }
        public string DESCRIPCION { get; set; }
        public System.DateTime FECHA { get; set; }
        public string USUARIO { get; set; }
        public string NIVEL { get; set; }
        public byte INSERTAR { get; set; }
        public byte MODIFICAR { get; set; }
        public byte ELIMINAR { get; set; }
        public virtual EMPRESA EMPRESA1 { get; set; }
    }
}
