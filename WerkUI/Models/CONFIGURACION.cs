using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CONFIGURACION
    {
        public decimal CODCONFIGURACION { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CUEDIFCAMCOBRO { get; set; }
        public Nullable<decimal> CUEDIFCAMPAGO { get; set; }
        public Nullable<decimal> CANDECIMALESIMPORTE { get; set; }
        public Nullable<decimal> CANDECIMALESCANTIDAD { get; set; }
        public Nullable<decimal> MONEDA1 { get; set; }
        public Nullable<decimal> MONEDA2 { get; set; }
        public string PRODUCTO1 { get; set; }
        public string PRODUCTO2 { get; set; }
        public string PRODUCTO3 { get; set; }
        public Nullable<byte> CALCIVA { get; set; }
        public Nullable<byte> CALCDESC { get; set; }
        public Nullable<decimal> PORCENDESC { get; set; }
        public Nullable<byte> COSTOPP { get; set; }
        public Nullable<byte> COSTOUC { get; set; }
        public string COLOR1 { get; set; }
        public string COLOR2 { get; set; }
        public string COLOR3 { get; set; }
        public string COLOR4 { get; set; }
        public string COLOR5 { get; set; }
        public string COLOR6 { get; set; }
        public string COLOR7 { get; set; }
        public string COLOR8 { get; set; }
        public string COLOR9 { get; set; }
        public string COLOR10 { get; set; }
        public Nullable<decimal> TAMANO1 { get; set; }
        public Nullable<decimal> TAMANO2 { get; set; }
        public Nullable<decimal> TAMANO3 { get; set; }
        public Nullable<decimal> TAMANO4 { get; set; }
        public Nullable<decimal> TAMANO5 { get; set; }
        public Nullable<decimal> TAMANO6 { get; set; }
        public string FORMATOFECHA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<byte> CONCOMPRAS { get; set; }
        public Nullable<byte> CONVENTAS { get; set; }
        public Nullable<byte> CONCAJA { get; set; }
        public Nullable<byte> CONCOBROS { get; set; }
        public Nullable<byte> CONPAGOS { get; set; }
        public Nullable<byte> CONBANCOS { get; set; }
        public Nullable<byte> CONDEVO { get; set; }
        public Nullable<byte> CONTRANSFER { get; set; }
        public Nullable<byte> CONAJUSTE { get; set; }
        public Nullable<byte> CONTARJE { get; set; }
        public Nullable<byte> CONNDEBITO { get; set; }
        public Nullable<byte> CONNCREDITO { get; set; }
        public Nullable<byte> CONRETENPRO { get; set; }
        public Nullable<byte> CONRETENCLI { get; set; }
        public string PRODUCTO4 { get; set; }
        public string PRODUCTO5 { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual PLANCUENTA PLANCUENTA1 { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
