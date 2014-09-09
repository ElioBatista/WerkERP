<%@ Page Title="Solicitar Orden Pago" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrdenPago.aspx.cs" Inherits="WerkUI.OrdenPago.OrdenPago" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
   ¨<div id="OrdenPagoMainDiv" style="width:100%">
       <div id="OPSearch">

           <asp:TextBox ID="NroOrdenPagoTB" runat="server"></asp:TextBox>
           <asp:Button ID="SearchOPBtn" runat="server" Text="Buscar" />

       </div>
       <div id="OPDetails">

           <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObtenerOrdenPagoDS" ForeColor="#333333" GridLines="None">
               <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
               <Columns>
                   <asp:BoundField DataField="NroOrdenPago" HeaderText="Nro OP" SortExpression="NroOrdenPago" />
                   <asp:BoundField DataField="NUMDESPACHOINTERNO" HeaderText="DI" SortExpression="NUMDESPACHOINTERNO" />
                   <asp:BoundField DataField="NOMBRE" HeaderText="Nombres" SortExpression="NOMBRE" />
                   <asp:BoundField DataField="APELLIDO" HeaderText="Apellidos" SortExpression="APELLIDO" />
                   <asp:BoundField DataField="DESTIPOPAGO" HeaderText="Tipo Pago" SortExpression="DESTIPOPAGO" />
                   <asp:BoundField DataField="DESPROPOSITO" HeaderText="Proposito" SortExpression="DESPROPOSITO" />
                   <asp:BoundField DataField="IMPORTE" HeaderText="Importe" SortExpression="IMPORTE" />
                   <asp:BoundField DataField="FECHAPRESENTACION" DataFormatString="{0:d}" HeaderText="Presentación" SortExpression="FECHAPRESENTACION" />
                   <asp:BoundField DataField="FECHARETIRO" DataFormatString="{0:d}" HeaderText="Retiro" SortExpression="FECHARETIRO" />
                   <asp:BoundField DataField="OBSERVACION" HeaderText="Observaciones" SortExpression="OBSERVACION" />
               </Columns>
               <EditRowStyle BackColor="#999999" />
               <EmptyDataTemplate>
                   <asp:Button ID="SolicitarOPBtn" runat="server" OnClick="SolicitarOPBtn_Click" Text="Solicitar OP" />
               </EmptyDataTemplate>
               <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
               <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
               <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
               <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
               <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
               <SortedAscendingCellStyle BackColor="#E9E7E2" />
               <SortedAscendingHeaderStyle BackColor="#506C8C" />
               <SortedDescendingCellStyle BackColor="#FFFDF8" />
               <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
           </asp:GridView>
           <asp:SqlDataSource ID="ObtenerOrdenPagoDS" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="sp_obtener_orden_pago" SelectCommandType="StoredProcedure">
               <SelectParameters>
                   <asp:ControlParameter ControlID="NroOrdenPagoTB" Name="NroOrdenPago" PropertyName="Text" Type="Int64" />
               </SelectParameters>
           </asp:SqlDataSource>

       </div>
       
       
       <div id="OPNewRequest">

           <asp:FormView ID="OPFormView" runat="server"></asp:FormView>

       </div>
    </div>
</asp:Content>
