<%@ Page Title="Werk | Crear factura" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearFactura.aspx.cs" Inherits="WerkUI.Facturacion.CrearFactura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script>
        function queryObj() {
            var result = {}, queryString = location.search.slice(1),
                re = /([^&=]+)=([^&]*)/g, m;

            while (m = re.exec(queryString)) {
                result[decodeURIComponent(m[1])] = decodeURIComponent(m[2]);
            }

            return result;
        }

        $(document).ready(function () {
            $("#accordion").accordion();
        });
        $(function () {
            var accordionindex = parseInt(queryObj()["AccordionIX"], 10);
            //alert("Setting active index to " + accordionindex);
            $("#accordion").accordion('activate', accordionindex);
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <hgroup class="title">
        <h1></h1>
    </hgroup>
    <section runat="server" id="FacturacionForm">
        <div>
            <h2>Datos de facturación</h2>
            <br />
            <div style="overflow: hidden" id="Cabecera">
                <asp:Panel ID="CabeceraFacturacioPanel" runat="server" DefaultButton="FacturarLiquidacionBtn">
                    <asp:Button ID="FacturarLiquidacionBtn" runat="server" Text="Facturar liquidación" OnClick="FacturarLiquidacionBtn_Click" Enabled="False" />
                    <asp:FormView ID="FacturaFormView" runat="server" DataKeyNames="cod_factura" DataSourceID="FacturaDataSource" DefaultMode="Insert" OnDataBound="FacturaFormView_DataBound">
                      
                        <InsertItemTemplate>
                            <table>
                                <tr>
                                    <td style="vertical-align: top">
                                        <div class="float-left">
                                            Nro. factura
                                            <br />
                                            <asp:TextBox ID="new_num_facturaTB" runat="server" Text='<%# Bind("[Nro. factura]") %>' Width="150px" />
                                            <br />
                                             Tipo factura
                                            <br />
                                            <asp:DropDownList ID="new_tipo_facturaDDL" runat="server" Height="33px" SelectedValue='<%# Bind("[Tipo factura]") %>' Width="200px">
                                                <asp:ListItem>Contado</asp:ListItem>
                                                <asp:ListItem>Crédito</asp:ListItem>
                                            </asp:DropDownList>
                                            <br />
                                        </div>
                                    </td>
                                    <td style="vertical-align: top">
                                        <div class="float-left" style="vertical-align: top">
                                            Fecha<br />
                                            <asp:TextBox ID="new_fechaTB" runat="server" Text='<%# Bind("[Fecha]") %>' Width="190px" />
                                            <br />
                                            Moneda<br />
                                            <asp:DropDownList ID="new_monedaDDL" runat="server" Height="33px" SelectedValue='<%# Bind("[Moneda]") %>' Width="200px">
                                                <asp:ListItem Value="1">Guaraníes</asp:ListItem>
                                                <asp:ListItem Value="2">Dólares</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </td>
                                    <td  style="vertical-align: top">
                                        
                                        <div class="float-left">
                                            Num. liquidación<br />
                                            <asp:TextBox ID="new_num_liquidacionTB" runat="server" Text='<%# Bind("[Nro. Liquidación]") %>' Enabled="False" Width="150px" />
                                            <br />
                                             Nro. Despacho<br />
                                            <asp:TextBox ID="new_despachoTB" runat="server" Text='<%# Bind("[Nro. Despacho]") %>' Width="190px" />
                                        </div>
                                          
                                    </td>
                                    <td style="vertical-align: top">
                                        <div class="float-left">
                                            Nro. Despacho interno<br />
                                            <asp:TextBox ID="new_despacho_internoTB" runat="server" Text='<%# Bind("[Nro. Despacho Interno]") %>' Width="200px" />
                                            <br />
                                            Tipo Movimiento<br />
                                            <asp:TextBox ID="new_tipo_movimientoTB" runat="server" Text='<%# Bind("[Tipo Movimiento]") %>' Width="200px" />
                                            <br />

                                        </div>
                                    </td>
                                </tr>

                                <tr>
                                    <td colspan="3" style="vertical-align: top">
                                        <div class="float-left">
                                        Cliente<br />
                                        <asp:TextBox ID="new_clienteTB" runat="server" Text='<%# Bind("[Cliente]") %>' Width="500px" />                                        
                                        <asp:TextBox ID="new_CodClienteTB" runat="server" Text='<%# Bind("[CodCliente]") %>' Style="display: none;" />
                                        <br />
                                        Dirección
                                        <br />
                                        <asp:TextBox ID="new_direccionTB" runat="server" Text='<%# Bind("[Dirección]") %>' Width="500px" />
                                            </div>
                                    </td>
                                    <td style="vertical-align: top">
                                        <div class="float-left">
                                            Total<br />
                                            <asp:TextBox ID="new_totalTB" runat="server" Text='<%# Bind("[Total]") %>' Width="200px" />
                                            <br />
                                            Ret. I.V.A. gastos<br />
                                            <asp:TextBox ID="new_retencion_iva_gastosTB" runat="server" Text='<%# Bind("[IVA Ret. Gastos]") %>' Width="200px" />
                                        </div>
                                    </td>
                                </tr>

                                <tr>
                                    <td style="vertical-align: top">
                                        <div class="float-left">
                                            Teléfono<br />
                                            <asp:TextBox ID="new_telefonoTB" runat="server" Text='<%# Bind("[Teléfono]") %>' Width="200px" />
                                            <br />
                                            R.U.C. Cliente<br />
                                            <asp:TextBox ID="new_rucTB" runat="server" Text='<%# Bind("[R.U.C.]") %>' Width="200px" />
                                        </div>
                                    </td>
                                    <td style="vertical-align: top" >
                                        <div class="float-left">
                                            Despachante<br />
                                            <asp:TextBox ID="new_despachanteTB" runat="server" Text='<%# Bind("[Despachante]") %>' Width="200px" />
                                            <br />
                                            R.U.C. Despachante<br />
                                            <asp:TextBox ID="new_ruc_despachanteTB" runat="server" Text='<%# Bind("[R.U.C. Despachante]") %>' Width="200px" />
                                            <br />
                                        </div>
                                    </td>
                                    <td style="vertical-align: top">
                                        <div class="float-left" style="vertical-align: top">
                                            Ret. I.V.A.<br />
                                            <asp:TextBox ID="new_retencion_ivaTB" runat="server" Text='<%# Bind("[IVA Retención]") %>' Width="200px" />
                                            <br />
                                            Ret. I.V.A. hornorarios<br />
                                            <asp:TextBox ID="new_retencion_iva_honorariosTB" runat="server" Text='<%# Bind("[IVA Ret. Honorarios]") %>' Width="200px" />
                                        </div>
                                    </td>
                                    <td style="vertical-align: top" rowspan="2">
                                        <div style="vertical-align: top" class="float-left">
                                            I.V.A. gastos<br />
                                            <asp:TextBox ID="new_iva_gastosTB" runat="server" Text='<%# Bind("[IVA Gastos]") %>' Width="200px" />
                                            <br />
                                            I.V.A. honorarios<br />
                                            <asp:TextBox ID="new_iva_honorariosTB" runat="server" Text='<%# Bind("[IVA Honorarios]") %>' Width="200px" />
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
                </asp:Panel>
            </div>
            <h2>Conceptos</h2>
            <div id="Detalle">
                <asp:Panel ID="DetalleFacturacionPanel" runat="server" DefaultButton="FacturarConceptosBtn">
                    <asp:GridView ID="FacturaDetalleGridView"
                        runat="server"
                        AutoGenerateColumns="False"
                        BackColor="White"
                        BorderColor="#CCCCCC"
                        BorderStyle="None"
                        BorderWidth="1px"
                        CellPadding="4"
                        DataSourceID="FacturaDetallesDataSource"
                        ForeColor="Black"
                        GridLines="Horizontal"
                        Width="100%"
                        Font-Names="Segoe UI"
                        Font-Size="Small">
                        <Columns>
                            <asp:TemplateField HeaderText="Procesar" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <asp:CheckBox ID="ConceptoCheck" runat="server" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Cod. Liquidación" HeaderText="Cod. Liquidación" SortExpression="Cod. Liquidación" />
                            <asp:BoundField DataField="Cod. Concepto" HeaderText="Cod. Concepto" SortExpression="Cod. Concepto" />
                            <asp:BoundField DataField="Concepto" HeaderText="Concepto" SortExpression="Concepto" />
                            <asp:BoundField DataField="Grupo" HeaderText="Grupo" SortExpression="Grupo" />
                            <asp:BoundField DataField="Importe" HeaderText="Importe" SortExpression="Importe" DataFormatString="{0:#,#}" />

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
                        ToolTip="Previamente, seleccione los Items a agregar"
                        OnClick="AgregarBtn_Click" Enabled="False" UseSubmitBehavior="False" />
                    <asp:Button ID="EliminarBtn" runat="server" Text="Cancelar"
                        ToolTip="Elimina los datos previamente seleccionado" Enabled="false"
                        OnClick="EliminarBtn_Click" />

                    <asp:SqlDataSource ID="FacturaDetallesDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="SELECT [Cod. Liquidación], [Cod. Concepto], Concepto, Grupo, Importe FROM Facturacion.ObtenerConceptosPorFacturar(@p_cod_liquidacion) AS ObtenerConceptosPorFacturar_1">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="p_cod_liquidacion" QueryStringField="cod_liquidacion" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <br />
                    <a id="Generada">
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
                        Font-Size="Small" DataKeyNames="Cod. Liquidación,Cod. Concepto" DataSourceID="ConceptosSeleccionadosSqlDataSource">
                        <Columns>
                            <asp:BoundField DataField="Grupo" HeaderText="Grupo" SortExpression="Grupo" />
                            <asp:BoundField DataField="Concepto" HeaderText="Concepto" SortExpression="Concepto" />
                            <asp:BoundField DataField="Importe" HeaderText="Importe" SortExpression="Importe" />
                            <asp:BoundField DataField="Comentario" HeaderText="Comentario" SortExpression="Comentario" />
                            <asp:BoundField DataField="Cod. Concepto" HeaderText="Cod. Concepto" ReadOnly="True" SortExpression="Cod. Concepto" />
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
                    <asp:SqlDataSource ID="ConceptosSeleccionadosSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="SELECT [Cod. Liquidación], [Cod. Concepto], Grupo, Concepto, Importe, Comentario FROM Facturacion.ConceptosMarcados WHERE ([Cod. Liquidación] = @p_cod_liquidacion)">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="p_cod_liquidacion" QueryStringField="cod_liquidacion" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <br />
                    <asp:Button ID="FacturarConceptosBtn" runat="server" Enabled="False" Text="Facturar conceptos" OnClick="FacturarConceptosBtn_Click" />
                </asp:Panel>
            </div>
            <h2>Facturas Existentes<a id="facturas"></a></h2>
            <div>
                <asp:GridView ID="FacturasExistentesGridView" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="FacturasExistentesSqlDataSource" ForeColor="Black" GridLines="Horizontal" Font-Names="Segoe UI" Font-Size="Small" OnRowCommand="FacturasExistentesGridView_RowCommand" DataKeyNames="cod_factura">
                    <Columns>
                        <asp:BoundField DataField="cod_factura" HeaderText="Codigo" InsertVisible="False" ReadOnly="True" SortExpression="cod_factura" />
                        <asp:BoundField DataField="Nro. Factura" HeaderText="Nro. Factura" SortExpression="Nro. Factura" />
                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" DataFormatString="{0:d}" />
                        <asp:BoundField DataField="Total" HeaderText="Total" SortExpression="Total" DataFormatString="{0:#,#}" />
                        <asp:BoundField DataField="Cliente" HeaderText="Cliente" SortExpression="Cliente" />
                        <asp:BoundField DataField="Despachante" HeaderText="Despachante" SortExpression="Despachante" />
                        <asp:BoundField DataField="moneda" HeaderText="Moneda" SortExpression="moneda" />
                        <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                       
                        <asp:BoundField DataField="Technology" HeaderText="Sistema" SortExpression="Technology" />
                        <asp:BoundField DataField="Tipo Factura" HeaderText="Tipo Factura" SortExpression="Tipo Factura" />
                         <asp:ButtonField ButtonType="Link" Text="Imprimir" CommandName="Imprimir" />
                        <asp:ButtonField ButtonType="Link" Text="Anular" CommandName="Anular" />
                        <asp:ButtonField ButtonType="Link" Text="Cancelar" CommandName="Cancelar" />
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
                <asp:SqlDataSource ID="FacturasExistentesSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="sp_obtener_facturas_existentes" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="p_cod_liquidacion" QueryStringField="cod_liquidacion" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </div>
        </div>
    </section>
    <script language="javascript" type="text/javascript">
        function verifyNroFactura(objFactura, nroRUC) {
           
            var nroFac = objFactura.value;

            PageMethods.verifyNroFactura(nroFac, nroRUC, onSucess, onError);
        }

        function onSucess(result) {
            if (result != '')
                alert(result);
        }

        function onError(result) {
            alert('Something wrong.');
        }

    </script>
</asp:Content>
