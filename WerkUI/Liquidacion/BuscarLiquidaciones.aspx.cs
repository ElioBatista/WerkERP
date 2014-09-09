using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WerkUI.Liquidacion
{
    public partial class BuscarLiquidaciones : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LimpiarParametros();           
        }



        protected void BuscarLiquidacionBtn_Click(object sender, EventArgs e)
        {
            try
            {                
                LiquidacionesGrivView.DataBind();             
            }
            catch (Exception ex)
            {
                Core.Util.ShowAlert("Error al buscar liquidación: " + ex.Message);
            }
        }


        protected void LimpiarCamposBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarParametros();
            }
            catch (Exception ex)
            {
                Core.Util.ShowAlert("Error al limpiar parámetros: " + ex.Message);
            }
        }


        private void LimpiarParametros()
        {
            try
            {
                this.NumLiquidacionTB.Text = string.Empty;                
                this.DespachoInternoTB.Text = string.Empty;
                ClienteDDL.SelectedIndex = 0;
                DespachanteDD.SelectedIndex = 0;
                this.FechaDesdeTB.Text = string.Empty;
                this.FechaHastaTB.Text = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void FechaDesdeBTN_Click(object sender, EventArgs e)
        {
            this.FechaDesdeCal.Visible = true;
        }

        protected void FechaDesdeCal_SelectionChanged(object sender, EventArgs e)
        {
            FechaDesdeTB.Text = FechaDesdeCal.SelectedDate.ToShortDateString();
            this.FechaDesdeCal.Visible = false;
        }

        protected void FechaHastaBTN_Click(object sender, EventArgs e)
        {
            FechaHastaCal.Visible = true;
        }

        protected void FechaHastaCal_SelectionChanged(object sender, EventArgs e)
        {
            FechaHastaTB.Text = FechaHastaCal.SelectedDate.ToShortDateString();
            this.FechaHastaCal.Visible = false;
        }


    }
}