using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WerkUI.Models;
using WerkUI.Core;

namespace WerkUI.OrdenPago
{
    public partial class RequestOPDetails : System.Web.UI.Page
    {
        int requestID;

        protected void Page_Load(object sender, EventArgs e)
        {
            requestID = Convert.ToInt32( Request.QueryString["RequestID"]);
            lblSiteTitle.Text = "Detalles de Solicitud de OP - Nro. " + Request.QueryString["RequestNumber"];
           
        }


        public String  GetConceptByNumber(String conceptNumber)
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
                var query = db.SolicitudOrdenPagoDetalles.Where(s => s.id_solicitud_orden_pago == requestID);
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
                solicitudOPDetalles.importe_aprobado = subject.importe;
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
                    solicitudOPDetalles.importe_aprobado = solicitudOPDetalles.importe;

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

      


    }
}