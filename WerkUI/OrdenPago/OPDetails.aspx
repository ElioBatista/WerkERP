<%@ Page Title="Aprobación de OP" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OPDetails.aspx.cs" Inherits="WerkUI.OrdenPago.OPDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="upnlSolicitudesOP" runat="server">

        <ContentTemplate>
            <div class="site-title">
                <asp:Label ID="lblSiteTitle" runat="server" Visible="True" CssClass="main-content" Text="Detalle de Orden de Pago" />
            </div>
            <div>
                <asp:Label ID="ErrorLabel" runat="server" Visible="False" CssClass="field-validation-error" />
            </div>
            <asp:ListView ID="RequestOPDetailsListView" runat="server"
                ItemType="WerkUI.Models.SolicitudOrdenPagoDetalle" DataKeyNames="id_solicitud_orden_pago_detalle"
                SelectMethod="GetRequestOPDetails"
                UpdateMethod="UpdateRequestOPDetail"
                InsertMethod="InsertRequestOPDetail"
                DeleteMethod="DeleteRequestOPDetail"
                InsertItemPosition="LastItem"
                OnItemCanceling="RequestOPDetailsListView_ItemCanceling"
                OnItemEditing="RequestOPDetailsListView_ItemEditing">
                <LayoutTemplate>
                    <div class="table responsive">
                        <table class="table table-striped">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Nro. DI</th>
                                    <th class="text-center">Concepto</th>
                                    <th class="text-center">Monto</th>
                                    <th class="text-center">Monto Aprobado</th>
                                    <th class="text-center">Observaciones</th>
                                   

                                    <th>&nbsp;</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr runat="server" id="itemPlaceholder" />
                            </tbody>
                        </table>
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td style="width: 30px">
                            <asp:CheckBox ID="chkConcept" runat="server" />
                        </td>
                        <td style="width: 40px">
                            <asp:Label ID="lblNroDI" runat="server" Text='<%# GetDIClient( Item.nro_despacho_interno.ToString())%>' />
                        </td>
                        <td style="width: 200px">
                            <asp:Label ID="lblConcepto" runat="server" Text='<%#  GetConceptByNumber(Item.nro_concepto) %>' />
                        </td>
                        <td style="width: 60px">
                            <asp:Label ID="lblImporte" runat="server" Text='<%# WerkUI.Core.Util.GetFormatedNumber(Item.importe) %>' />
                        </td>
                        <td style="width: 60px">
                            <asp:Label ID="lblImporteAprobado" runat="server" Text='<%# WerkUI.Core.Util.GetFormatedNumber(Item.importe_aprobado) %>' />
                        </td>
                        <td style="width: 200px">
                            <asp:Label ID="lblObservacion" runat="server" Text='<%# Item.observacion %>' />
                        </td>

                        <td class="text-right">
                            <asp:Button ID="EditButton" runat="server" Text="Editar" CommandName="Edit" />
                            <asp:Button ID="DeleteButton" runat="server" Text="Borrar" CommandName="Delete" />
                        </td>
                        <td style="width: 200px">
                            <asp:Label ID="lblID" runat="server" Text='<%# Item.id_solicitud_orden_pago_detalle %>' Visible="false" />
                        </td>
                    </tr>
                </ItemTemplate>
                <EditItemTemplate>
                    <tr>
                        <td>#</td>
                        <td >
                            <asp:TextBox ID="txtNroDI" runat="server" Text='<%# BindItem.nro_despacho_interno%>' CssClass="form-control" Width="50px"  />
                        </td>
                        <td >
                            <asp:TextBox ID="txtConcepto" runat="server" Text='<%# BindItem.nro_concepto%>' CssClass="form-control" Width="50px"  />
                        </td>
                        <td >
                            <asp:TextBox ID="txtImporte" runat="server" Text='<%# BindItem.importe %>' CssClass="form-control" Width="50px"  />
                        </td>
                        <td >
                            <asp:TextBox ID="txtImporteAprobado" runat="server" Text='<%# BindItem.importe_aprobado%>' CssClass="form-control" Width="50px"  />
                        </td>
                        <td >
                            <asp:TextBox ID="txtObservacion" runat="server" Text='<%# BindItem.observacion%>' CssClass="form-control" Width="300px"  />
                        </td>

                        <td class="text-right">
                            <asp:Button ID="UpdateButton" runat="server" Text="Guardar" CommandName="Update" CssClass="btn btn-info" />
                            <asp:Button ID="CancelButton" runat="server" Text="Cancelar" CommandName="Cancel" CssClass="btn" />
                        </td>
                    </tr>
                </EditItemTemplate>
                <InsertItemTemplate>

                    <tr>
                        <td>#</td>
                        <td>
                            <asp:TextBox ID="txtNroDI" runat="server" Text='<%# BindItem.nro_despacho_interno%>' CssClass="form-control" Width="40px" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtConcepto" runat="server" Text='<%# BindItem.nro_concepto%>' CssClass="form-control" Width="200px" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtImporte" runat="server" Text='<%# BindItem.importe%>' CssClass="form-control" Width="50px" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtImporteAprobado" runat="server" Text='<%# BindItem.importe_aprobado%>' CssClass="form-control" Width="50px" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtObservacion" runat="server" Text='<%# BindItem.observacion%>' CssClass="form-control" Width="200px" />
                        </td>
                        <td class="text-right">
                            <asp:Button ID="InsertButton" runat="server" Text="Agregar" CommandName="Insert" CssClass="btn btn-success" />
                        </td>
                    </tr>

                </InsertItemTemplate>


            </asp:ListView>

            <asp:DataPager ID="RequestOPDetailsDataPager" runat="server" PagedControlID="RequestOPDetailsListView" PageSize="5">
                <Fields>
                    <asp:NextPreviousPagerField ButtonCssClass="btn btn-default btn-sm" ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                    <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="btn btn-sm" NextPreviousButtonCssClass="btn btn-default btn-sm" NumericButtonCssClass="btn btn-default btn-sm" />
                    <asp:NextPreviousPagerField ButtonCssClass="btn btn-default btn-sm" ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                </Fields>
            </asp:DataPager>

        </ContentTemplate>

    </asp:UpdatePanel>
    <hr />
    <asp:UpdatePanel ID="upnlConceptosPorCheque" runat="server">
        <ContentTemplate>
            <div>
                <asp:Label ID="lblCheques" runat="server" Text="Asignación de cheques" Font-Size="XX-Large" />
                <div class="ui-corner-left">
                    <asp:Label ID="lblBanco" runat="server" Text="Banco" Font-Size="Large" Width="150px"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;                    
                    <asp:DropDownList ID="ddlBancos" runat="server" SelectMethod="GetBanks" DataTextField="banco1" DataValueField="id_banco" AppendDataBoundItems="true" CssClass="ui-widget" AutoPostBack="True" OnSelectedIndexChanged="ddlBancos_SelectedIndexChanged" >
                    </asp:DropDownList>
                </div>
                <div class="ui-corner-left">
                    <asp:Label ID="lblChequera" runat="server" Text="Chequera" Font-Size="Large" Width="150px"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;                    
                    <asp:DropDownList ID="ddlCheqeras" runat="server" SelectMethod="GetChequeras" DataTextField="nro_talon" DataValueField="id_chequera" AppendDataBoundItems="true" CssClass="ui-widget" AutoPostBack="True">
                    </asp:DropDownList>
                </div>
                <div class="ui-corner-left">
                    <asp:Label ID="lblCheque" runat="server" Text="Cheque Nro." Font-Size="Large" Width="150px"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;                    
                    <asp:DropDownList ID="ddlCheques" runat="server" SelectMethod="GetChecks" DataTextField="nro_cheque" DataValueField="id_cheque" AppendDataBoundItems="true" CssClass="ui-widget" AutoPostBack="True">
                    </asp:DropDownList>
                </div>
            </div>
            <div>
                <asp:Button ID="AsignarChequeBtn" runat="server" Text="Asignar Cheque" OnClick="AsignarChequeBtn_Click" />
            </div>
            <div>
                <asp:GridView ID="ChequesAsignadosGridView" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ChequesAsignados" ForeColor="Black" GridLines="Horizontal" AutoGenerateColumns="False" OnRowDataBound="ChequesAsignadosGridView_RowDataBound" OnRowCommand="ChequesAsignadosGridView_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="id_solicitud_orden_pago_detalle" HeaderText="Id." SortExpression="id_solicitud_orden_pago_detalle" />
                         <asp:TemplateField HeaderText="Cheque Nro.">
                                <ItemTemplate>
                                    <asp:Label ID="lblGrupo" runat="server" Text='<%# Eval("nro_cheque") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        
                        <asp:BoundField DataField="nro_despacho_interno" HeaderText="DI" SortExpression="nro_despacho_interno" />
                        <asp:BoundField DataField="observacion" HeaderText="Obs." SortExpression="observacion" />
