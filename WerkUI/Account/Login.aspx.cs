using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WerkUI.Models;
using WerkUI.Core;
using System.Data.Entity.Validation;

namespace WerkUI.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register.aspx";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];

            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }


        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (ValidateUser(Login1.UserName, Login1.Password))
            {
                e.Authenticated = true;            
            }
            else
            {
                e.Authenticated = false;
            }
        }

        private bool ValidateUser(string UserName, string Password)
        {
            bool boolReturnValue = false;
    
            try
            {
                var db = new WerkERPContext();
                var query = db.Usuarios.Where(s => s.usuario1 == UserName && s.password == Password).SingleOrDefault();
 
                if (query == null)
                    boolReturnValue = false;
                else
                    boolReturnValue = true;

            }
            catch (Exception exp)
            {
                boolReturnValue = false;
            }

            return boolReturnValue;
        }


    }
}