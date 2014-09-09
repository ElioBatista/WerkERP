<%@ Page Title="Werk | Crear factura" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearFactura.aspx.cs" Inherits="WerkUI.Facturacion.CrearFactura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script>
        $(document).ready(function () {
            $("#accordion").accordion();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
  
    <hgroup class="title">
        <h1><%: Title %></h1>
    </hgroup>
    <section runat="server" id="FacturacionForm">
        <div>
            <asp:Button ID="FacturarLiquidacionBtn" runat="server" Text="Facturar" 
                onclick="FacturarLiquidacionBtn_Click" />
        </div>
        <div id="accordion">
            <h3><a href="#">Datos de facturación</a></h3>
            <div style="overflow: hidden">
                <asp:FormView ID="FacturaFormView" runat="server" DataKeyNames="cod_factura" DataSourceID="FacturaDataSource" DefaultMode="Insert" OnDataBound="FacturaFormView_DataBound">
             <%--       <EditItemTemplate>
                        cod_factura:
                        <asp:Label ID="cod_facturaLabel1" runat="server" Text='<%# Eval("cod_factura") %>' />
                        <br />
                        num_factura:
                        <asp:TextBox ID="num_facturaTextBox" runat="server" Text='<%# Bind("num_factura") %>' />
                        <br />
                        cod_cliente:
                        <asp:TextBox ID="cod_clienteTextBox" runat="server" Text='<%# Bind("cod_cliente") %>' />
                        <br />
                        cod_liquidacion:
                        <asp:TextBox ID="cod_liquidacionTextBox" runat="server" Text='<%# Bind("cod_liquidacion") %>' />
                        <br />
                        cod_moneda:
                        <asp:TextBox ID="cod_monedaTextBox" runat="server" Text='<%# Bind("cod_moneda") %>' />
                        <br />
                        fecha:
                        <asp:TextBox ID="fechaTextBox" runat="server" Text='<%# Bind("fecha") %>' />
                        <br />
                        ruc:
                        <asp:TextBox ID="rucTextBox" runat="server" Text='<%# Bind("ruc") %>' />
                        <br />
                        direccion:
                        <asp:TextBox ID="direccionTextBox" runat="server" Text='<%# Bind("direccion") %>' />
                        <br />
                        cod_empresa:
                        <asp:TextBox ID="cod_empresaTextBox" runat="server" Text='<%# Bind("cod_empresa") %>' />
                        <br />
                        telefono:
                        <asp:TextBox ID="telefonoTextBox" runat="server" Text='<%# Bind("telefono") %>' />
                        <br />
                        cod_tipo_factura:
                        <asp:TextBox ID="cod_tipo_facturaTextBox" runat="server" Text='<%# Bind("cod_tipo_factura") %>' />
                        <br />
                        total:
                        <asp:TextBox ID="totalTextBox" runat="server" Text='<%# Bind("total") %>' />
                        <br />
                        iva_gastos:
                        <asp:TextBox ID="iva_gastosTextBox" runat="server" Text='<%# Bind("iva_gastos") %>' />
                        <br />
                        iva_honorarios:
                        <asp:TextBox ID="iva_honorariosTextBox" runat="server" Text='<%# Bind("iva_honorarios") %>' />
                        <br />
                        retencion_iva:
                        <asp:TextBox ID="retencion_ivaTextBox" runat="server" Text='<%# Bind("retencion_iva") %>' />
                        <br />
                        retencion_iva_gastos:
                        <asp:TextBox ID="retencion_iva_gastosTextBox" runat="server" Text='<%# Bind("retencion_iva_gastos") %>' />
                        <br />
                        retencion_iva_honorarios:
                        <asp:TextBox ID="retencion_iva_honorariosTextBox" runat="server" Text='<%# Bind("retencion_iva_honorarios") %>' />
                        <br />
                        <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Actualizar" />
                        <asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
                    </EditItemTemplate>--%>
                    <InsertItemTemplate>
                        <table>
                            <tr>
                                <td style="vertical-align: top" colspan="2">Nro. factura<br />
                                    <asp:TextBox ID="new_num_facturaTB" runat="server" Text='<%# Bind("[Nro. factura]") %>' />
                                    <br />
                                </td>
                                <td colspan="2" style="vertical-align: top">Num. liquidación<br />
                                    <asp:TextBox ID="new_num_liquidacionTB" runat="server" Text='<%# Bind("[Nro. Liquidación]") %>' Enabled="False" Width="355px" />

                                </td>
                            </tr>

                            <tr>
                                <td colspan="4" style="vertical-align: top">
                                    Cliente<br />
                                    <asp:TextBox ID="new_clienteTB" runat="server" Text='<%# Bind("[Cliente]") %>' />
                                    <asp:TextBox ID="new_CodClienteTB" runat="server" Text='<%# Bind("[CodCliente]") %>' style="display:none;" />
                                    <br />
                                    Dirección<br />
                                    <asp:TextBox ID="new_direccionTB" runat="server" Text='<%# Bind("[Dirección]") %>' Width="875px" />
                                </td>
                            </tr>

                            <tr>
                                <td style="vertical-align: top">
                                    <div>
                                        Teléfono<br />
                                        <asp:TextBox ID="new_telefonoTB" runat="server" Text='<%# Bind("[Teléfono]") %>' />
                                        <br />
                                        R.U.C. Cliente<br />
                                        <asp:TextBox ID="new_rucTB" runat="server" Text='<%# Bind("[R.U.C.]") %>' />
                                    </div>
                                </td>
                                <td style="vertical-align: top" colspan="2">
                                    <div>
                                        Despachante<br />
                                        <asp:TextBox ID="new_despachanteTB" runat="server" Text='<%# Bind("[Despachante]") %>' />
                                        <br />
                                        R.U.C. Despachante<br />
                                        <asp:TextBox ID="new_ruc_despachanteTB" runat="server" Text='<%# Bind("[R.U.C. Despachante]") %>' />
                                        <br />
                                    </div>
                                </td>
                                <td style="vertical-align: top" rowspan="2">
                                    <div style="vertical-align: top">
                                        Fecha<br />
                                        <asp:TextBox ID="new_fechaTB" runat="server" Text='<%# Bind("[Fecha]") %>' Width="190px" />
                                        <br />
                                        Tipo factura<br />
                                        <asp:DropDownList ID="new_tipo_facturaDDL" runat="server" Height="33px" SelectedValue='<%# Bind("[Tipo factura]") %>' Width="200px">
                                            <asp:ListItem>Contado</asp:ListItem>
                                            <asp:ListItem>Crédito</asp:ListItem>
                                        </asp:DropDownList>
                                        <br />
                                        Moneda<br />
                                        <asp:DropDownList ID="new_monedaDDL" runat="server" Height="33px" SelectedValue='<%# Bind("[Moneda]") %>' Width="200px">
                                            <asp:ListItem>Guaraníes</asp:ListItem>
                                            <asp:ListItem>Dólares</asp:ListItem>
                                        </asp:DropDownList>
                                        <br />                                                                       
                                        Nro. Despacho interno<br />
                                        <asp:TextBox ID="new_despacho_internoTB" runat="server" Text='<%# Bind("[Nro. Despacho Interno]") %>' Width="190px" />
                                        <br />
                                        Nro. Despacho<br />
                                        <asp:TextBox ID="new_despachoTB" runat="server" Text='<%# Bind("[Nro. Despacho]") %>' Width="190px" />
                                    </div>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <div>
                                        Total<br />
                                        <asp:TextBox ID="new_totalTB" runat="server" Text='<%# Bind("[Total]") %>' />
                                        <br />
                                        I.V.A. gastos<br />
                                        <asp:TextBox ID="new_iva_gastosTB" runat="server" Text='<%# Bind("[IVA Gastos]") %>' />
                                        <br />
                                        I.V.A. honorarios<br />
                                        <asp:TextBox ID="new_iva_honorariosTB" runat="server" Text='<%# Bind("[IVA Honorarios]") %>' />

                                    </div>
                                </td>
                                <td style="vertical-align: top" colspan="2">
                                    <div>
                                        Ret. I.V.A.<br />
                                        <asp:TextBox ID="new_retencion_ivaTB" runat="server" Text='<%# Bind("[IVA Retención]") %>' />
                                        <br />
                                        Ret. I.V.A. gastos<br />
                                        <asp:TextBox ID="new_retencion_iva_gastosTB" runat="server" Text='<%# Bind("[IVA Ret. Gastos]") %>' />
                                        <br />
                                        Ret. I.V.A. hornorarios<br />
                                        <asp:TextBox ID="new_retencion_iva_honorariosTB" runat="server" Text='<%# Bind("[IVA Ret. Honorarios]") %>' />
                                    </div>
                                </td>
                            </tr>
                           

                        </table>
                    </InsertItemTemplate>
           <%--         <ItemTemplate>
                        <div>
                            <div class="float-left">
                                cod_factura:
                        <asp:Label ID="cod_facturaLabel" runat="server" Text='<%# Eval("cod_factura") %>' />
                                <br />
                                num_factura:
                        <asp:Label ID="num_facturaLabel" runat="server" Text='<%# Bind("num_factura") %>' />
                                <br />
                                cod_cliente:
                        <asp:Label ID="cod_clienteLabel" runat="server" Text='<%# Bind("cod_cliente") %>' />
                                <br />
                                cod_liquidacion:
                        <asp:Label ID="cod_liquidacionLabel" runat="server" Text='<%# Bind("cod_liquidacion") %>' />
                                <br />
                                cod_moneda:
                        <asp:Label ID="cod_monedaLabel" runat="server" Text='<%# Bind("cod_moneda") %>' />
                                <br />
                                fecha:
                        <asp:Label ID="fechaLabel" runat="server" Text='<%# Bind("fecha") %>' />
                                <br />
                                ruc:
                        <asp:Label ID="rucLabel" runat="server" Text='<%# Bind("ruc") %>' />
                                <br />
                                direccion:
                        <asp:Label ID="direccionLabel" runat="server" Text='<%# Bind("direccion") %>' />
                                <br />
                                cod_empresa:
                        <asp:Label ID="cod_empresaLabel" runat="server" Text='<%# Bind("cod_empresa") %>' />
                                <br />

                            </div>
                            <div class="float-right">
                                telefono:
                        <asp:Label ID="telefonoLabel" runat="server" Text='<%# Bind("telefono") %>' />
                                <br />
                                cod_tipo_factura:
                        <asp:Label ID="cod_tipo_facturaLabel" runat="server" Text='<%# Bind("cod_tipo_factura") %>' />
                                <br />
                                total:
                        <asp:Label ID="totalLabel" runat="server" Text='<%# Bind("total") %>' />
                                <br />
                                iva_gastos:
                        <asp:Label ID="iva_gastosLabel" runat="server" Text='<%# Bind("iva_gastos") %>' />
                                <br />
                                iva_honorarios:
                        <asp:Label ID="iva_honorariosLabel" runat="server" Text='<%# Bind("iva_honorarios") %>' />
                                <br />
                                retencion_iva:
                        <asp:Label ID="retencion_ivaLabel" runat="server" Text='<%# Bind("retencion_iva") %>' />
                                <br />
                                retencion_iva_gastos:
                        <asp:Label ID="retencion_iva_gastosLabel" runat="server" Text='<%# Bind("retencion_iva_gastos") %>' />
                                <br />
                                retencion_iva_honorarios:
                        <asp:Label ID="retencion_iva_honorariosLabel" runat="server" Text='<%# Bind("retencion_iva_honorarios") %>' />
                                <br />
                            </div>
                        </div>
                        <asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="Nuevo" />
                    </ItemTemplate>--%>
                </asp:FormView>
                <asp:SqlDataSource ID="FacturaDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="sp_obtener_datos_facturacion" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="p_cod_liquidacion" QueryStringField="cod_liquidacion" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </div>
            <h3><a href="#">Detalles factura</a></h3>
            <div>
                <asp:GridView ID="FacturaDetalleGridView"
                    runat="server"
                    AutoGenerateColumns="False"
                    BackColor="White"
                    BorderColor="#CCCCCC"
                    BorderStyle="None"
                    BorderWidth="1px"
                    CellPadding="4"
                    DataKeyNames="Cod. Liquidación,Secuencia"
                    DataSourceID="FacturaDetallesDataSource"
                    ForeColor="Black"
                    GridLines="Horizontal"
                    Width="100%"
                    Font-Names="Segoe UI"
                    Font-Size="Small" OnRowDataBound="FacturaDetalleGridView_RowDataBound">
                    <Columns>
                        <asp:TemplateField HeaderText="Procesar" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:CheckBox ID="ConceptoCheck" runat="server"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Grupo ID.">
                            <ItemTemplate>
                                <asp:Label ID="lblGrupo" runat="server" Text='<%# Eval("[Grupo]") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Concepto">
                            <ItemTemplate>
                                <asp:Label ID="lblConcepto" runat="server" Text='<%# Eval("[Concepto]") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Importe">
                            <ItemTemplate>
                                <asp:Label ID="lblImporte" runat="server" Text='<%# WerkUI.Core.Util.GetFormatedNumber(Eval("Importe")) %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Comentario">
                            <ItemTemplate>
                                <asp:Label ID="lblComentario" runat="server" Text='<%# Eval("[Comentario]") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#242121" />
                </asp:GridView>
                <br />
                <asp:Button ID="AgregarBtn" runat="server" Text="Agregar" 
                    ToolTip ="Previamente, seleccione los Items a agregar" 
                    onclick="AgregarBtn_Click"/>
                &nbsp;
                <asp:Button ID="EliminarBtn" runat="server" Text="Cancelar" 
                    ToolTip ="Elimina los datos previamente seleccionado" Enabled="false" 
                    onclick="EliminarBtn_Click"/>

                <asp:SqlDataSource ID="FacturaDetallesDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="sp_obtener_datos_facturacion_detalles" SelectCommandType="StoredProcedure" OnSelected="FacturaDetallesDataSource_Selected">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="p_cod_liquidacion" QueryStringField="cod_liquidacion" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
                    <asp:GridView ID="FacturaDetalleGeneradaGridView"
                    runat="server"
                    AutoGenerateColumns="False"
                    BackColor="White"
                    BorderColor="#CCCCCC"
                    BorderStyle="None"
                    BorderWidth="1px"
                    CellPadding="4"
                    ForeColor="Black"
                    GridLines="Horizontal"
                    Width="100%"
                    Font-Names="Segoe UI"
                    Font-Size="Small">
                    <Columns>
                        <asp:BoundField DataField="GrupoID" HeaderText="Grupo ID"/>
                        <asp:BoundField DataField="Concepto" HeaderText="Concepto"/>
                        <asp:BoundField DataField="Importe" HeaderText="Importe"/>
                        <asp:BoundField DataField="Comentario" HeaderText="Comentario"/>
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#242121" />
                </asp:GridView>
            </div>
            <h3><a href="#">Facturas Existentes</a></h3>
            <div>
                <asp:GridView ID="FacturasExistentesGridView" runat="server"></asp:GridView>
                <asp:SqlDataSource ID="FacturasExistesSqlDataSource" runat="server"></asp:SqlDataSource>
            </div>
        </div>
    </section>
    <script language="javascript" type="text/javascript">
        function verifyNroFactura(obj) {
            var mensaje = obj.value;
            PageMethods.verifyNroFactura(mensaje, onSucess, onError);
        }
        
        function onSucess(result) {
        if (result !='')
            alert(result);
        }

        function onError(result) {
            alert('Something wrong.');
        }
       
    </script>
</asp:Content>
