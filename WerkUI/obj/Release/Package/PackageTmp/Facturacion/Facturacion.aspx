<%@ Page Title="Werk | Facturación" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Facturacion.aspx.cs" Inherits="WerkUI.Facturacion.Facturacion" %>

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
        <div id="accordion">

            <h3><a href="#">Búsqueda de Factura</a></h3>
            <div>

                <p>
                    <asp:TextBox ID="FacturaSearchTextBox" runat="server"></asp:TextBox>
                    <asp:Button ID="FacturaSearchButton" runat="server" Text="Buscar"></asp:Button>
                    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="FacturacionDataSource" Font-Names="Segoe UI" Font-Size="Small" ForeColor="Black" GridLines="Horizontal" Height="50px" Width="500px">
                        <EditRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <Fields>
                            
                        </Fields>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    </asp:DetailsView>
                </p>
                <p>
                    <asp:SqlDataSource ID="FacturacionDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" 
                        SelectCommand="SELECT LIQUIDACIONCABECERA.CODLIQUIDACION AS [Cod. Liquidación], LIQUIDACIONCABECERA.NUMLIQUIDACION AS [Nro. Liquidación], DESPACHO.NUMDESPACHO AS [Nro. Despacho], DESPACHOINTERNO.NUMDESPACHOINTERNO AS [Nro. Despacho Interno], LIQUIDACIONCABECERA.FECHALIQUIDACION AS Fecha, LIQUIDACIONCABECERA.IMPORTETOTAL AS Total, USUARIO.DESUSUARIO AS Usuario, EMPRESA.DESEMPRESA AS Empresa, LIQUIDACIONCABECERA.ESTADO AS Estado, LIQUIDACIONCABECERA.FECHACIERRE AS Cierre, LIQUIDACIONCABECERA.IMPORTEIVAGASTOS AS [IVA Gastos], LIQUIDACIONCABECERA.IMPORTEIVAHONORARIOS AS [IVA Honorarios], LIQUIDACIONCABECERA.PORRETENCIONIVA AS [IVA Retención], LIQUIDACIONCABECERA.RETIVAGASTOS AS [IVA Ret. Gastos], LIQUIDACIONCABECERA.RETIVAHONORARIOS AS [IVA Ret. Honorarios] FROM LIQUIDACIONCABECERA LEFT OUTER JOIN DESPACHOINTERNO ON LIQUIDACIONCABECERA.CODDESPACHOINTERNO = DESPACHOINTERNO.CODDESPACHOINTERNO LEFT OUTER JOIN USUARIO ON LIQUIDACIONCABECERA.CODUSUARIO = USUARIO.CODUSUARIO LEFT OUTER JOIN EMPRESA ON LIQUIDACIONCABECERA.CODEMPRESA = EMPRESA.CODEMPRESA LEFT OUTER JOIN DESPACHO ON LIQUIDACIONCABECERA.CODDESPACHO = DESPACHO.CODDESPACHO WHERE (LIQUIDACIONCABECERA.NUMLIQUIDACION = @p_num_liquidacion)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="FacturaSearchTextBox" Name="p_num_liquidacion" PropertyName="Text" />
                        </SelectParameters>
                    </asp:SqlDataSource>                    
                </p>
            </div>
            <h3><a href="#">Detalles Liquidación</a></h3>
            <div>
                <p>
                    <asp:GridView ID="FacturaDetallesGridView"
                        runat="server"
                        AutoGenerateColumns="False"
                        DataSourceID="FacturacionDetallesDataSource"
                        Font-Names="Segoe UI"
                        Font-Size="Small" Width="100%"
                       >
                    </asp:GridView>
                    <asp:SqlDataSource ID="FacturacionDetallesDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="SELECT [cod_factura], [secuencia_interna], [comentario], [cod_con_liquidacion], [descripcion], [grupo_impresion], [importe] FROM [Facturacion].[FacturaDetalles] WHERE ([cod_factura] = @cod_factura)" >
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DetailsView1" Name="cod_factura" PropertyName="SelectedValue" Type="Decimal" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </p>
            </div>
        </div>
    </section>
</asp:Content>
