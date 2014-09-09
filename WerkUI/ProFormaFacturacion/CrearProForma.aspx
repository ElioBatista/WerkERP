<%@ Page Title="Werk | Crear Pre Factura" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="CrearProForma.aspx.cs" Inherits="WerkUI.ProFormaFacturacion.CrearProForma" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <script>
        $(document).ready(function () {
            $("#accordion").accordion();
        });
    </script>
</asp:Content>
<asp:Content ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %></h1>
    </hgroup>
    <section runat="server" id="FacturacionForm">
        <div>
            <asp:Button ID="PreFacturarLiquidacionBtn" runat="server" Text="Pre Facturar" 
                onclick="PreFacturarLiquidacionBtn_Click" />
        </div>
        <div id="accordion">
            <h3><a href="#">Datos de Pre facturación</a></h3>
            <div style="overflow: hidden">
                <asp:FormView ID="PreFacturaFormView" runat="server" DataKeyNames="cod_factura" DefaultMode="Insert" DataSourceID="PreFacturaDataSource" OnDataBound="PreFacturaFormView_DataBound">
                    <InsertItemTemplate>
                        <table>
                            <tr>
                                <td style="vertical-align: top" colspan="2">Nro. factura<br />
                                    <asp:TextBox ID="new_num_facturaTB" runat="server"/>
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
                                    <asp:TextBox ID="new_CodEmpresaTB" runat="server" Text='<%# Bind("[CodEmpresa]") %>' style="display:none;" />
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
                                        <asp:DropDownList ID="new_tipo_facturaDDL" runat="server" Height="33px" Width="200px" DataSourceID = "TipoFacturaDataSource" DataTextField="tipo" DataValueField="cod_tipo_factura">
                                        </asp:DropDownList>
                                        <asp:SqlDataSource ID="TipoFacturaDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="Select cod_tipo_factura, tipo from Facturacion.TipoFactura" SelectCommandType="Text">
                                        </asp:SqlDataSource>
                                        <br />
                                        Moneda<br />
                                        <asp:DropDownList ID="new_monedaDDL" runat="server" Height="33px" Width="200px" DataSourceID = "MonedaDataSource" DataTextField="moneda" DataValueField="cod_moneda">
                                        </asp:DropDownList>
                                        <asp:SqlDataSource ID="MonedaDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="Select cod_moneda, moneda from Core.Monedas" SelectCommandType="Text">
                                        </asp:SqlDataSource>
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
                </asp:FormView>
                <asp:SqlDataSource ID="PreFacturaDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="sp_obtener_datos_facturacion" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="p_cod_liquidacion" QueryStringField="cod_liquidacion" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </div>
            <h3><a href="#">Detalles Pre factura</a></h3>
            <div>
                <asp:GridView ID="PreFacturaDetalleGridView"
                    runat="server"
                    AutoGenerateColumns="False"
                    BackColor="White"
                    BorderColor="#CCCCCC"
                    BorderStyle="None"
                    BorderWidth="1px"
                    CellPadding="4"
                    DataKeyNames="Cod. Liquidación,Secuencia"
                    DataSourceID="PreFacturaDetallesDataSource"
                    ForeColor="Black"
                    GridLines="Horizontal"
                    Width="100%"
                    Font-Names="Segoe UI"
                    Font-Size="Small" OnRowDataBound="PreFacturaDetalleGridView_RowDataBound">
                    <Columns>
                        <asp:TemplateField HeaderText="Procesar" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:CheckBox ID="ConceptoCheck" runat="server"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Grupo ID.">
                            <ItemTemplate>
                                <asp:Label ID="lblGrupo" runat="server" Text='<%# Eval("[Grupo]") %>'></asp:Label>
                                <asp:Label ID="lblSecuencia" runat="server" Text='<%# Eval("[Secuencia]") %>' Visible ="false"></asp:Label>
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
             <%--   <asp:Button ID="AgregarBtn" runat="server" Text="Agregar" 
                    ToolTip ="Previamente, seleccione los Items a agregar" 
                    onclick="AgregarBtn_Click"/>
                &nbsp;
                <asp:Button ID="EliminarBtn" runat="server" Text="Cancelar" 
                    ToolTip ="Elimina los datos previamente seleccionado" Enabled="false" 
                    onclick="EliminarBtn_Click"/>
                <br />--%>
                <asp:Button ID="PreFacturarLiquidacionAbajoBtn" runat="server" Text="Pre Facturar"  onclick="PreFacturarLiquidacionAbajoBtn_Click" />

                <asp:SqlDataSource ID="PreFacturaDetallesDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="sp_obtener_datos_facturacion_detalles" SelectCommandType="StoredProcedure" OnSelected="PreFacturaDetallesDataSource_Selected">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="p_cod_liquidacion" QueryStringField="cod_liquidacion" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
                    <asp:GridView ID="PreFacturaDetalleGeneradaGridView"
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
            <h3><a href="#">Pre Facturas Existentes</a></h3>
            <div>
                <asp:GridView ID="PreFacturasExistentesGridView" runat="server"></asp:GridView>
                <asp:SqlDataSource ID="PreFacturasExistesSqlDataSource" runat="server"></asp:SqlDataSource>
            </div>
        </div>
    </section>
    <script language="javascript" type="text/javascript">
        function verifyNroFactura(obj) {
            var nroFactura = obj.value;
            if (nroFactura) {
                PageMethods.verifyNroFactura(nroFactura, onSucess, onError);
            }
        }

        function onSucess(result) {
            if (result != '')
                alert(result);
        }

        function onError(result) {
            alert('ingrese un Nro Válido.');
        }
       
    </script>
</asp:Content>
