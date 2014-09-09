using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WerkUI.Facturacion
{
    public partial class Facturacion : System.Web.UI.Page
    {
        string NroFactura;

        protected void Page_Load(object sender, EventArgs e)
        {
            Parameter param;

            try
            {
                NroFactura = Request.QueryString["num_factura"].ToString();
                if (NroFactura == string.Empty)
                    NroFactura = "-1";
            }
            catch (Exception ex)
            {
                NroFactura = "-1";
            }

            try
            {
                param = new Parameter("p_nro_factura", System.Data.DbType.String, NroFactura);
                FacturacionDataSource.SelectParameters.Clear();
                FacturacionDataSource.SelectParameters.Add(param);
                FacturasGridView.DataBind();
            }
            catch (Exception ex1)
            {
                Core.Util.ShowAlert("El parámetro de busqueda no es válido.");
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Convert the row index stored in the CommandArgument
            // property to an Integer.
            int index;

            try
            {
                index = Convert.ToInt32(e.CommandArgument);


                // cell in the GridView control.
                GridViewRow selectedRow = FacturasGridView.Rows[index];
                TableCell CellNroFactura = selectedRow.Cells[1];
                TableCell CodFactura = selectedRow.Cells[0];

                if (e.CommandName == "Imprimir")
                {
                    Core.Util.OpenNewWindow(Core.Util.GetParameter("Facturacion", "FacturaCecilia") + "&p_cod_factura=" + CodFactura.Text, this.GetType());
                }
            }
            catch (Exception ex)
            { }

           
        }

        protected void FacturaSearchButton_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("Facturacion.aspx?num_factura=" + FacturaSearchTextBox.Text );
        }

       
    }
}