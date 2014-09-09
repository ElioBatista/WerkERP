<%@ Page Title="Werk | Liquidaciones" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Liquidaciones.aspx.cs" Inherits="WerkUI.Liquidacion.Liquidaciones" %>

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
    <section runat="server" id="LiquidacionesForm">
        <div>
            <asp:Button ID="FacturarLiquidacionBtn" runat="server" Text="Facturar Liquidación" OnClick="FacturarLiquidacionBtn_Click" />
        </div>
        <div id="accordion">

            <h3><a href="#">Búsqueda de Liquidaciones</a></h3>
            <div>

                <p>
                    <asp:HiddenField  ID="hiddenCodCliente" runat="server"/>
                    <asp:TextBox ID="LiquidacionesSearchTextBox" runat="server"></asp:TextBox>
                    <asp:Button ID="LiquidacionSearchButton" runat="server" Text="Buscar" 
                        onclick="LiquidacionSearchButton_Click"></asp:Button>
                    <asp:DetailsView ID="dvwLiquidaciones" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Cod Liquidacion" DataSourceID="LiquidacionesDataSource" Font-Names="Segoe UI" Font-Size="Small" ForeColor="Black" GridLines="Horizontal" Height="50px" Width="500px">
                        <EditRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <Fields>
                            <asp:TemplateField HeaderText="Cod. Liquidación">
                                <ItemTemplate>
                                    <asp:Label ID="lblCodLiquidacion" runat="server" Text='<%# Eval("[Cod Liquidacion]") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Nro. Liquidación">
                                <ItemTemplate>
                                    <asp:Label ID="lblNroLiquidacion" runat="server" Text='<%# Eval("[Nro Liquidacion]") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Nro. Despacho">
                                <ItemTemplate>
                                    <asp:Label ID="lblNroDespacho" runat="server" Text='<%# Eval("[Nro Despacho]") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Nro. Despacho Interno">
                                <ItemTemplate>
                                    <asp:Label ID="lblNroDespachointerno" runat="server" Text='<%# Eval("[Nro Despacho Interno]") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                            <asp:TemplateField HeaderText="Usuario">
                                <ItemTemplate>
                                    <asp:Label ID="lblUsuario" runat="server" Text='<%# Eval("[Usuario]") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Empresa">
                                <ItemTemplate>
                                    <asp:Label ID="lblEmpresa" runat="server" Text='<%# Eval("Empresa") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Cierre">
                                <ItemTemplate>
                                    <asp:Label ID="lblCierre" runat="server" Text='<%# Eval("Cierre") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Total">
                                <ItemTemplate>
                                    <asp:Label ID="lblTotal" runat="server" Text='<%# WerkUI.Core.Util.GetFormatedNumber(Eval("Total")) %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="IVA Gastos">
                                <ItemTemplate>
                                    <asp:Label ID="lblIvaGastos" runat="server" Text='<%# WerkUI.Core.Util.GetFormatedNumber(Eval("IVA Gastos")) %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="IVA Honorarios">
                                <ItemTemplate>
                                    <asp:Label ID="lblIvaHonorarios" runat="server" Text='<%# WerkUI.Core.Util.GetFormatedNumber(Eval("IVA Honorarios")) %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="IVA Retención">
                                <ItemTemplate>
                                    <asp:Label ID="lblIvaRetencion" runat="server" Text='<%# WerkUI.Core.Util.GetFormatedNumber(Eval("IVA Retención")) %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="IVA Retención Gastos">
                                <ItemTemplate>
                                    <asp:Label ID="lblIvaRetencionGastos" runat="server" Text='<%# WerkUI.Core.Util.GetFormatedNumber(Eval("IVA Retención Gastos")) %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="IVA Retención Honorarios">
                                <ItemTemplate>
                                    <asp:Label ID="lblIvaRetencionHonorarios" runat="server" Text='<%# WerkUI.Core.Util.GetFormatedNumber(Eval("IVA Retención Honorarios")) %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Fields>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    </asp:DetailsView>
                </p>
                <p>
                    <asp:SqlDataSource ID="LiquidacionesDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="SELECT LIQUIDACIONCABECERA.CODLIQUIDACION AS [Cod Liquidacion], LIQUIDACIONCABECERA.NUMLIQUIDACION AS [Nro Liquidacion], DESPACHO.NUMDESPACHO AS [Nro Despacho], DESPACHOINTERNO.NUMDESPACHOINTERNO AS [Nro Despacho Interno], LIQUIDACIONCABECERA.FECHALIQUIDACION AS Fecha, LIQUIDACIONCABECERA.IMPORTETOTAL AS Total, USUARIO.DESUSUARIO AS Usuario, EMPRESA.DESEMPRESA AS Empresa, LIQUIDACIONCABECERA.ESTADO AS Estado, LIQUIDACIONCABECERA.FECHACIERRE AS Cierre, LIQUIDACIONCABECERA.IMPORTEIVAGASTOS AS [IVA Gastos], LIQUIDACIONCABECERA.IMPORTEIVAHONORARIOS AS [IVA Honorarios], LIQUIDACIONCABECERA.PORRETENCIONIVA AS [IVA Retención], LIQUIDACIONCABECERA.RETIVAGASTOS AS [IVA Retención Gastos], LIQUIDACIONCABECERA.RETIVAHONORARIOS AS [IVA Retención Honorarios] FROM LIQUIDACIONCABECERA LEFT OUTER JOIN DESPACHOINTERNO ON LIQUIDACIONCABECERA.CODDESPACHOINTERNO = DESPACHOINTERNO.CODDESPACHOINTERNO LEFT OUTER JOIN USUARIO ON LIQUIDACIONCABECERA.CODUSUARIO = USUARIO.CODUSUARIO LEFT OUTER JOIN EMPRESA ON LIQUIDACIONCABECERA.CODEMPRESA = EMPRESA.CODEMPRESA LEFT OUTER JOIN DESPACHO ON LIQUIDACIONCABECERA.CODDESPACHO = DESPACHO.CODDESPACHO WHERE (LIQUIDACIONCABECERA.NUMLIQUIDACION = @p_num_liquidacion)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="LiquidacionesSearchTextBox" Name="p_num_liquidacion" PropertyName="Text" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </p>
            </div>
            <h3><a href="#">Detalles Liquidación</a></h3>
            <div>
                <p>
                    <asp:GridView ID="LiquidacionesDetallesGridView"
                        runat="server"
                        AutoGenerateColumns="False"
                        DataKeyNames="CODLIQUIDACION,SECUENCIAINTERNA"
                        DataSourceID="LiquidacionesDetallesSqlDataSource"
                        Font-Names="Segoe UI"
                        Font-Size="Small" Width="100%"
                        OnRowDataBound="LiquidacionesDetallesGridView_RowDataBound">
                        <Columns>
                            <asp:TemplateField HeaderText="Grupo ID.">
                                <ItemTemplate>
                                    <asp:Label ID="lblGrupo" runat="server" Text='<%# Eval("GRUPOIMPRESION") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="DESCONLIQUIDACION" HeaderText="Descripción" SortExpression="DESCONLIQUIDACION" />
                            <asp:TemplateField HeaderText="Importe">
                                <ItemTemplate>
                                    <asp:Label ID="lblImporte" runat="server" Text='<%# WerkUI.Core.Util.GetFormatedNumber(Eval("IMPORTE")) %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="COMENTARIO" HeaderText="Comentario" SortExpression="COMENTARIO" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="LiquidacionesDetallesSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="SELECT * FROM [LIQUIDACION] WHERE ([CODLIQUIDACION] = @CODLIQUIDACION) ORDER BY GRUPOIMPRESION" OnSelected="LiquidacionesDetallesSqlDataSource_Selected">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="dvwLiquidaciones" Name="CODLIQUIDACION" PropertyName="SelectedValue" Type="Decimal" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </p>
            </div>
        </div>

    </section>
</asp:Content>
