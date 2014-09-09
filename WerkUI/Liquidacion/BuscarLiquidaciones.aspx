<%@ Page Title="Werk | Búsqueda de Liquidaciones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuscarLiquidaciones.aspx.cs" Inherits="WerkUI.Liquidacion.BuscarLiquidaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">    
    
    <script src="/Scripts/jquery.maskedinput.js" type="text/javascript"></script>
    <script type="text/javascript">

        jQuery(function ($) {
            $("#FechaDesdeTB").mask("99/99/9999");
            $("#FechaHastaTB").mask("99/99/9999");
            $("#phone").mask("(999) 999-9999");
            $("#tin").mask("99-9999999");
            $("#ssn").mask("999-99-9999");
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div style="float: left; width: 35%">
        <asp:Panel runat="server" ID="SearchPanel" DefaultButton="BuscarLiquidacionBtn">
            <h3>Búsqueda Avanzada de Liquidaciones</h3>
            <p>
                <label runat="server" id="NroLabel" style="font-size:small">Nro. Liquidación</label>
                <asp:TextBox ID="NumLiquidacionTB" runat="server"></asp:TextBox>
                
                <label runat="server" id="DespachoInternoLabel"  style="font-size:small">Despacho interno</label>
                <asp:TextBox ID="DespachoInternoTB" runat="server"></asp:TextBox>
                
                <label runat="server" id="Label1"  style="font-size:small">Cliente</label>
                <asp:DropDownList ID="ClienteDDL" runat="server" AutoPostBack="True" DataSourceID="ClientesDS" DataTextField="Cliente" DataValueField="Valor" Width="310px"></asp:DropDownList>
                <asp:SqlDataSource ID="ClientesDS" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="SELECT RTRIM(LTRIM(NOMBRE)) + RTRIM(LTRIM(APELLIDO)) AS Cliente, CODCLIENTE AS Valor, 1 AS Orden FROM CLIENTES UNION SELECT 'TODOS' AS Cliente, NULL AS Valor, - 1 AS Orden ORDER BY Orden, Cliente"></asp:SqlDataSource>
                <label runat="server" id="DespachanteLabel"  style="font-size:small">Despachante</label>
                <asp:DropDownList ID="DespachanteDD" runat="server" DataSourceID="DespachantesDS" DataTextField="Despachante" DataValueField="Valor" Width="310px" AutoPostBack="True"></asp:DropDownList>
                <asp:SqlDataSource ID="DespachantesDS" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="SELECT RTRIM(LTRIM(APELLIDO)) + ', ' + RTRIM(LTRIM(NOMBRE)) AS Despachante, CODDESPACHANTE AS Valor, 1 AS Orden FROM DESPACHANTE UNION SELECT 'TODOS' AS Despachante, NULL AS Valor, - 1 AS Orden
ORDER BY Orden"></asp:SqlDataSource>
                <label runat="server" id="FechaDesdeLabel"  style="font-size:small">Desde</label>                
                <asp:TextBox ID="FechaDesdeTB" runat="server" Width="200px" Enabled="True" ClientIDMode="Static"></asp:TextBox>
                <asp:Button ID="FechaDesdeBTN" runat="server"  Text="..." OnClick="FechaDesdeBTN_Click" UseSubmitBehavior="False" />
                <asp:Calendar ID="FechaDesdeCal" runat="server" Visible="False" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="7pt" ForeColor="Black" Height="170px" NextPrevFormat="FullMonth" Width="300px" OnSelectionChanged="FechaDesdeCal_SelectionChanged">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="8pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            
                <label runat="server" id="FechaHastaLabel"  style="font-size:small">Hasta</label>
                <asp:TextBox ID="FechaHastaTB" runat="server" Width="200px" Enabled="True" ClientIDMode="Static"></asp:TextBox>
                <asp:Button ID="FechaHastaBTN" runat="server"  Text="..." OnClick="FechaHastaBTN_Click" UseSubmitBehavior="False" />
                <asp:Calendar ID="FechaHastaCal" runat="server" Visible="False" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="170px" NextPrevFormat="FullMonth" Width="300px" OnSelectionChanged="FechaHastaCal_SelectionChanged">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="8pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            </p>
            <p>
                <asp:Button ID="BuscarLiquidacionBtn" runat="server" Text="Buscar" OnClick="BuscarLiquidacionBtn_Click"  />
                <asp:Button ID="LimpiarCamposBtn" runat="server" Text="Limpiar" OnClick="LimpiarCamposBtn_Click" />
            </p>
        </asp:Panel>
    </div>
    <div style="float: right; text-align: left; width: 65%">
        <h3>Resultado de la búsqueda</h3>

        <asp:GridView ID="LiquidacionesGrivView" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Cod. Liquidación" DataSourceID="LiquidacionesDataSource" ForeColor="Black" GridLines="Horizontal" Width="100%" Font-Names="Segoe UI" Font-Size="Smaller" EmptyDataText="No se encontraron registros." AllowSorting="True">
            <Columns>
                <asp:HyperLinkField DataTextField="Nro. Liquidación" DataNavigateUrlFields="DetailURL" HeaderText="Nro. Liquidación" SortExpression="Nro. Liquidación" />
<asp:HyperLinkField DataTextField="Nro. Liquidación" DataNavigateUrlFields="PdfURL" HeaderText="Legajo" SortExpression="Pdf" />                                
<asp:BoundField DataField="Nro. Despacho" HeaderText="Despacho" SortExpression="Nro. Despacho" />
                <asp:BoundField DataField="Nro. Despacho Interno" HeaderText="Despacho Interno" SortExpression="Nro. Despacho Interno" />
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" DataFormatString="{0:d}" />
                <asp:BoundField DataField="Cliente" HeaderText="Cliente" SortExpression="Cliente" />
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
        <asp:SqlDataSource ID="LiquidacionesDataSource" runat="server" CancelSelectOnNullParameter="false" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="sp_buscar_liquidaciones" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="NumLiquidacionTB" DefaultValue="" Name="p_liquidacion" PropertyName="Text" Type="Int32" />
                <asp:ControlParameter ControlID="DespachoInternoTB" Name="p_despacho_interno" PropertyName="Text" Type="String" />
                <asp:ControlParameter ControlID="ClienteDDL" Name="p_cliente" PropertyName="SelectedValue" Type="Int32" />
                <asp:ControlParameter ControlID="DespachanteDD" Name="p_despachante" PropertyName="SelectedValue" Type="Int32" />
                <asp:ControlParameter ControlID="FechaDesdeTB" Name="p_desde" PropertyName="Text" Type="DateTime" />
                <asp:ControlParameter ControlID="FechaHastaTB" Name="p_hasta" PropertyName="Text" Type="DateTime" />
            </SelectParameters>
        </asp:SqlDataSource>

    </div>
    <script type="text/javascript" language="javascript">
        function checkFieldsSearch() {
            var nroLiqui = $get('<%= NumLiquidacionTB.ClientID %>');
            
            var despInt = $get('<%= DespachoInternoTB.ClientID %>');
            
          
            var desde = $get('<%= FechaDesdeTB.ClientID %>');
            var hasta = $get('<%= FechaHastaTB.ClientID %>');


            if (nroLiqui.value == '' && despInt.value == '' && desde.value == '' && hasta.value == '') {
                alert('Seleccione al menos un parámetro de búsqueda');
                return false;
            }
            else {
                return true;
            }


        }
    </script>
</asp:Content>
