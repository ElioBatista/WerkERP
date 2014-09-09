using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Services;
using System.Data.SqlClient;
using System.Text;


namespace WerkUI.Facturacion
{
    public partial class CrearFactura : System.Web.UI.Page
    {
        String CodigoLiquidacion;
        String NroFactura;
        String FechaFactura;
        static String ConnString;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                CodigoLiquidacion = Request.QueryString["cod_liquidacion"].ToString();

                ConnString = FacturaDataSource.ConnectionString;

                //Verifico si ya esta cerrada la liquidacion
                Verificarfacturacion();
            }
            catch (Exception ex)
            {
                Obtener_datos_liquidacion(-1);
            }

        }


        //Funcion que verifica la facturacion de los conceptos de la liquidacion
        private void Verificarfacturacion()
        {
            if (VerificarCierreLiquidacion(CodigoLiquidacion) == 1)
            {
                FacturarLiquidacionBtn.Enabled = false;
                FacturarConceptosBtn.Enabled = false;
                AgregarBtn.Enabled = false;
                EliminarBtn.Enabled = false;
            }
            else if (VerificarFacturacionParcialeLiquidacion(CodigoLiquidacion) == 1)
            {
                FacturarLiquidacionBtn.Enabled = false;
                FacturarConceptosBtn.Enabled = true;
                AgregarBtn.Enabled = true;
                EliminarBtn.Enabled = true;
            }
            else
            {
                FacturarLiquidacionBtn.Enabled = true;
                FacturarConceptosBtn.Enabled = true;
                AgregarBtn.Enabled = true;
                EliminarBtn.Enabled = true;
            }
        }

        protected int VerificarCierreLiquidacion(string p_cod_liquidacion)
        {
            int v_cerrado = 0;
            try
            {
                using (SqlConnection conexion = new SqlConnection(FacturaDataSource.ConnectionString))
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Connection = conexion;
                    comando.CommandText = "sp_verificar_cierre_liquidacion";

                    comando.Parameters.AddWithValue("@p_cod_liquidacion", p_cod_liquidacion);


                    SqlParameter p_cerrado = new SqlParameter("@p_cerrado", SqlDbType.Int);
                    p_cerrado.Direction = ParameterDirection.Output;

                    comando.Parameters.Add(p_cerrado);

                    comando.CommandTimeout = 0;


                    //Anulo la factura
                    comando.ExecuteNonQuery();

                    v_cerrado = Convert.ToInt32(comando.Parameters["@p_cerrado"].Value);

                    conexion.Close();
                }


            }
            catch (Exception ex)
            {
                Core.Util.ShowAlert("Error al verificar cierre de liquidación nro. : " + p_cod_liquidacion + " - " + ex.Message);
                v_cerrado = 0;
            }

            return v_cerrado;
        }


        protected int VerificarFacturacionParcialeLiquidacion(string p_cod_liquidacion)
        {
            int v_facturado_parcialmente = 0;
            try
            {
                using (SqlConnection conexion = new SqlConnection(FacturaDataSource.ConnectionString))
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Connection = conexion;
                    comando.CommandText = "sp_verificar_facturacion_parcial_liquidacion";

                    comando.Parameters.AddWithValue("@p_cod_liquidacion", p_cod_liquidacion);


                    SqlParameter p_facturado_parcialmente = new SqlParameter("@p_facturado_parcialmente", SqlDbType.Int);
                    p_facturado_parcialmente.Direction = ParameterDirection.Output;

                    comando.Parameters.Add(p_facturado_parcialmente);

                    comando.CommandTimeout = 0;


                    //Anulo la factura
                    comando.ExecuteNonQuery();

                    v_facturado_parcialmente = Convert.ToInt32(comando.Parameters["@p_facturado_parcialmente"].Value);

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Core.Util.ShowAlert("Error al Verificar facturación parcial de liquidación nro. : " + p_cod_liquidacion + " - " + ex.Message);
                v_facturado_parcialmente = 0;
            }

            return v_facturado_parcialmente;

        }

        //Procediemiento que recupera los datos de la liquidacion 
        //segun el codigo de liquidacion que recibe la pagina
        private void Obtener_datos_liquidacion(int p_cod_liquidacion)
        {
            try
            {
                /*Codigo de Inicializacion Beta*/
                object[] para = { p_cod_liquidacion };
                Models.V_LIQUIDACIONES vLiq;
                //Models.ProFormaFactura pFormFac = new Models.ProFormaFactura(); 

                if (p_cod_liquidacion > 0)
                {
                    TextBox txtNew_fact = (TextBox)FacturaFormView.FindControl("new_num_facturaTB");
                    TextBox txtNew_ruc = (TextBox)FacturaFormView.FindControl("new_ruc_despachanteTB");

                    

                    using (Models.WerkERPContext db = new WerkUI.Models.WerkERPContext())
                    {
                        //Obtengo la Liquidacion segun el cod_liquidacion recibdo por el formulario web
                        vLiq = db.V_LIQUIDACIONES.Find(para);
                    }

                    ((TextBox)FacturaFormView.FindControl("new_num_facturaTB")).Attributes.Add("onblur", "javascript:verifyNroFactura(this,'" + vLiq.R_U_C__Despachante + "');");

                    // Asignamos los valores a los campos del form view
                    ((TextBox)FacturaFormView.FindControl("new_fechaTB")).Text = ((DateTime)vLiq.Fecha).ToShortDateString(); // DateTime.Now.ToShortDateString();
                    
                    ((TextBox)FacturaFormView.FindControl("new_clienteTB")).Text = vLiq.Cliente.Trim();

                    ((TextBox)FacturaFormView.FindControl("new_CodClienteTB")).Text = vLiq.CODUSUARIO.ToString();

                    ((TextBox)FacturaFormView.FindControl("new_num_liquidacionTB")).Text = vLiq.Nro__Liquidación.ToString();
                    ((DropDownList)FacturaFormView.FindControl("new_monedaDDL")).SelectedIndex = 0;

                    ((TextBox)FacturaFormView.FindControl("new_telefonoTB")).Text = vLiq.Teléfono.Trim();
                    ((TextBox)FacturaFormView.FindControl("new_rucTB")).Text = vLiq.R_U_C_.Trim();
                    ((TextBox)FacturaFormView.FindControl("new_direccionTB")).Text = vLiq.Dirección.Trim();

                    ((TextBox)FacturaFormView.FindControl("new_despachanteTB")).Text = vLiq.Despachante.Trim();
                    ((TextBox)FacturaFormView.FindControl("new_ruc_despachanteTB")).Text = vLiq.R_U_C__Despachante.Trim();
                    ((DropDownList)FacturaFormView.FindControl("new_tipo_facturaDDL")).SelectedIndex = 1;
                    ((TextBox)FacturaFormView.FindControl("new_despacho_internoTB")).Text = vLiq.Nro__Despacho_Interno.Trim();
                    ((TextBox)FacturaFormView.FindControl("new_tipo_movimientoTB")).Text = vLiq.Tipo_Movimiento.Trim();
                    ((TextBox)FacturaFormView.FindControl("new_despachoTB")).Text = vLiq.Nro__Despacho.Trim();

                    ((TextBox)FacturaFormView.FindControl("new_totalTB")).Text = Core.Util.GetFormatedNumber(vLiq.Total);
                    ((TextBox)FacturaFormView.FindControl("new_iva_gastosTB")).Text = Core.Util.GetFormatedNumber(vLiq.IVA_Gastos);
                    ((TextBox)FacturaFormView.FindControl("new_iva_honorariosTB")).Text = Core.Util.GetFormatedNumber(vLiq.IVA_Honorarios);

                    ((TextBox)FacturaFormView.FindControl("new_retencion_ivaTB")).Text = Core.Util.GetFormatedNumber(vLiq.IVA_Retención);
                    ((TextBox)FacturaFormView.FindControl("new_retencion_iva_gastosTB")).Text = Core.Util.GetFormatedNumber(vLiq.IVA_Ret__Gastos);
                    ((TextBox)FacturaFormView.FindControl("new_retencion_iva_honorariosTB")).Text = Core.Util.GetFormatedNumber(vLiq.IVA_Ret__Honorarios);

                }

                FacturaDetalleGeneradaGridView.DataBind();

            }
            catch (Exception ex)
            {
                Core.Util.ShowAlert("Error al obtener datos liquidación: " + ex.Message);
            }
        }

        protected void FacturaFormView_DataBound(object sender, EventArgs e)
        {
            Obtener_datos_liquidacion(Convert.ToInt32(CodigoLiquidacion));
        }


        //Procedimiento que agrega los conceptos de forma independiente para su facturacion en facturas separadas
        protected void AgregarBtn_Click(object sender, EventArgs e)
        {

            Decimal vImporte;
            try
            {
                //Asigno el Numero de factura
                NroFactura = ((TextBox)FacturaFormView.FindControl("new_num_facturaTB")).Text;
                FechaFactura = ((TextBox)FacturaFormView.FindControl("new_fechaTB")).Text;

                if (NroFactura != null && NroFactura != "")
                {
                    using (Models.WerkERPContext db = new WerkUI.Models.WerkERPContext())
                    {
                        for (int i = 0; i <= FacturaDetalleGridView.Rows.Count - 1; i++)
                        {
                            GridViewRow row = (GridViewRow)FacturaDetalleGridView.Rows[i];
                            CheckBox chk = (CheckBox)row.FindControl("ConceptoCheck");
                            if (chk.Checked)
                            {
                                try
                                {
                                    vImporte = Convert.ToDecimal(row.Cells[5].Text);
                                }
                                catch (Exception ax)
                                {
                                    vImporte = 0;
                                }
                              
                                InsertarConceptoMarcado(Convert.ToInt32(row.Cells[1].Text),
                                                        Convert.ToInt32(row.Cells[2].Text),
                                                        Convert.ToInt32(row.Cells[4].Text),
                                                        0,
                                                        row.Cells[3].Text,
                                                        vImporte, 
                                                        "");


                                // Habilitamos el boton para que se pueda eliminar la operacion
                                this.EliminarBtn.Enabled = true;
                                this.FacturarConceptosBtn.Enabled = true;
                            }

                        }
                  
                    }


                    this.FacturaDetalleGeneradaGridView.DataBind();

                    // Cargamos nuevamente la grilla
                    this.FacturaDetalleGridView.DataBind();

                    //Muevo el foco a la tabla de Faturas generadas
                    SetFocusControl("#Generada");
                }
                else
                {
                    Core.Util.ShowAlert("El campo nro. de factura debe tener información.");
                }

            }
            catch (Exception ex)
            {
                Core.Util.ShowAlert("Error al agregar concepto: " + ex.Message);
            }
        }





        //Funcion que cancela los conceptos seleccionados
        protected void EliminarBtn_Click(object sender, EventArgs e)
        {
            EliminarConceptosMarcados(Convert.ToInt32(CodigoLiquidacion));
            this.EliminarBtn.Enabled = false;
            this.FacturarConceptosBtn.Enabled = false;

            // Cargamos nuevamente la grilla
            RefrescarGrillas();

                        
        }


        //Funcion que ejecuta la Facturacion de la Liquidacion de manera integral
        //devuelve el codigo de factura generado o -1 en el caso de error
        protected int FacturarLiquidacion()
        {
            int cod_factura;
            try
            {
                /*Ejecuto el procedieminto de Facturacion de la Liquidacion*/
                using (SqlConnection conexion = new SqlConnection(FacturaDataSource.ConnectionString))
                {

                    conexion.Open();

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Connection = conexion;
                    comando.CommandText = "sp_facturar_liquidacion";

                    comando.Parameters.AddWithValue("@p_cod_liquidacion", CodigoLiquidacion);
                    comando.Parameters.AddWithValue("@p_nro_factura", NroFactura);
                    comando.Parameters.AddWithValue("@p_fecha_factura", FechaFactura);

                    comando.Parameters.AddWithValue("@p_tipo_factura", ((DropDownList)FacturaFormView.FindControl("new_tipo_facturaDDL")).SelectedValue);
                    comando.Parameters.AddWithValue("@p_cod_moneda", ((DropDownList)FacturaFormView.FindControl("new_monedaDDL")).SelectedValue);


                    SqlParameter p_cod_factura = new SqlParameter("@p_cod_factura", SqlDbType.Int);
                    p_cod_factura.Direction = ParameterDirection.Output;

                    comando.Parameters.Add(p_cod_factura);
                    comando.CommandTimeout = 0;

                    //Facturo la liquidación
                    comando.ExecuteNonQuery();

                    //Obtengo el Codigo de Factura generado
                    cod_factura = Convert.ToInt32(comando.Parameters["@p_cod_factura"].Value);
                }

                //Actualizo los impouestos
                CalcularImpuestosFactura(cod_factura);

                return cod_factura;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        //Procediemiento que refrezca las grillas de facturacion
        protected  void RefrescarGrillas()
        {
            FacturasExistentesGridView.DataBind();
            FacturaDetalleGeneradaGridView.DataBind();
            FacturaDetalleGridView.DataBind();
        }
        /*
         *Funcion que factura la liquidacion en su totalidad despendiendo del 
         * Codigo de liquidacion
         * Autor: Christian Balbuena
         * Fecha: 29/02/2013
         */
        protected void FacturarLiquidacionBtn_Click(object sender, EventArgs e)
        {

            try
            {
                //Asigno el Numero de factura
                NroFactura = ((TextBox)FacturaFormView.FindControl("new_num_facturaTB")).Text;
                FechaFactura = ((TextBox)FacturaFormView.FindControl("new_fechaTB")).Text;

                if (NroFactura != null && NroFactura != "")
                {
                    if (CodigoLiquidacion != null && CodigoLiquidacion != "")
                    {
                        if (FacturarLiquidacion() >= 0)
                        {
                            //Limpio el cuadro de Numero de factura ya que se facturo con exito esta
                            ((TextBox)FacturaFormView.FindControl("new_num_facturaTB")).Text = "";

                            RefrescarGrillas();
                            Verificarfacturacion();
                            SetFocusControl("#facturas");
                        }
                        else
                        {
                            Core.Util.ShowAlert("No se pudo efectuar la facturacion.");
                        }
                    }
                    else
                    {
                        Core.Util.ShowAlert("La liquidación no es valida.");
                    }
                }
                else
                {
                    Core.Util.ShowAlert("El campo nro. de factura debe tener información.");
                }
            }
            catch (Exception ex)
            {
                Core.Util.ShowAlert("Error al facturar: " + ex.Message);
            }
        }



       


        //Funcion que devuele si el nro de factura existe
        [WebMethod]
        public static string verifyNroFactura(string nroFactura, string nrpRuc)
        {
            int cant;


            using (SqlConnection conexion = new SqlConnection(ConnString))
            {

                conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = conexion;
                comando.CommandText = "sp_verificar_factura_despachante";

                comando.Parameters.AddWithValue("@p_ruc_despachante", nrpRuc);
                comando.Parameters.AddWithValue("@p_nro_factura", nroFactura);


                SqlParameter p_existe_factura = new SqlParameter("@p_existe_factura", SqlDbType.Int);
                p_existe_factura.Direction = ParameterDirection.Output;

                comando.Parameters.Add(p_existe_factura);
                comando.CommandTimeout = 0;

                //Facturo la liquidación
                comando.ExecuteNonQuery();

                //Obtengo el Codigo de Factura generado
                cant = Convert.ToInt32(comando.Parameters["@p_existe_factura"].Value);


            }



            if (cant > 0 || nroFactura == "") 
            {
                return "El nro de factura: " + nroFactura + " ya ha sido utilizado anteriormente, favor indique otro número";
            }
            else
            {
                return string.Empty;
            }

         
        }

        //Procedimiento que comboca el SP de anulacion de factura en la DB
        protected void AnularFactura(string p_nro_factura)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(FacturaDataSource.ConnectionString))
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Connection = conexion;
                    comando.CommandText = "sp_anular_factura";

                    comando.Parameters.AddWithValue("@p_nro_factura", p_nro_factura);
                    comando.CommandTimeout = 0;

                    //Anulo la factura
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }


            }
            catch (Exception ex)
            {
                Core.Util.ShowAlert("Error al Anular Factura nro. : " + p_nro_factura + " - " + ex.Message);
            }

        }



        protected void CancelarFactura(string p_nro_factura)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(FacturaDataSource.ConnectionString))
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Connection = conexion;
                    comando.CommandText = "sp_cancelar_factura";

                    comando.Parameters.AddWithValue("@p_nro_factura", p_nro_factura);
                    comando.CommandTimeout = 0;

                    //Anulo la factura
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }


            }
            catch (Exception ex)
            {
                Core.Util.ShowAlert("Error al Cancelar Factura nro. : " + p_nro_factura + " - " + ex.Message);
            }

        }


        //Funcion que se llama al ejecutar un comando en la fila de la Grilla de Facturas Existentes
        protected void FacturasExistentesGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            // Convert the row index stored in the CommandArgument
            // property to an Integer.
            int index;

            index = Convert.ToInt32(e.CommandArgument);

            // Get the last name of the selected author from the appropriate
            // cell in the GridView control.
            GridViewRow selectedRow = FacturasExistentesGridView.Rows[index];
            TableCell CellNroFactura = selectedRow.Cells[1];
            TableCell CodFactura = selectedRow.Cells[0];
            TableCell Technology = selectedRow.Cells[11];

            if (Technology.Text == "LEGACY")
            {
                Core.Util.ShowAlert("Esta factura corresponde al sistema LEGACY");
                return;
            }

            if (e.CommandName == "Anular")
            {
                AnularFactura(CellNroFactura.Text);
                Verificarfacturacion();
                RefrescarGrillas();                
                SetFocusControl("#facturas");
            }
            else if (e.CommandName == "Imprimir")
            {
                Core.Util.OpenNewWindow(Core.Util.GetParameter("Facturacion", "FacturaCecilia") + "&p_cod_factura=" + CodFactura.Text, this.GetType());
            }
            else if (e.CommandName == "Cancelar")
            {
                CancelarFactura(CellNroFactura.Text);
                Verificarfacturacion();
                RefrescarGrillas();                   
                SetFocusControl("#facturas");
            }





        }


        //Procediemiento que posiciona la pagina en el bookmark solicitado
        private void SetFocusControl(string Bookmark)
        {
            string scriptString = "<script language=javascript>";
            scriptString += " location.hash='" + Bookmark + "';";
            //scriptString += " alert('location.hash=' + location.hash)"; // test 
            scriptString += "</script>";
          
            ClientScript.RegisterClientScriptBlock(GetType(),"Bookmark",scriptString);
             //.RegisterClientScriptBlock("ClientScript", scriptString);
        } 


        //Procedimiento que actualiza el encabezado de las facturas creadas
        protected void CalcularImpuestosFactura(int p_cod_factura)
        {
            try
            {
                /*Ejecuto el procedieminto de Facturacion de la Liquidacion*/
                using (SqlConnection conexion = new SqlConnection(FacturaDataSource.ConnectionString))
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Connection = conexion;
                    comando.CommandText = "sp_actualizar_factura_montos";

                    comando.Parameters.AddWithValue("@p_cod_factura", p_cod_factura);

                    comando.CommandTimeout = 0;

                    //Actualizo los datos de la cabecera
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Core.Util.ShowAlert("Error al calcular Impuestos: " + ex.Message);
            }
        }

        //Procedimiento que factura los concpetos de manera individual
        protected void FacturarConceptosBtn_Click(object sender, EventArgs e)
        {
            int v_cod_factura;

            try
            {
                //Asigno el Numero de factura
                NroFactura = ((TextBox)FacturaFormView.FindControl("new_num_facturaTB")).Text;
                FechaFactura = ((TextBox)FacturaFormView.FindControl("new_fechaTB")).Text;

                //Agrego la cabecera de la Factura de conceptos
                /*Ejecuto el procedieminto de Facturacion de la Liquidacion*/
                using (SqlConnection conexion = new SqlConnection(FacturaDataSource.ConnectionString))
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Connection = conexion;
                    comando.CommandText = "sp_facturar_liquidacion_cabecera";

                    comando.Parameters.AddWithValue("@p_cod_liquidacion", CodigoLiquidacion);
                    comando.Parameters.AddWithValue("@p_nro_factura", NroFactura);
                    comando.Parameters.AddWithValue("@p_fecha_factura", FechaFactura);

                    comando.Parameters.AddWithValue("@p_tipo_factura", ((DropDownList)FacturaFormView.FindControl("new_tipo_facturaDDL")).SelectedValue);
                    comando.Parameters.AddWithValue("@p_cod_moneda", ((DropDownList)FacturaFormView.FindControl("new_monedaDDL")).SelectedValue);


                    SqlParameter p_cod_factura = new SqlParameter("@p_cod_factura", SqlDbType.Int);
                    p_cod_factura.Direction = ParameterDirection.Output;

                    comando.Parameters.Add(p_cod_factura);
                    comando.CommandTimeout = 0;

                    //Facturo la liquidación
                    comando.ExecuteNonQuery();

                    //Obtengo el Codigo de Factura generado
                    v_cod_factura = Convert.ToInt32(comando.Parameters["@p_cod_factura"].Value);

                    conexion.Close();
                }


                //Seccion de insercion de Detalles
                GridViewRow dr;

                //Agrego los Conceptos de la tabla Temporal
                using (Models.WerkERPContext db = new WerkUI.Models.WerkERPContext())
                {

                    for (int i = 0; i <= FacturaDetalleGeneradaGridView.Rows.Count - 1; i++)
                    {
                        dr = FacturaDetalleGeneradaGridView.Rows[i];

                        Models.FacturaDetalle detalle = new Models.FacturaDetalle
                        {
                            Cod__Concepto = Convert.ToInt32(dr.Cells[4].Text),
                            cod_factura = v_cod_factura,
                            Cod__Liquidación = Convert.ToInt32(CodigoLiquidacion),
                            Concepto = dr.Cells[1].Text,
                            Comentario = dr.Cells[3].Text,
                            Importe = Convert.ToDecimal(dr.Cells[2].Text),
                            Grupo = Convert.ToInt32(dr.Cells[0].Text)

                        };
                        db.FacturaDetalles.Add(detalle);

                    }

                    //Guardo los cmabios en la DB
                    db.SaveChanges();

                }

                //Actualizo los impouestos
                CalcularImpuestosFactura(v_cod_factura);

                //Elimino los Conceptos por facturar correspondiente a la factura
                EliminarConceptosMarcados(Convert.ToInt32(CodigoLiquidacion));

                //Actualizo las grillas
                RefrescarGrillas();

                //Verifico las facturaciones
                Verificarfacturacion();


                //Limpio el cuadro de Numero de factura ya que se facturo con exito esta
                ((TextBox)FacturaFormView.FindControl("new_num_facturaTB")).Text = "";

                //me posiciono en la seccion de facturas generadas                
                SetFocusControl("#facturas");
            }
            catch (Exception ex)
            {
                Core.Util.ShowAlert("Error al facturar conceptos: " + ex.Message);
            }
        }


        protected void EliminarConceptosMarcados(int p_cod_liquidacion)
        {

            using (Models.WerkERPContext db = new Models.WerkERPContext())
            {
                foreach (var concepto in db.ConceptosMarcados)
                {
                    if (concepto.Cod__Liquidación == p_cod_liquidacion)
                    {
                        db.ConceptosMarcados.Remove(concepto);
                    }

                }

                db.SaveChanges();
            }

        }


        //Insertar Concpeto Maracado
        protected int InsertarConceptoMarcado(int p_Cod_Liquidacion
                                               , int p_Cod_Concepto
                                               , int p_Grupo
                                               , int p_Secuencia
                                               , String p_Concepto
                                               , Decimal p_Importe
                                               , String p_Comentario
                                               )
        {
          
            try
            {
                /*Ejecuto el procedieminto de Facturacion de la Liquidacion*/
                using (SqlConnection conexion = new SqlConnection(FacturaDataSource.ConnectionString))
                {

                    conexion.Open();

                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Connection = conexion;
                    comando.CommandText = "sp_insertar_conceptos_marcados";

                    comando.Parameters.AddWithValue("@p_cod_liquidacion", p_Cod_Liquidacion);

                    comando.Parameters.AddWithValue("@p_Cod_Concepto", p_Cod_Concepto);
                    comando.Parameters.AddWithValue("@p_Grupo", p_Grupo);
                    comando.Parameters.AddWithValue("@p_Secuencia", p_Secuencia);
                    comando.Parameters.AddWithValue("@p_Concepto", p_Concepto);
                    comando.Parameters.AddWithValue("@p_Importe", p_Importe);
                    comando.Parameters.AddWithValue("@p_Comentario", p_Comentario);

                    comando.CommandTimeout = 0;

                    //Facturo la liquidación
                    comando.ExecuteNonQuery();

                }


                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

    }
}