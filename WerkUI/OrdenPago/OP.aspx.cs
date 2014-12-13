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
    public partial class OP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

           public IQueryable<WerkUI.Models.SolicitudOrdenPago> GetRequestOPs()
        {
            try
            {
                var db = new WerkERPContext();
                var query = db.SolicitudOrdenPagoes;
                return query;
            }
            catch (Exception exp)
            {
                ErrorLabel.Text = exp.Message;
                ErrorLabel.Visible = true;
                return null;
            }
        }

        public void UpdateRequestOP(WerkUI.Models.SolicitudOrdenPago subject)
        {
            try
            {
                var db = new WerkERPContext();
                var solicitudOP = db.SolicitudOrdenPagoes.Where(s => s.id_solicitud_orden_pago == subject.id_solicitud_orden_pago).SingleOrDefault();
                solicitudOP.nro_comprobante = subject.nro_comprobante;

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

        public void DeleteRequestOP(WerkUI.Models.SolicitudOrdenPago subject)
        {
            try
            {
                var db = new WerkERPContext();
                var solicitudOP = db.SolicitudOrdenPagoes.Where(s => s.id_solicitud_orden_pago == subject.id_solicitud_orden_pago).SingleOrDefault();
                db.SolicitudOrdenPagoes.Remove(solicitudOP);
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

        protected void RequestOPsListView_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            RequestOPsListView.EditIndex = e.NewEditIndex;
        }

        protected void RequestOPsListView_ItemCanceling(object sender, ListViewCancelEventArgs e)
        {
            RequestOPsListView.EditIndex = -1;
        }

        public Boolean VerifyNroOP(String nroComprobante)
        {
            try
            {
                var db = new WerkERPContext();
                var query = db.ORDENPAGOCLIENTEs.Where(s => s.NUMEROCOMPROBANTE == nroComprobante).SingleOrDefault();
                if (query.CODCOMPROBANTE.ToString() != "")
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

        public static string GetUserLogin(object codFuncionario)
        {
            int tranformed;

            try
            {
                tranformed = Convert.ToInt32( codFuncionario.ToString());
                var db = new WerkERPContext();
                var query = db.Usuarios.Where(s => s.cod_usuario == tranformed).SingleOrDefault();
                if (query.usuario1.ToString() != "")
                {
                    return query.usuario1.ToString();
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            { return ""; }
        }


        public void InsertRequestOP()
        {
            var db = new WerkERPContext();
            var solicitudOP = new WerkUI.Models.SolicitudOrdenPago();

            TryUpdateModel(solicitudOP);
            if (ModelState.IsValid)
            {
                try
                {
                    solicitudOP.id_estado = 1;
                    solicitudOP.fecha_solicitud = DateTime.Now;

                    if (VerifyNroOP(solicitudOP.nro_comprobante.ToString()))
                    {
                        ErrorLabel.Visible = true;
                        ErrorLabel.Text = "El Nro. de comprobante ya existe.";
                    }
                    else
                    { 

                    db.SolicitudOrdenPagoes.Add(solicitudOP);
                    db.SaveChanges();
                    ErrorLabel.Text = String.Empty;

                    //Si la operacion a sido exitosa voy a los detalles de la nueva SOP
                    Response.Redirect("~/OrdenPago/RequestOPDetails.aspx?RequestID=" + solicitudOP.id_solicitud_orden_pago.ToString() + "&RequestNumber=" + solicitudOP.nro_comprobante);
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = ex.Message;
                }
                catch (Exception exp)
                {
                    if (exp.InnerException.HResult.ToString() == "-2146233087")
                        ErrorLabel.Text = "El numero de comprobante corresponde a otra solicitud.";
                    else
                        ErrorLabel.Text = exp.Message;

                    ErrorLabel.Visible = true;
                }
            }
        }


    
    }
}