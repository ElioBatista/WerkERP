using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WerkUI.Liquidacion
{
    public partial class Liquidaciones : System.Web.UI.Page
    {
        int iPatientIDCount = 0; int iRowsCount = 0; decimal iAddImporte = 0; string sGroupID = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["num_liquidacion"] != null)
                {
                    LiquidacionesSearchTextBox.Text = Request.QueryString["num_liquidacion"].ToString();
                }

                if (Request.QueryString["cod_cliente"] != null)
                {
                    this.hiddenCodCliente.Value = Request.QueryString["cod_cliente"].ToString();
                }
            }
        }

        /*Funcion de calculo de sub totales en la tabla de detalles*/
        protected void LiquidacionesDetallesGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string sName = "";
                if (e.Row.RowIndex == 0)
                {
                    sGroupID = ((Label)e.Row.FindControl("lblGrupo")).Text;
                    iAddImporte = Convert.ToDecimal(((Label)e.Row.FindControl("lblImporte")).Text);
                }
                else
                {
                    sName = ((Label)LiquidacionesDetallesGridView.Rows[e.Row.RowIndex - 1].FindControl("lblGrupo")).Text;
                    iPatientIDCount = iPatientIDCount + 1;
                    if (sGroupID == ((Label)e.Row.FindControl("lblGrupo")).Text)
                    {
                        iAddImporte += Convert.ToDecimal(((Label)e.Row.FindControl("lblImporte")).Text);
                    }
                    else
                    {
                        sGroupID = ((Label)e.Row.FindControl("lblGrupo")).Text;
                        Table tblTemp = (Table)this.LiquidacionesDetallesGridView.Controls[0];
                        int intIndex = tblTemp.Rows.GetRowIndex(e.Row);
                        GridViewRow gvrSubTotal = CreateGridViewRow(intIndex, "#8FD8D8", LiquidacionesDetallesGridView.Columns.Count, "Total: " + WerkUI.Core.Util.GetFormatedNumber(iAddImporte), 20);
                        tblTemp.Controls.AddAt(intIndex, gvrSubTotal);
                        iPatientIDCount = 0;
                        iAddImporte = Convert.ToDecimal(((Label)e.Row.FindControl("lblImporte")).Text);
                    }
                    if (iRowsCount == e.Row.RowIndex)
                    {
                        sName = ((Label)e.Row.FindControl("lblGrupo")).Text;
                        Table tblTemp = (Table)this.LiquidacionesDetallesGridView.Controls[0];
                        int intIndex = tblTemp.Rows.GetRowIndex(e.Row) + 1;
                        GridViewRow gvrLast = CreateGridViewRow(intIndex, "#8FD8D8", LiquidacionesDetallesGridView.Columns.Count, "Total: " + WerkUI.Core.Util.GetFormatedNumber(iAddImporte), 20);
                        tblTemp.Controls.AddAt(intIndex, gvrLast);
                    }
                }
            }
        }


        /*Esta Funcion agrega las filas de sub totatales en la tabla de detalles*/
        private GridViewRow CreateGridViewRow(int iCurrentIndex, string sTableBackColor, int iTableColumnSpan, string sTableText, int iTableHeight)
        {
            GridViewRow gvrTemp = new GridViewRow(iCurrentIndex, iCurrentIndex, DataControlRowType.Separator, DataControlRowState.Normal);
            TableCell cellTemp = new TableCell();
            cellTemp.BackColor = System.Drawing.ColorTranslator.FromHtml("#8FD8D8");
            cellTemp.Font.Bold = true;
            cellTemp.ColumnSpan = iTableColumnSpan;
            cellTemp.HorizontalAlign = HorizontalAlign.Right;
            cellTemp.Text = sTableText;
            cellTemp.Height = Unit.Pixel(iTableHeight);
            gvrTemp.Cells.Add(cellTemp);
            return gvrTemp;
        }

        
        protected void LiquidacionesDetallesSqlDataSource_Selected(object sender, SqlDataSourceStatusEventArgs e)
        {
            iRowsCount = e.AffectedRows - 1;
        }

        protected void FacturarLiquidacionBtn_Click(object sender, EventArgs e)
        {           
            Response.Redirect("../Facturacion/CrearFactura.aspx?cod_liquidacion=" + dvwLiquidaciones.SelectedValue.ToString());
        }

        
        protected void LiquidacionSearchButton_Click(object sender, EventArgs e)
        {
            LiquidacionesDetallesGridView.DataBind();
        }




    }
}