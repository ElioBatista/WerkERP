<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RequestOPs.aspx.cs" Inherits="WerkUI.OrdenPago.RequestOPs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="upnlSolicitudesOP" runat="server">

        <ContentTemplate>
            <div class="site-title">
                <asp:Label ID="lblSiteTitle" runat="server" Visible="True" CssClass="main-content" Text="Solicitudes de OP" />
            </div>
            <div>
                <asp:Label ID="ErrorLabel" runat="server" Visible="False" CssClass="field-validation-error" />
            </div>
            <asp:ListView ID="RequestOPsListView" runat="server"
                ItemType="WerkUI.Models.SolicitudOrdenPago" DataKeyNames="id_solicitud_orden_pago"
                SelectMethod="GetRequestOPs"
                UpdateMethod="UpdateRequestOP"
                InsertMethod="InsertRequestOP"
                DeleteMethod="DeleteRequestOP"
                InsertItemPosition="LastItem"
                OnItemCanceling="RequestOPsListView_ItemCanceling"
                OnItemEditing="RequestOPsListView_ItemEditing">
                <LayoutTemplate>
                    <div class="table responsive">
                        <table class="table table-striped">
                            <thead>
                                <tr>
                                    <th>Nro. Comprobante</th>
                                    <th class="text-center">Fecha Solicitud</th>
                                    <th class="text-center">Estado</th>

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
                            <asp:Label ID="lblNroComprobanteOP" runat="server" Text='<%# Item.nro_comprobante%>' />
                        </td>
                        <td>
                            <asp:Label ID="lblFechaOP" runat="server" Text='<%# WerkUI.Core.Util.GetFormatedDate(Item.fecha_solicitud)%>' />
                        </td>
                        <td>
                            <asp:Label ID="lblStadoOP" runat="server" Text='<%# Item.EstadoSolicitud.estado %>' />
                        </td>

                        <td class="text-right">
                            <asp:Button ID="EditButton" runat="server" Text="Editar" CommandName="Edit" />
                            <asp:Button ID="DeleteButton" runat="server" Text="Borrar" CommandName="Delete" />
                            <asp:Button ID="DetailsButton" runat="server" Text="Detalles" PostBackUrl='<%# "~/OrdenPago/RequestOPDetails.aspx?RequestID=" + Eval("id_solicitud_orden_pago")  + "&RequestNumber=" + Eval("nro_comprobante") %>' />
                        </td>
                    </tr>
                </ItemTemplate>
                <EditItemTemplate>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtNroComprobanteOP" runat="server" Text='<%# BindItem.nro_comprobante%>' CssClass="form-control" />
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
                            <asp:TextBox ID="txtNroComprobanteOP" runat="server" Text='<%# BindItem.nro_comprobante%>' CssClass="form-control" />
                        </td>
                        <td class="text-right">
                            <asp:Button ID="InsertButton" runat="server" Text="Agregar" CommandName="Insert" CssClass="btn btn-success" />
                        </td>
                    </tr>
                </InsertItemTemplate>

            </asp:ListView>

            <asp:DataPager ID="RequestOPsDataPager" runat="server" PagedControlID="RequestOPsListView" PageSize="5">
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
