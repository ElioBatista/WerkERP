using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class F800
    {
        public string ORDEN800 { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public decimal CODEMPRESA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string RAZONSOCIAL { get; set; }
        public string ORIGINAL { get; set; }
        public string RECTIFICADA { get; set; }
        public string RECTIFICACION { get; set; }
        public Nullable<decimal> MES { get; set; }
        public Nullable<decimal> ANHO { get; set; }
        public Nullable<decimal> A1 { get; set; }
        public Nullable<decimal> B1 { get; set; }
        public Nullable<decimal> C1 { get; set; }
        public Nullable<decimal> D1 { get; set; }
        public Nullable<decimal> A2 { get; set; }
        public Nullable<decimal> B2 { get; set; }
        public Nullable<decimal> C2 { get; set; }
        public Nullable<decimal> D2 { get; set; }
        public Nullable<decimal> A3 { get; set; }
        public Nullable<decimal> B3 { get; set; }
        public Nullable<decimal> C3 { get; set; }
        public Nullable<decimal> D3 { get; set; }
        public Nullable<decimal> E3 { get; set; }
        public Nullable<decimal> F3 { get; set; }
        public Nullable<decimal> G3 { get; set; }
        public Nullable<decimal> BH3 { get; set; }
        public Nullable<decimal> H3 { get; set; }
        public Nullable<decimal> I3 { get; set; }
        public Nullable<decimal> J3 { get; set; }
        public Nullable<decimal> K3 { get; set; }
        public Nullable<decimal> L3 { get; set; }
        public Nullable<decimal> M3 { get; set; }
        public Nullable<decimal> I90 { get; set; }
        public Nullable<decimal> I91 { get; set; }
        public Nullable<decimal> I95 { get; set; }
        public string PEFECT { get; set; }
        public string PCJECO { get; set; }
        public string PCHEOT { get; set; }
        public string CHEQUE { get; set; }
        public Nullable<decimal> BANCO { get; set; }
        public Nullable<decimal> SUCURSAL { get; set; }
        public Nullable<decimal> ANTIC { get; set; }
        public Nullable<decimal> BDIA { get; set; }
        public Nullable<decimal> BMES { get; set; }
        public Nullable<decimal> BANHO { get; set; }
        public Nullable<decimal> CMES { get; set; }
        public Nullable<decimal> A4 { get; set; }
        public Nullable<decimal> B4 { get; set; }
        public Nullable<decimal> C4 { get; set; }
        public Nullable<decimal> D4 { get; set; }
        public Nullable<decimal> E4 { get; set; }
        public Nullable<decimal> F4 { get; set; }
        public Nullable<decimal> G4 { get; set; }
        public Nullable<decimal> BG4 { get; set; }
        public Nullable<decimal> H4 { get; set; }
        public Nullable<decimal> I4 { get; set; }
        public Nullable<decimal> J4 { get; set; }
        public Nullable<decimal> K4 { get; set; }
        public Nullable<decimal> L4 { get; set; }
        public string LUGAR { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string LETRA { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public virtual SUCURSAL SUCURSAL1 { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
