using System;
using System.Collections.Generic;

namespace WerkUI.Models
{
    public class CONPARAMETRO
    {
        public decimal CODCONPARAMETRO { get; set; }
        public Nullable<decimal> CUENTAIVADEBE { get; set; }
        public Nullable<decimal> CUENTAIVAHABER { get; set; }
        public Nullable<decimal> CUENTACOMPRA { get; set; }
        public Nullable<decimal> CUENTAVENTA { get; set; }
        public Nullable<decimal> CUENTARESULTADO { get; set; }
        public string FIN { get; set; }
        public string PERIODOMES { get; set; }
        public Nullable<decimal> CUENTAREVALUO { get; set; }
        public Nullable<decimal> CUENTADEPRECIACION { get; set; }
        public Nullable<decimal> CUENTADEPREACUMULADA { get; set; }
        public Nullable<decimal> CUENTATEMPORAL1 { get; set; }
        public Nullable<decimal> CUENTATEMPORAL2 { get; set; }
        public Nullable<decimal> CUENTATEMPORAL3 { get; set; }
        public Nullable<decimal> CUENTATEMPORAL4 { get; set; }
        public string FORMULARIONRO { get; set; }
        public string NROORDEN2 { get; set; }
        public Nullable<decimal> CODUSUARIO { get; set; }
        public Nullable<decimal> CODEMPRESA { get; set; }
        public Nullable<decimal> CODSUCURSAL { get; set; }
        public Nullable<decimal> CODMODELO { get; set; }
        public string NOMEMPRESA { get; set; }
        public string NOMCONTADOR { get; set; }
        public string RUCREPRESENTANTE { get; set; }
        public string RUCCONTRIBUYENTE { get; set; }
        public string RUCCONTADOR { get; set; }
        public string INICIO { get; set; }
        public Nullable<System.DateTime> FECGRA { get; set; }
        public Nullable<decimal> ULTIMOASIENTO { get; set; }
        public Nullable<byte> mes { get; set; }
        public Nullable<decimal> CUENTAVENTAEXENTA { get; set; }
        public Nullable<decimal> CUENTAVENTAGRAVADA { get; set; }
        public virtual MODELO MODELO { get; set; }
        public virtual PLANCUENTA PLANCUENTA { get; set; }
        public virtual PLANCUENTA PLANCUENTA1 { get; set; }
        public virtual PLANCUENTA PLANCUENTA2 { get; set; }
        public virtual PLANCUENTA PLANCUENTA3 { get; set; }
        public virtual PLANCUENTA PLANCUENTA4 { get; set; }
        public virtual PLANCUENTA PLANCUENTA5 { get; set; }
        public virtual PLANCUENTA PLANCUENTA6 { get; set; }
        public virtual PLANCUENTA PLANCUENTA7 { get; set; }
        public virtual PLANCUENTA PLANCUENTA8 { get; set; }
        public virtual PLANCUENTA PLANCUENTA9 { get; set; }
        public virtual PLANCUENTA PLANCUENTA10 { get; set; }
        public virtual PLANCUENTA PLANCUENTA11 { get; set; }
        public virtual PLANCUENTA PLANCUENTA12 { get; set; }
        public virtual PLANCUENTA PLANCUENTA13 { get; set; }
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
