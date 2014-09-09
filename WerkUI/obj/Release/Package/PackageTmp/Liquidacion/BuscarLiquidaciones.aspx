<%@ Page Title="Werk | Búsqueda de Liquidaciones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuscarLiquidaciones.aspx.cs" Inherits="WerkUI.Liquidacion.BuscarLiquidaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div style="float:left; width:35%">
        <h3>Búsqueda Avanzada de Liquidaciones</h3>
        <p>
            <label  runat="server" id="NroLabel" >Nro. Liquidación</label>
            <asp:TextBox ID="NumLiquidacionTB" runat="server"></asp:TextBox>
          
            <label  runat="server" id="FechaLabel" >Fecha Liquidación</label>
            <asp:TextBox ID="FechaLiquidacionTB" runat="server"></asp:TextBox>
            <label  runat="server" id="DespachoInternoLabel" >Despacho interno</label>
            <asp:TextBox ID="DespachoInternoTB" runat="server"></asp:TextBox>
            <label  runat="server" id="ClienteLable" >Cliente</label>
            <asp:TextBox ID="ClienteTB" runat="server"></asp:TextBox>
        </p>
       <p>
           <asp:Button ID="BuscarLiquidacionBtn" runat="server" Text="Buscar" OnClick="BuscarLiquidacionBtn_Click" OnClientClick="javascript:if (checkFieldsSearch()) return true; else return false;" />
           &nbsp;
           <asp:Button ID="LimpiarCamposBtn" runat="server" Text="Limpiar" 
               onclick="LimpiarCamposBtn_Click"/>
       </p>
        
    </div>
    <div style="float:right; text-align:left ; width:65%">
        <h3>Resultado de la búsqueda</h3>
        
            <asp:GridView ID="LiquidacionesGrivView" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Cod. Liquidación" DataSourceID="LiquidacionesDataSource" ForeColor="Black" GridLines="Horizontal" Width="100%" Font-Names="Segoe UI" Font-Size="Smaller" EmptyDataText="No se encontraron registros." AllowSorting="True">
                <Columns>                    
                    <asp:HyperLinkField  DataTextField="Nro. Liquidación" DataNavigateUrlFields="DetailURL" HeaderText="Nro. Liquidación" SortExpression="Nro. Liquidación"/>                    
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
            <asp:SqlDataSource ID="LiquidacionesDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="sp_buscar_liquidaciones" SelectCommandType="StoredProcedure">
            </asp:SqlDataSource>
       
    </div>
    <script type="text/javascript" language="javascript">
        function checkFieldsSearch() {
            var nroLiqui = $get('<%= NumLiquidacionTB.ClientID %>');
            var fechaLiqui = $get('<%= FechaLiquidacionTB.ClientID %>');
            var despInt = $get('<%= DespachoInternoTB.ClientID %>');
            var cliente = $get('<%= ClienteTB.ClientID %>');

            if (nroLiqui.value == '' && fechaLiqui.value == '' && despInt.value == '' && cliente.value == '') {
                alert('Seleccione al menos un parámetro de búsqueda');
                return false;
            }
            else {
                return true;
            }

         
        }
    </script>
</asp:Content>
