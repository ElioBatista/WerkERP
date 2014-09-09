using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data;

namespace WerkUI.PreFacturacion
{
    public partial class CrearPreFactura : System.Web.UI.Page
    {
        String CodigoLiquidacion;
        int iPatientIDCount = 0; int iRowsCount = 0; decimal iAddImporte = 0; string sGroupID = "";
        DataTable dtDetalles;

        private System.Data.DataTable getTable()
        {
            DataTable oDataTable = new DataTable();
            oDataTable.Columns.Add(new DataColumn("GrupoID", typeof(string)));
            oDataTable.Columns.Add(new DataColumn("Concepto", typeof(string)));
            oDataTable.Columns.Add(new DataColumn("Importe", typeof(string)));
            oDataTable.Columns.Add(new DataColumn("Comentario", typeof(string)));

            return oDataTable;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (!IsPostBack)
                {
                    CodigoLiquidacion = Request.QueryString["cod_liquidacion"].ToString();
                    //Obtener_datos_liquidacion(Convert.ToInt32(CodigoLiquidacion));
                }
            }
            catch (Exception ex)
            {
                Obtener_datos_liquidacion(-1);
            }
        }

        private void Obtener_datos_liquidacion(int p_cod_liquidacion)
        {
            try
            {
                /*Codigo de Inicializacion Beta*/
                object[] para = { p_cod_liquidacion };
                Models.V_LIQUIDACIONES vLiq;

                if (p_cod_liquidacion > 0)
                {
                    using (Models.WerkERPContext db = new WerkUI.Models.WerkERPContext())
                    {
                        //Obtengo la Liquidacion segun el cod_liquidacion recibdo por el formulario web
                        vLiq = db.V_LIQUIDACIONES.Find(para);

                        ((TextBox)PreFacturaFormView.FindControl("new_num_facturaTB")).Attributes.Add("onblur", "javascript:verifyNroFactura(this);");

                        // Asignamos los valores a los campos del form view
                        ((TextBox)PreFacturaFormView.FindControl("new_fechaTB")).Text = DateTime.Now.ToShortDateString();
                        ((TextBox)PreFacturaFormView.FindControl("new_clienteTB")).Text = vLiq.Cliente.Trim();
                        ((TextBox)PreFacturaFormView.FindControl("new_CodClienteTB")).Text = vLiq.CODUSUARIO.ToString();
                        ((TextBox)PreFacturaFormView.FindControl("new_num_liquidacionTB")).Text = vLiq.Nro__Liquidación.ToString();
                        ((DropDownList)PreFacturaFormView.FindControl("new_monedaDDL")).SelectedIndex = 1;
                        ((TextBox)PreFacturaFormView.FindControl("new_telefonoTB")).Text = vLiq.Teléfono.Trim();
                        ((TextBox)PreFacturaFormView.FindControl("new_rucTB")).Text = vLiq.R_U_C_.Trim();
                        ((TextBox)PreFacturaFormView.FindControl("new_direccionTB")).Text = vLiq.Dirección.Trim();
                        ((TextBox)PreFacturaFormView.FindControl("new_despachanteTB")).Text = vLiq.Despachante.Trim();
                        ((TextBox)PreFacturaFormView.FindControl("new_ruc_despachanteTB")).Text = vLiq.R_U_C__Despachante.Trim();
                        ((DropDownList)PreFacturaFormView.FindControl("new_tipo_facturaDDL")).SelectedIndex = 1;
                        ((TextBox)PreFacturaFormView.FindControl("new_despacho_internoTB")).Text = vLiq.Nro__Despacho_Interno.Trim();
                        ((TextBox)PreFacturaFormView.FindControl("new_despachoTB")).Text = vLiq.Nro__Despacho.Trim();
                        ((TextBox)PreFacturaFormView.FindControl("new_totalTB")).Text = Core.Util.GetFormatedNumber(vLiq.Total);
                        ((TextBox)PreFacturaFormView.FindControl("new_iva_gastosTB")).Text = Core.Util.GetFormatedNumber(vLiq.IVA_Gastos);
                        ((TextBox)PreFacturaFormView.FindControl("new_iva_honorariosTB")).Text = Core.Util.GetFormatedNumber(vLiq.IVA_Honorarios);
                        ((TextBox)PreFacturaFormView.FindControl("new_retencion_ivaTB")).Text = Core.Util.GetFormatedNumber(vLiq.IVA_Retención);
                        ((TextBox)PreFacturaFormView.FindControl("new_retencion_iva_gastosTB")).Text = Core.Util.GetFormatedNumber(vLiq.IVA_Ret__Gastos);
                        ((TextBox)PreFacturaFormView.FindControl("new_retencion_iva_honorariosTB")).Text = Core.Util.GetFormatedNumber(vLiq.IVA_Ret__Honorarios);

                    }


                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void PreFacturaFormView_DataBound(object sender, EventArgs e)
        {
            Obtener_datos_liquidacion(Convert.ToInt32(CodigoLiquidacion));
        }


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

        protected void PreFacturaDetalleGridView_RowDataBound(object sender, GridViewRowEventArgs e)
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
                    sName = ((Label)PreFacturaDetalleGridView.Rows[e.Row.RowIndex - 1].FindControl("lblGrupo")).Text;
                    iPatientIDCount = iPatientIDCount + 1;
                    if (sGroupID == ((Label)e.Row.FindControl("lblGrupo")).Text)
                    {
                        iAddImporte += Convert.ToDecimal(((Label)e.Row.FindControl("lblImporte")).Text);
                    }
                    else
                    {
                        sGroupID = ((Label)e.Row.FindControl("lblGrupo")).Text;
                        Table tblTemp = (Table)this.PreFacturaDetalleGridView.Controls[0];
                        int intIndex = tblTemp.Rows.GetRowIndex(e.Row);
                        GridViewRow gvrSubTotal = CreateGridViewRow(intIndex, "#8FD8D8", PreFacturaDetalleGridView.Columns.Count, "Total: " + WerkUI.Core.Util.GetFormatedNumber(iAddImporte), 20);
                        tblTemp.Controls.AddAt(intIndex, gvrSubTotal);
                        iPatientIDCount = 0;
                        iAddImporte = Convert.ToDecimal(((Label)e.Row.FindControl("lblImporte")).Text);
                    }
                    if (iRowsCount == e.Row.RowIndex)
                    {
                        sName = ((Label)e.Row.FindControl("lblGrupo")).Text;
                        Table tblTemp = (Table)this.PreFacturaDetalleGridView.Controls[0];
                        int intIndex = tblTemp.Rows.GetRowIndex(e.Row) + 1;
                        GridViewRow gvrLast = CreateGridViewRow(intIndex, "#8FD8D8", PreFacturaDetalleGridView.Columns.Count, "Total: " + WerkUI.Core.Util.GetFormatedNumber(iAddImporte), 20);
                        tblTemp.Controls.AddAt(intIndex, gvrLast);
                    }
                }
            }
        }

