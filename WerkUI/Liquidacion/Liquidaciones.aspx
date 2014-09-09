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
                    <asp:Panel runat="server" ID="LiquidacionesPanel" DefaultButton="LiquidacionSearchButton">
                    <asp:TextBox ID="LiquidacionesSearchTextBox" runat="server"></asp:TextBox>
                    <asp:Button ID="LiquidacionSearchButton" runat="server" Text="Buscar" 
                        onclick="LiquidacionSearchButton_Click"></asp:Button>
                        </asp:Panel>

                    <asp:DetailsView ID="dvwLiquidaciones" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Cod Liquidacion" DataSourceID="LiquidacionesDataSource" Font-Names="Segoe UI" Font-Size="Small" ForeColor="Black" GridLines="Horizontal" Height="50px" Width="500px">
                        <EditRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <Fields>
                            <asp:BoundField DataField="Cod Liquidacion" HeaderText="Cod Liquidacion" SortExpression="Cod Liquidacion" ReadOnly="True" />
                            <asp:BoundField DataField="Nro Liquidacion" HeaderText="Nro Liquidacion" SortExpression="Nro Liquidacion" />
                            <asp:BoundField DataField="Nro Despacho" HeaderText="Nro Despacho" SortExpression="Nro Despacho" />
                            <asp:BoundField DataField="Nro Despacho Interno" HeaderText="Nro Despacho Interno" SortExpression="Nro Despacho Interno" />
                            <asp:BoundField DataField="Fecha" DataFormatString="{0:d}" HeaderText="Fecha" SortExpression="Fecha" />
                
                            <asp:BoundField DataField="Usuario" HeaderText="Usuario" SortExpression="Usuario" />
                            <asp:BoundField DataField="Empresa" HeaderText="Empresa" ReadOnly="True" SortExpression="Empresa" />
                            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                            <asp:BoundField DataField="Cierre" DataFormatString="{0:d}" HeaderText="Cierre" SortExpression="Cierre" />
                            <asp:BoundField DataField="Total" HeaderText="Total" SortExpression="Total" DataFormatString="{0:#,#}"/>
                            <asp:BoundField DataField="IVA Gastos" HeaderText="IVA Gastos" SortExpression="IVA Gastos" DataFormatString="{0:#,#}" />
                            <asp:BoundField DataField="IVA Honorarios" HeaderText="IVA Honorarios" SortExpression="IVA Honorarios" DataFormatString="{0:#,#}"/>
                            <asp:BoundField DataField="IVA Retención" HeaderText="IVA Retención" SortExpression="IVA Retención" DataFormatString="{0:#,#}"/>
                            <asp:BoundField DataField="IVA Retención Gastos" HeaderText="IVA Retención Gastos" SortExpression="IVA Retención Gastos" DataFormatString="{0:#,#}"/>
                            <asp:BoundField DataField="IVA Retención Honorarios" HeaderText="IVA Retención Honorarios" SortExpression="IVA Retención Honorarios" DataFormatString="{0:#,#}"/>
                            <asp:BoundField DataField="Despachante" HeaderText="Despachante" ReadOnly="True" SortExpression="Despachante" />
                        </Fields>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    </asp:DetailsView>
                </p>
                <p>
                    <asp:SqlDataSource ID="LiquidacionesDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="SELECT LIQUIDACIONCABECERA.CODLIQUIDACION AS [Cod Liquidacion], LIQUIDACIONCABECERA.NUMLIQUIDACION AS [Nro Liquidacion], DESPACHO.NUMDESPACHO AS [Nro Despacho], DESPACHOINTERNO.NUMDESPACHOINTERNO AS [Nro Despacho Interno], LIQUIDACIONCABECERA.FECHALIQUIDACION AS Fecha, LIQUIDACIONCABECERA.IMPORTETOTAL AS Total, USUARIO.DESUSUARIO AS Usuario, CLIENTES.APELLIDO + ', ' + CLIENTES.NOMBRE AS Empresa, LIQUIDACIONCABECERA.ESTADO AS Estado, LIQUIDACIONCABECERA.FECHACIERRE AS Cierre, LIQUIDACIONCABECERA.IMPORTEIVAGASTOS AS [IVA Gastos], LIQUIDACIONCABECERA.IMPORTEIVAHONORARIOS AS [IVA Honorarios], LIQUIDACIONCABECERA.PORRETENCIONIVA AS [IVA Retención], LIQUIDACIONCABECERA.RETIVAGASTOS AS [IVA Retención Gastos], LIQUIDACIONCABECERA.RETIVAHONORARIOS AS [IVA Retención Honorarios], RTRIM(LTRIM(DESPACHANTE.APELLIDO)) + ', ' + RTRIM(LTRIM(DESPACHANTE.NOMBRE)) AS Despachante FROM DESPACHANTE RIGHT OUTER JOIN DESPACHOINTERNO ON DESPACHANTE.CODDESPACHANTE = DESPACHOINTERNO.CODDESPACHANTE RIGHT OUTER JOIN LIQUIDACIONCABECERA ON DESPACHOINTERNO.CODDESPACHOINTERNO = LIQUIDACIONCABECERA.CODDESPACHOINTERNO LEFT OUTER JOIN USUARIO ON LIQUIDACIONCABECERA.CODUSUARIO = USUARIO.CODUSUARIO LEFT OUTER JOIN EMPRESA ON LIQUIDACIONCABECERA.CODEMPRESA = EMPRESA.CODEMPRESA LEFT OUTER JOIN DESPACHO ON LIQUIDACIONCABECERA.CODDESPACHO = DESPACHO.CODDESPACHO LEFT OUTER JOIN CLIENTES ON DESPACHOINTERNO.CODCLIENTE = CLIENTES.CODCLIENTE WHERE (LIQUIDACIONCABECERA.NUMLIQUIDACION = @p_num_liquidacion)">
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
                <p>
                    <asp:DetailsView ID="TotalesDetailsView" runat="server" Height="50px" Width="593px" AutoGenerateRows="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Cod Liquidacion" DataSourceID="LiquidacionesDataSource" ForeColor="Black" GridLines="Horizontal">
                        <EditRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <Fields>
                            <asp:BoundField DataField="Total" DataFormatString="{0:0,#}" HeaderText="Total" SortExpression="Total" />
                            <asp:BoundField DataField="IVA Gastos" DataFormatString="{0:0,#}" HeaderText="IVA Gastos" SortExpression="IVA Gastos" />
                            <asp:BoundField DataField="IVA Honorarios" DataFormatString="{0:0,#}" HeaderText="IVA Honorarios" SortExpression="IVA Honorarios" />
                            <asp:BoundField DataField="IVA Retención" DataFormatString="{0:0,#}" HeaderText="IVA Retención" SortExpression="IVA Retención" />
                            <asp:BoundField DataField="IVA Retención Gastos" DataFormatString="{0:0,#}" HeaderText="IVA Retención Gastos" SortExpression="IVA Retención Gastos" />
                            <asp:BoundField DataField="IVA Retención Honorarios" DataFormatString="{0:0,#}" HeaderText="IVA Retención Honorarios" SortExpression="IVA Retención Honorarios" />
                        
                        </Fields>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    </asp:DetailsView>

                </p>
            </div>
        </div>

    </section>
</asp:Content>
