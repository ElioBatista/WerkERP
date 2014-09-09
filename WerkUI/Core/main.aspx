<%@ Page Title="Werk | Menu Principal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="WerkUI.Core.main" %>

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
    <section runat="server" id="BlocksForm">

        <div id="accordion">

            <h3><a href="#">Facturación</a></h3>
            <div>
                <p>
                    <asp:Panel runat="server" DefaultButton="facturaSearchBtn" ID="FacturacionesPanel">
                        <asp:TextBox ID="NroFacturaTextBox" runat="server"></asp:TextBox>
                        <asp:Button ID="facturaSearchBtn" runat="server" CssClass="content-wrapper" Text="Buscar" OnClick="facturaSearchBtn_Click" />
                    </asp:Panel>
                </p>
                <div id="FaturacionLefPanel" class="float-left" width="50%">
                    <label runat="server" style="font-size: small">Reportes gerenciales</label>
                    <hr />
                    <div style="float: left; width: 300px">
                        <a href="http://10.10.10.150/ReportServer/Pages/ReportViewer.aspx?%2fSallustroSSRS%2fFacturacion&rs:Command=Render" target="_blank" style="font-size: small">Facturación</a>
                    </div>
		
<div style="float: left; width: 300px">
                        <a href="http://10.10.10.150/ReportServer/Pages/ReportViewer.aspx?%2fSallustroSSRS%2fCheque&rs:Command=Render" target="_blank" style="font-size: small">Imprimir Cheque</a>
                    </div>
                </div>

            </div>
            <h3><a href="#">Liquidaciones</a></h3>
            <div>
                <p>
                    <asp:Panel DefaultButton="LiquidacionSearchBtn" runat="server" ID="LiquidacionesPanel">
                        <asp:TextBox ID="NumLiquidacionTexBox" runat="server"></asp:TextBox>
                        <asp:Button ID="LiquidacionSearchBtn" runat="server" CssClass="content-wrapper" Text="Buscar" OnClick="LiquidacionSearchBtn_Click" />
                    </asp:Panel>
                </p>
                <div id="LiquidacionLeftPanel" class="float-left" width="50%">
                    <label id="Label1" runat="server" style="font-size: small">Herramientas</label>
                    <hr />
                <div style="float: left; width: 300px">
                    <a href="../Liquidacion/BuscarLiquidaciones.aspx" style="font-size: small">Búsqueda avanzada</a>
                </div>
                    </div>
            </div>
            <h3><a href="#">Contabilidad</a></h3>
            <div>
                <p>
                    Funciones y procedimientos para la generación de asientos contables, así como los libros contables y plan de cuentas.
                </p>
            </div>
            <h3><a href="#">Despachos</a></h3>
            <div>
                <p>
                    Funciones y procedimientos para la administración de los despachos aduaneros.
                </p>
            </div>
            <h3><a href="#">Bancos</a></h3>
            <div>
                <p>
                    Funciones y procedimientos para la administración de cuentas bancarias, pagos y cobros electrónicos.
                </p>
            </div>
            <h3><a href="#">Caja</a></h3>
            <div>
                <p>
                    Funciones y procedimientos para la administración de caja, cobros y pagos en ventanilla.
                </p>
            </div>
            <h3><a href="#">Seguridad</a></h3>
            <div>
                <p>
                    Funciones y procedimientos para la administración de usuarios, roles y permisos del sistema.
                </p>
            </div>
        </div>

    </section>
    <section>
        <asp:Label runat="server" ID="lblJavaScript" Visible="false"></asp:Label>
    </section>
</asp:Content>