        protected void PreFacturaDetallesDataSource_Selected(object sender, SqlDataSourceStatusEventArgs e)
        {
            iRowsCount = e.AffectedRows - 1;
        }

        protected void AgregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean existio = false;
                dtDetalles = getTable();

                decimal sumatoriaTotal = 0;

                for (int i = 0; i <= PreFacturaDetalleGridView.Rows.Count - 1; i++)
                {
                    GridViewRow row = (GridViewRow)PreFacturaDetalleGridView.Rows[i];
                    CheckBox chk = (CheckBox)row.FindControl("ConceptoCheck");
                    if (chk.Checked)
                    {

                        DataRow dr = dtDetalles.NewRow();

                        dr["GrupoID"] = ((Label)row.FindControl("lblGrupo")).Text;
                        dr["Concepto"] = ((Label)row.FindControl("lblConcepto")).Text;
                        dr["Importe"] = ((Label)row.FindControl("lblImporte")).Text;
                        dr["Comentario"] = ((Label)row.FindControl("lblComentario")).Text;

                        sumatoriaTotal += Convert.ToDecimal(dr["Importe"].ToString());

                        dtDetalles.Rows.Add(dr);

                        // Habilitamos el boton para que se pueda eliminar la operacion
                        //this.EliminarBtn.Enabled = true;

                        // confirmamos que si se selecciono una fila
                        existio = true;
                    }
                }

                if (existio)
                {
                    DataRow dr = dtDetalles.NewRow();
                    dr["Comentario"] = "Total: " + WerkUI.Core.Util.GetFormatedNumber(sumatoriaTotal.ToString());
                    dtDetalles.Rows.Add(dr);
                }

                this.PreFacturaDetalleGeneradaGridView.DataSource = dtDetalles;
                this.PreFacturaDetalleGeneradaGridView.DataBind();

