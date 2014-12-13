using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WerkUI.Models;
using WerkUI.Core;
using System.Data.Entity.Validation;

namespace WerkUI.OrdenPago
{
    public partial class OPDetails : System.Web.UI.Page
    {

        int requestID;
        int iPatientIDCount = 0; int iRowsCount = 0; decimal iAddImporte = 0; string sGroupID = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            requestID = Convert.ToInt32(Request.QueryString["RequestID"]);
            lblSiteTitle.Text = "Detalles de Solicitud de OP - Nro. " + Request.QueryString["RequestNumber"];
        }


        public String GetConceptByNumber(String conceptNumber)
        {
            try
            {

                var db = new WerkERPContext();
                var query = db.ConceptosLiquidacions.Where(s => s.nro_concepto == conceptNumber).SingleOrDefault();
                return query.descripcion;
            }
            catch (Exception exp)
            {
                ErrorLabel.Text = exp.Message;
                ErrorLabel.Visible = true;
                return null;
            }
        }
        public IQueryable<WerkUI.Models.SolicitudOrdenPagoDetalle> GetRequestOPDetails()
        {
            try
            {

                var db = new WerkERPContext();
                var query = db.SolicitudOrdenPagoDetalles.Where(s => s.id_solicitud_orden_pago == requestID && s.id_cheque == null);
                return query;
            }
            catch (Exception exp)
            {
                ErrorLabel.Text = exp.Message;
                ErrorLabel.Visible = true;
                return null;
            }
        }

