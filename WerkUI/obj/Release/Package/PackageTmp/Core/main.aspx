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
                    Funciones y procedimientos relacionados con la facturación de las liquidaciones cerradas.
                </p>
                <p>
                    <asp:TextBox ID="IdFacturaTextBox" runat="server"></asp:TextBox>
                    <asp:Button ID="facturaSearchBtn" runat="server" CssClass="content-wrapper" Text="Buscar" PostBackUrl="~/Facturacion/buscar_factura.aspx" />
                </p>
                <section style="width:100%">
                    <hr />
                    <div  class="float-left" >                      
                        <a href="../Facturacion/BuscarFacturas.aspx">Búsqueda Avanzada</a>
                    </div>                    
                </section>


            </div>

            <h3><a href="#">Liquidaciones</a></h3>
            <div>
                <p>
                    Funciones y procedimientos para la generación de liquidaciones de servicios y costos del despacho.
                </p>
                <p>
                    <asp:TextBox ID="NumLiquidacionTexBox" runat="server"></asp:TextBox>
                    <asp:Button ID="LiquidacionSearchBtn" runat="server" CssClass="content-wrapper" Text="Buscar" OnClick="LiquidacionSearchBtn_Click" />
                </p>
                <div style="float:left ; width:300px">
                    <a href="../Liquidacion/BuscarLiquidaciones.aspx">Búsqueda avanzada</a>
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
