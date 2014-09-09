using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WerkUI.Core
{
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LiquidacionSearchBtn_Click(object sender, EventArgs e)
        {

            if (NumLiquidacionTexBox.Text == "" )
             {
               Core.Util.ShowAlert("Debe completar el nro. de liquidación.");
             }
             else
             {                
                Server.Transfer("~/Liquidacion/Liquidaciones.aspx?num_liquidacion=" + NumLiquidacionTexBox.Text);
             }           
        }

        protected void facturaSearchBtn_Click(object sender, EventArgs e)
        {
                Server.Transfer("~/Facturacion/Facturacion.aspx?num_factura=" + NroFacturaTextBox.Text);            
        }

        protected void OPNewRequestBtn_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/OrdenPAgo/OrdenPago.aspx"); 
        }
    }
}