        public void UpdateRequestOPDetail(WerkUI.Models.SolicitudOrdenPagoDetalle subject)
        {
            try
            {
                var db = new WerkERPContext();
                var solicitudOPDetalles = db.SolicitudOrdenPagoDetalles.Where(s => s.id_solicitud_orden_pago_detalle == subject.id_solicitud_orden_pago_detalle).SingleOrDefault();
                solicitudOPDetalles.importe = subject.importe;
                solicitudOPDetalles.importe_aprobado = subject.importe_aprobado;
                solicitudOPDetalles.nro_concepto = subject.nro_concepto;
                solicitudOPDetalles.observacion = subject.observacion;
                solicitudOPDetalles.nro_despacho_interno = subject.nro_despacho_interno;

                db.SaveChanges();
                ErrorLabel.Text = String.Empty;
            }
            catch (DbEntityValidationException ex)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = ex.Message;
            }
            catch (Exception exp)
            {
                ErrorLabel.Text = exp.Message;
                ErrorLabel.Visible = true;
            }
        }

        public void DeleteRequestOPDetail(WerkUI.Models.SolicitudOrdenPagoDetalle subject)
        {
            try
            {
                var db = new WerkERPContext();
                var solicitudOPDetalles = db.SolicitudOrdenPagoDetalles.Where(s => s.id_solicitud_orden_pago_detalle == subject.id_solicitud_orden_pago_detalle).SingleOrDefault();
                db.SolicitudOrdenPagoDetalles.Remove(solicitudOPDetalles);
                db.SaveChanges();
                ErrorLabel.Text = String.Empty;
            }
            catch (DbEntityValidationException ex)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = ex.Message;
            }
            catch (Exception exp)
            {
                ErrorLabel.Text = exp.Message;
                ErrorLabel.Visible = true;
            }
        }

        protected void RequestOPDetailsListView_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            RequestOPDetailsListView.EditIndex = e.NewEditIndex;
        }

        protected void RequestOPDetailsListView_ItemCanceling(object sender, ListViewCancelEventArgs e)
        {
            RequestOPDetailsListView.EditIndex = -1;
        }

        public Boolean VerifyDespachoInterno(String nroDespachoInterno)
        {
            try
            {
                var db = new WerkERPContext();
                var query = db.DESPACHOINTERNOes.Where(s => s.NUMDESPACHOINTERNO == nroDespachoInterno).SingleOrDefault();
                if (query.CODDESPACHOINTERNO.ToString() != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            { return false; }
        }

        public Boolean VerifyConcpetoLiquidacion(String nroConceptoLiquidacion)
        {
            try
            {
                var db = new WerkERPContext();
                var query = db.ConceptosLiquidacions.Where(s => s.nro_concepto == nroConceptoLiquidacion).SingleOrDefault();
                if (query.cod_concepto_liquidacion.ToString() != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            { return false; }
        }



        public void InsertRequestOPDetail()
        {
            var db = new WerkERPContext();
            var solicitudOPDetalles = new WerkUI.Models.SolicitudOrdenPagoDetalle();

            TryUpdateModel(solicitudOPDetalles);
            if (ModelState.IsValid)
            {
                try
                {
                    solicitudOPDetalles.cod_moneda = 1;
                    solicitudOPDetalles.id_solicitud_orden_pago = requestID;

                    if (!VerifyDespachoInterno(solicitudOPDetalles.nro_despacho_interno.ToString()))
                    {
                        ErrorLabel.Visible = true;
                        ErrorLabel.Text = "El número de Despacho Interno no es válido.";
                    }
                    else if (!VerifyConcpetoLiquidacion(solicitudOPDetalles.nro_concepto))
                    {
                        ErrorLabel.Visible = true;
                        ErrorLabel.Text = "El numero de Concepto de Liquidación no es válido.";
                    }
                    else
                    {
                        db.SolicitudOrdenPagoDetalles.Add(solicitudOPDetalles);
                        db.SaveChanges();
                        ErrorLabel.Text = String.Empty;
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = ex.Message;
                }
                catch (Exception exp)
                {
                    ErrorLabel.Text = exp.Message;
                    ErrorLabel.Visible = true;
                }
            }
        }

        public IQueryable<WerkUI.Models.Banco> GetBanks()
        {
            try
            {

                var db = new WerkERPContext();
                var query = db.Bancos;
                return query;
            }
            catch (Exception exp)
            {
                ErrorLabel.Text = exp.Message;
                ErrorLabel.Visible = true;
                return null;
            }
        }

        public IQueryable<WerkUI.Models.Chequera> GetChequeras()
        {
            try
            {
                
                var db = new WerkERPContext();
                //var query = db.Chequeras;
                int idBanco = Convert.ToInt32( ddlBancos.SelectedValue);
                var query = db.Chequeras.Where(s => s.id_banco == idBanco);
                   
               
                return query;
            }
            catch (Exception exp)
            {
                ErrorLabel.Text = exp.Message;
                ErrorLabel.Visible = true;
                return null;
            }
        }


        public IQueryable<WerkUI.Models.Cheque> GetChecks()
        {
            try
            {

                var db = new WerkERPContext();
                //var query = db.Cheques;
                int idChequera;
                if (ddlCheqeras.SelectedValue == "")
                    return null;
                else
                    idChequera = Convert.ToInt32(ddlCheqeras.SelectedValue);

                var query = db.Cheques.Where(s => s.id_chequera == idChequera);
                
                return query;
            }
            catch (Exception exp)
            {
                ErrorLabel.Text = exp.Message;
                ErrorLabel.Visible = true;
                return null;
            }
        }

        protected void ddlBancos_SelectedIndexChanged(object sender, EventArgs e)
        {

            ddlCheqeras.Items.Clear();
            ddlCheqeras.DataBind();

            ddlCheques.Items.Clear();
            ddlCheques.DataBind();

        }

        protected void AsignarChequeBtn_Click(object sender, EventArgs e)
        {
            decimal vImporte = 0;
            int vId;
            int vIdCheque;

            try
            {
              var db = new WerkERPContext();
                vIdCheque = Convert.ToInt32(ddlCheques.SelectedValue.ToString());

              for (int i = 0; i <=  RequestOPDetailsListView.Items.Count - 1; i++)
                        {
                            ListViewItem row = (ListViewItem)RequestOPDetailsListView.Items[i];
                            CheckBox chk = (CheckBox)row.FindControl("chkConcept");
                            if (chk.Checked)
                            {
                                try
                                {
                                    vImporte += Convert.ToDecimal(((Label)row.FindControl("lblImporteAprobado")).Text);
                                   
                                    vId = Convert.ToInt32(((Label)row.FindControl("lblID")).Text);
                                    var solicitudOPDetalle = db.SolicitudOrdenPagoDetalles.Where(s => s.id_solicitud_orden_pago_detalle == vId).SingleOrDefault();
                                    solicitudOPDetalle.id_cheque = vIdCheque;               

                                }
                                catch (Exception ax)
                                {
                                    vImporte = 0;
                                }
                              
                               
                            }

                        }

              var cheque = db.Cheques.Where(s => s.id_cheque == vIdCheque).SingleOrDefault();
              
                if (cheque.monto == null)
                    cheque.monto =  vImporte;
                else
                    cheque.monto += vImporte;

              cheque.id_orden_pago = requestID;
              cheque.fecha_emision = DateTime.Now;

              db.SaveChanges();
              ErrorLabel.Text = String.Empty;
              ChequesAsignadosGridView.DataBind();
              RequestOPDetailsListView.DataBind();  
   
            }
            catch(Exception exp)
            {
                ErrorLabel.Text = exp.Message;
                ErrorLabel.Visible = true;
              
            }
        }

        protected void ChequesAsignadosGridView_RowDataBound(object sender, GridViewRowEventArgs e)
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
                    sName = ((Label)ChequesAsignadosGridView.Rows[e.Row.RowIndex - 1].FindControl("lblGrupo")).Text;
                    iPatientIDCount = iPatientIDCount + 1;
                    if (sGroupID == ((Label)e.Row.FindControl("lblGrupo")).Text)
                    {
                        iAddImporte += Convert.ToDecimal(((Label)e.Row.FindControl("lblImporte")).Text);
                    }
                    else
                    {
                        sGroupID = ((Label)e.Row.FindControl("lblGrupo")).Text;
                        Table tblTemp = (Table)this.ChequesAsignadosGridView.Controls[0];
                        int intIndex = tblTemp.Rows.GetRowIndex(e.Row);
                        GridViewRow gvrSubTotal = CreateGridViewRow(intIndex, "#8FD8D8", ChequesAsignadosGridView.Columns.Count, "Total: " + WerkUI.Core.Util.GetFormatedNumber(iAddImporte), 20);
                        tblTemp.Controls.AddAt(intIndex, gvrSubTotal);
                        iPatientIDCount = 0;
                        iAddImporte = Convert.ToDecimal(((Label)e.Row.FindControl("lblImporte")).Text);
                    }
                    if (iRowsCount == e.Row.RowIndex)
                    {
                        sName = ((Label)e.Row.FindControl("lblGrupo")).Text;
                        Table tblTemp = (Table)this.ChequesAsignadosGridView.Controls[0];
                        int intIndex = tblTemp.Rows.GetRowIndex(e.Row) + 1;
                        GridViewRow gvrLast = CreateGridViewRow(intIndex, "#8FD8D8", ChequesAsignadosGridView.Columns.Count, "Total: " + WerkUI.Core.Util.GetFormatedNumber(iAddImporte), 20);
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

        protected void ChequesAsignados_Selected(object sender, SqlDataSourceStatusEventArgs e)
        {
            iRowsCount = e.AffectedRows - 1;
        }

        protected void ChequesAsignadosGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
             // Convert the row index stored in the CommandArgument
            // property to an Integer.
            int index;

            try
            {
                index = Convert.ToInt32(e.CommandArgument);


                // cell in the GridView control.
                GridViewRow selectedRow = ChequesAsignadosGridView.Rows[index];
               
                TableCell IdRequestOPDetail = selectedRow.Cells[0];

                if (e.CommandName == "Eliminar")
                {
                    BrokeCheckRequestOPDetail(Convert.ToInt32( IdRequestOPDetail.Text));
                }
            }
            catch (Exception ex)
            { }

        }

        public void BrokeCheckRequestOPDetail(int IdDetail)
        {
            try
            {
                var db = new WerkERPContext();
                var solicitudOPDetalles = db.SolicitudOrdenPagoDetalles.Where(s => s.id_solicitud_orden_pago_detalle == IdDetail).SingleOrDefault();
               
                solicitudOPDetalles.id_cheque = null;

                db.SaveChanges();
                ErrorLabel.Text = String.Empty;

                ChequesAsignadosGridView.DataBind();
                RequestOPDetailsListView.DataBind();
            }
            catch (DbEntityValidationException ex)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = ex.Message;
            }
            catch (Exception exp)
            {
                ErrorLabel.Text = exp.Message;
                ErrorLabel.Visible = true;
            }
        }

       
    }
}