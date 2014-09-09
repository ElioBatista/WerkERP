<%@ Page Title="Acerca de" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WerkUI.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Sistema de gestión de despachos aduaneros</h2>
    </hgroup>

    <article>
        <p>        
            Werk, es un ERP de clase mundial orientado al sector de los despachos aduaneros.
        </p>

        <p>        
            Esta diseñado para alto rendimiento y escalabilidad.
        </p>
      
         <p>        
            BALCAZZ TECNOLOGIA.
        </p>

        
    </article>

    <aside>
        <h3>Accesos útiles</h3>
        <p>        
            Secciones.
        </p>
        <ul>
            <li><a runat="server" href="~/">Inicio</a></li>
            <li><a runat="server" href="~/About.aspx">Acerca de</a></li>
            <li><a runat="server" href="~/Contact.aspx">Contacto</a></li>
            <li><a runat="server" href="~/Core/Main.aspx">Menú principal</a></li>
        </ul>
    </aside>
</asp:Content>