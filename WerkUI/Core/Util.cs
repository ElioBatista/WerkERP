using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;

namespace WerkUI.Core
{
    public class Util
    {
        public static string GetFormatedNumber(object number)
        {
            //double value;
            string transformed;

            try
            {                
                transformed = String.Format(HttpContext.Current.Session["user.moneda_formato"].ToString(), number);
            }
            catch (Exception ex)
            {
                transformed = "0";
            }
            return transformed;
        }

        public static string GetFormatedDate(object date)
        {
            //double value;
            string transformed;

            try
            {
                transformed = String.Format(HttpContext.Current.Session["user.fecha_formato"].ToString(), date);
            }
            catch (Exception ex)
            {
                transformed = "0";
            }
            return transformed;
        }

        public static void ShowAlert(Page currentPage, string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("');");
            currentPage.ClientScript.RegisterStartupScript(typeof(Util), "showalert", sb.ToString(), true);
        } 

        public static void ShowAlert(string message)
        {
            Page currentPage = HttpContext.Current.Handler as Page;
            if (currentPage != null)
                ShowAlert(currentPage, message);
        }




        public static void OpenNewWindow(string url, Type type)
        {
            Page currentPage = HttpContext.Current.Handler as Page;

            currentPage.ClientScript.RegisterStartupScript(type, "newWindow", String.Format("<script>window.open('{0}');</script>", url));

        }

        public static string GetParameter(string modulo, string key)
        {
            object[] busquedaParametro = {  key, modulo  };

            string valor = null;

            using (Models.WerkERPContext db = new WerkUI.Models.WerkERPContext())
            {

                Models.Parametro parametro = db.Parametros.Find(busquedaParametro);

                valor =    parametro.valor.ToString();
            }

            return valor;
        }


    }
}