<%--                        <asp:BoundField DataField="importe_aprobado" DataFormatString="{0:0,#}" HeaderText="Monto" SortExpression="importe_aprobado" />--%>
                        <%--<asp:BoundField DataField="nro_cheque" HeaderText="Nro. Cheque" SortExpression="nro_cheque" />--%>

                         <asp:TemplateField HeaderText="Importe">
                                <ItemTemplate>
                                    <asp:Label ID="lblImporte" runat="server" Text='<%# WerkUI.Core.Util.GetFormatedNumber(Eval("importe_aprobado")) %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                      <%--  <asp:BoundField DataField="monto" HeaderText="Monto cheque" />--%>

                        <asp:BoundField DataField="fecha_emision" HeaderText="Fecha" SortExpression="fecha_emision" />
                        <asp:BoundField DataField="banco" HeaderText="Banco" SortExpression="banco" />
                        <asp:BoundField DataField="nro_talon" HeaderText="Nro. Talon" SortExpression="nro_talon" />
                         <asp:ButtonField Text="Eliminar" CommandName="Eliminar" />
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
                <asp:SqlDataSource ID="ChequesAsignados" runat="server" ConnectionString="<%$ ConnectionStrings:WerkERPContext %>" SelectCommand="sp_obtener_cheques_asignados_por_op" SelectCommandType="StoredProcedure" OnSelected="ChequesAsignados_Selected">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="id_op" QueryStringField="RequestID" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
