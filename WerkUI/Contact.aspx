<%@ Page Title="Contacto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WerkUI.Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Balcazz Tecnología | Contacto</h2>
    </hgroup>

    <section class="contact">
        <header>
            <h3>Teléfono:</h3>
        </header>
        <p>
            <span class="label">Principal:</span>
            <span>+595 21 2199294</span>
        </p>
        <p>
            <span class="label">Fuera del horario laboral:</span>
            <span>+595 971 866866</span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>Correo electrónico:</h3>
        </header>
        <p>
            <span class="label">Soporte técnico:</span>
            <span><a href="mailto:Support@balcazzhitech.onmicrosoft.com">Support@balcazzhitech.onmicrosoft.com</a></span>
        </p>
        <p>
            <span class="label">Marketing:</span>
            <span><a href="mailto:Marketing@balcazzhitech.onmicrosoft.com">Marketing@balcazzhitech.onmicrosoft.com</a></span>
        </p>
       
    </section>

    <section class="contact">
        <header>
            <h3>Dirección:</h3>
        </header>
        <p>
            Alejandro Guanes 255<br />
            Asunción - Paraguay
        </p>
    </section>
</asp:Content>