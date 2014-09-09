using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WerkUI.Liquidacion
{
    public partial class BuscarClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BuscarClienteButton_Click(object sender, EventArgs e)
        {
            ClientesGridView.DataBind();
        }

        protected void SeleccionarClienteButton_Click(object sender, EventArgs e)
        {
            Type cstype = this.GetType();

            try
            {
                using (Models.WerkERPContext db = new WerkUI.Models.WerkERPContext())
                {
                    try
                    {
                        object[] para = { "cliente" };

                        Models.ParametrosBusqueda parametro = db.ParametrosBusquedas.Find(para);

                        db.ParametrosBusquedas.Remove(parametro);

                    }
                    catch (Exception ax)
                    {
                      
                    }

                    Models.ParametrosBusqueda param_cliente = new Models.ParametrosBusqueda { parametro = "cliente", valor = ClienteTB.Text };

                    db.ParametrosBusquedas.Add(param_cliente);

                    db.SaveChanges();

                    ClientScript.RegisterStartupScript(cstype, "NewWinScript", "Seleccionar();", true);
                }
            }
            catch(Exception ex)
            {
                Core.Util.ShowAlert("Error al buscar cliente: " + ex.Message);
            }
        }

        protected void ClientesGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClienteTB.Text = ClientesGridView.SelectedRow.Cells[2].Text;
        }
    }
}