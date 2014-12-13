<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuscarClientes.aspx.cs" Inherits="WerkUI.Liquidacion.BuscarClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Busqueda de Clientes</title>
    <link href="~/Content/MetroUI.css" rel="stylesheet" />
    <link href="~/Content/Metro.css" rel="stylesheet" />
    <script language="javascript">
        function Seleccionar() {
            window.opener.location.href = "BuscarLiquidaciones.aspx";
            window.close();
        }

       
    </script>
</head>
    
<body>
    <form id="form1" runat="server">
    <div>
    <p>
        <asp:TextBox ID="ClienteTB" runat="server" Width="250px">%</asp:TextBox>
        <asp:Button ID="BuscarClienteButton" runat="server" Text="Buscar" OnClick="BuscarClienteButton_Click" CssClass="fg-color-blueDark" />
    </p>
    <p>
    <asp:GridView ID="ClientesGridView" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="Cod. Cliente" DataSourceID="ClientesSqlDataSource" Width="90%" CssClass="as-block" AllowSorting="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Font-Size="Small" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="ClientesGridView_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True"   SelectText="Seleccionar"/>
            <asp:BoundField DataField="Cod. Cliente" HeaderText="Cod. Cliente" ReadOnly="True" SortExpression="Cod. Cliente" />
            <asp:BoundField DataField="Cliente" HeaderText="Cliente" ReadOnly="True" SortExpression="Cliente" />
            <asp:BoundField DataField="R.U.C." HeaderText="R.U.C." SortExpression="R.U.C." />
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
        </p>
    <p>
        <asp:Button ID="SeleccionarClienteButton" runat="server" Text="Seleccionar" OnClick="SeleccionarClienteButton_Click" />
    </p>
    <p>
    <asp:SqlDataSource ID="ClientesSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="SELECT CODCLIENTE AS [Cod. Cliente], NUMCLIENTE AS [Nro. Cliente], RTRIM(LTRIM(APELLIDO)) + ', ' + RTRIM(LTRIM(NOMBRE)) AS Cliente, RUC AS [R.U.C.] FROM CLIENTES WHERE (APELLIDO LIKE '%' + @p_cliente + '%') OR (NOMBRE LIKE '%' + @p_cliente + '%')">
        <SelectParameters>
            <asp:ControlParameter ControlID="ClienteTB" Name="p_cliente" PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
        </p>
    </div>
    </form>
</body>
</html>
