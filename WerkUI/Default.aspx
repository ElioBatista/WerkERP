<%@ Page Title="Werk" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WerkUI._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Sistema de Gestión de despachos aduaneros - WEB100</h2>
            </hgroup>
            <p>
                Bienvenido al sistema de gestión de despachos de aduana, los procesos en el sistema estan basados en tareas las cuales se le asignan según su rol operativo. 
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Algunos tips:</h3>
    <ol class="round">
        <li class="one">
            <h5>Seguridad</h5>
           No escriba su contraseña, recuerde la misma y cambiela periodicamente.
        </li>
        <li class="two">
            <h5>Accebilidad</h5>
            Werk utiliza la tecnología WEB, lo que permite acceder desde cualquier dispositivo capaz de correr un navegador web.
        </li>
        <li class="three">
            <h5>Alta Disponibilidad</h5>
            Werk, esta diseñado sobre una arquitectura altamente escalable lo cual permite el manejo de grandes cargas asi como la implementacion de tecnicas de Alta disponibilidad "Always ON".
        </li>
    </ol>
</asp:Content>
