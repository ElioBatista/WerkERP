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
        <div id="accordion" style="width:100%">

            <h3><a href="#">Búsqueda de Factura</a></h3>
            <div>

                <p>
                    <asp:Panel runat="server" DefaultButton="FacturaSearchButton">
                        <asp:TextBox ID="FacturaSearchTextBox" runat="server"></asp:TextBox>
                        <asp:Button ID="FacturaSearchButton" runat="server" Text="Buscar" OnClick="FacturaSearchButton_Click"></asp:Button>
                    </asp:Panel>
                    <asp:GridView ID="FacturasGridView" runat="server"  AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="cod_factura" DataSourceID="FacturacionDataSource" Font-Names="Verdana" Font-Size="XX-Small" OnRowCommand="GridView1_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="cod_factura" HeaderText="Cod." SortExpression="cod_factura" />
                            <asp:BoundField DataField="Nro. Factura" HeaderText="Nro. Factura" SortExpression="Nro. Factura" >
                            <ItemStyle Width="120px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Nro. Liquidación" HeaderText="Liq." InsertVisible="False" ReadOnly="True" SortExpression="Nro. Liquidación" />
                            
                            <asp:BoundField DataField="Nro. Despacho" HeaderText="Nro. Despacho" SortExpression="Nro. Despacho" />
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" DataFormatString="{0:d}" />
                            <asp:BoundField DataField="Total" HeaderText="Total" SortExpression="Total" DataFormatString="{0:#,#}" />
                            
                            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                            <asp:BoundField DataField="Cliente" HeaderText="Cliente" SortExpression="Cliente" />
                            <asp:BoundField DataField="Despachante" HeaderText="Despachante" SortExpression="Despachante" />
                            <asp:BoundField DataField="Tipo Factura" HeaderText="Tipo Factura" SortExpression="Tipo Factura" />
                            <asp:ButtonField CommandName="Imprimir" Text="Imprimir" HeaderText="Ver" />
                        </Columns>
                    </asp:GridView>
                </p>
                <p>
                    <asp:SqlDataSource ID="FacturacionDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>"
                        SelectCommand="sp_obtener_facturas" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="p_nro_factura" QueryStringField="num_factura" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </p>
            </div>

        </div>
    </section>
</asp:Content>