                // Cargamos nuevamente la grilla
                this.PreFacturaDetalleGridView.DataBind();

            }
            catch (Exception ex)
            {

            }
        }

        protected void EliminarBtn_Click(object sender, EventArgs e)
        {
            this.PreFacturaDetalleGeneradaGridView.DataSource = null;
            this.PreFacturaDetalleGeneradaGridView.DataBind();
            //this.EliminarBtn.Enabled = false;

            // Cargamos nuevamente la grilla
            this.PreFacturaDetalleGridView.DataBind();
        }

        protected void PreFacturarLiquidacionBtn_Click(object sender, EventArgs e)
        {
            PreFacturar();
        }

        protected void PreFacturarLiquidacionAbajoBtn_Click(object sender, EventArgs e)
        {
            PreFacturar();
        }

        private void PreFacturar()
        {

            try
            {
                using (Models.WerkERPContext db = new WerkUI.Models.WerkERPContext())
                {

                    //pFormFac.cod_cliente = Convert.ToDecimal(vLiq.CODCLIENTE);
                    //pFormFac.cod_liquidacion = Convert.ToDecimal(vLiq.Cod__Liquidación);
                    //pFormFac.cod_moneda = Convert.ToInt32(((DropDownList)PreFacturaFormView.FindControl("new_monedaDDL")).SelectedValue);
                    //pFormFac.fecha = System.DateTime.Now;
                    //pFormFac.ruc = vLiq.R_U_C_.Trim();
                    //pFormFac.direccion = vLiq.Dirección;
                    //pFormFac.cod_empresa = Convert.ToInt32(vLiq.CodEmpresa);
                    //pFormFac.telefono = vLiq.Teléfono;
                    //pFormFac.cod_tipo_factura = Guid.Parse(((DropDownList)PreFacturaFormView.FindControl("new_tipo_facturaDDL")).SelectedValue.ToString());
                    //pFormFac.nro_despacho_interno = Convert.ToDecimal(vLiq.Nro__Despacho_Interno.Trim());
                    //pFormFac.nro_despacho = vLiq.Nro__Despacho;

                    Models.ProFormaFactura num_factura = new Models.ProFormaFactura { num_factura = Convert.ToDecimal(((TextBox)PreFacturaFormView.FindControl("new_num_facturaTB")).Text) };
                    Models.ProFormaFactura cod_cliente = new Models.ProFormaFactura { cod_cliente = Convert.ToDecimal(((TextBox)PreFacturaFormView.FindControl("new_CodClienteTB")).Text) };
                    Models.ProFormaFactura cod_liquidacion = new Models.ProFormaFactura { cod_liquidacion = Convert.ToDecimal(((TextBox)PreFacturaFormView.FindControl("new_num_liquidacionTB")).Text) };
                    Models.ProFormaFactura cod_moneda = new Models.ProFormaFactura { cod_moneda = Convert.ToInt32(((DropDownList)PreFacturaFormView.FindControl("new_monedaDDL")).SelectedValue) };
                    Models.ProFormaFactura fecha = new Models.ProFormaFactura { fecha = System.DateTime.Now };
                    Models.ProFormaFactura ruc = new Models.ProFormaFactura { ruc = ((TextBox)PreFacturaFormView.FindControl("new_rucTB")).Text };
                    Models.ProFormaFactura direccion = new Models.ProFormaFactura { direccion = ((TextBox)PreFacturaFormView.FindControl("new_direccionTB")).Text };
                    Models.ProFormaFactura cod_empresa = new Models.ProFormaFactura { cod_empresa = Convert.ToInt32(((TextBox)PreFacturaFormView.FindControl("new_CodEmpresaTB")).Text) };
                    Models.ProFormaFactura telefono = new Models.ProFormaFactura { telefono = ((TextBox)PreFacturaFormView.FindControl("new_telefonoTB")).Text };


                    db.ProFormaFacturas.Add(num_factura);
                    db.ProFormaFacturas.Add(cod_cliente);
                    db.ProFormaFacturas.Add(cod_liquidacion);

                    //db.SaveChanges();

                }
            }
            catch (Exception ex)
            {

            }
        }


        [WebMethod]
        public static string verifyNroFactura(string nroFactura)
        {

            using (Models.WerkERPContext db = new WerkUI.Models.WerkERPContext())
            {

                Models.Factura factura;
                Models.ProFormaFactura proFormaFactura;
                object[] busquedaFactura = { int.Parse(nroFactura) };

                factura = db.Facturas.Find(busquedaFactura);
                proFormaFactura = db.ProFormaFacturas.Find(busquedaFactura);

                if ((factura != null && factura.cod_factura > 0) || (proFormaFactura != null && proFormaFactura.cod_ProFormafactura > 0))
                {
                    return "El nro de factura: " + nroFactura + " ya ha sido utilizado anteriormente, favor indique otro número";
                }
                else
                {
                    return string.Empty;
                }

            }
        }
    }
}