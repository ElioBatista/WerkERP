<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RequestOPDetails.aspx.cs" Inherits="WerkUI.OrdenPago.RequestOPDetails" Debug="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="upnlSolicitudesOP" runat="server">

        <ContentTemplate>
            <div class="site-title">
                <asp:Label ID="lblSiteTitle" runat="server" Visible="True" CssClass="main-content" Text="Detalles de Solicitud de OP" />
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
                OnItemEditing="RequestOPDetailsListView_ItemEditing"  >
                <LayoutTemplate>
                    <div class="table responsive">
                        <table class="table table-striped">
                            <thead>
                                <tr>                                   
                                    <th>Nro. DI</th>
                                    <th class="text-center">Concepto</th>
                                    <th class="text-center">Monto</th>
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
                       
                        <td>
                            <asp:Label ID="lblNroDI" runat="server" Text='<%# GetDIClient( Item.nro_despacho_interno.ToString())%>' />
                        </td>
                        <td>
                            <asp:Label ID="lblConcepto" runat="server" Text='<%#  GetConceptByNumber(Item.nro_concepto) %>'  />
                        </td>
                        <td>
                            <asp:Label ID="lblImporte" runat="server" Text='<%# WerkUI.Core.Util.GetFormatedNumber(Item.importe) %>' />
                        </td>
                        <td>
                            <asp:Label ID="lblObservacion" runat="server" Text='<%# Item.observacion %>' />
                        </td>
                        
                        <td class="text-right">
                            <asp:Button ID="EditButton" runat="server" Text="Editar" CommandName="Edit"  />
                            <asp:Button ID="DeleteButton" runat="server" Text="Borrar" CommandName="Delete"  />
                        </td>
                    </tr>
                </ItemTemplate>
                <EditItemTemplate>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtNroDI" runat="server" Text='<%# BindItem.nro_despacho_interno%>' CssClass="form-control" />
                        </td>
                         <td>
                            <asp:TextBox ID="txtConcepto" runat="server" Text='<%# BindItem.nro_concepto%>' CssClass="form-control" />
                        </td>
                         <td>
                            <asp:TextBox ID="txtImporte" runat="server" Text='<%# BindItem.importe%>' CssClass="form-control" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtObservacion" runat="server" Text='<%# BindItem.observacion%>' CssClass="form-control" />
                        </td>
                      
                        <td class="text-right">
                            <asp:Button ID="UpdateButton" runat="server" Text="Guardar" CommandName="Update" CssClass="btn btn-info" />
                            <asp:Button ID="CancelButton" runat="server" Text="Cancelar" CommandName="Cancel" CssClass="btn" />
                        </td>
                    </tr>
                </EditItemTemplate>
                <InsertItemTemplate>
                    
                    <tr>
                            <td>
                            <asp:TextBox ID="txtNroDI" runat="server" Text='<%# BindItem.nro_despacho_interno%>' CssClass="form-control" />
                        </td>
                         <td>
                            <asp:TextBox ID="txtConcepto" runat="server" Text='<%# BindItem.nro_concepto%>' CssClass="form-control" />
                        </td>
                         <td>
                            <asp:TextBox ID="txtImporte" runat="server" Text='<%# BindItem.importe%>' CssClass="form-control" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtObservacion" runat="server" Text='<%# BindItem.observacion%>' CssClass="form-control" />
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
    &lt;
</asp:Content>
