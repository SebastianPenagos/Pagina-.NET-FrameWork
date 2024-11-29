<%@ Page Title="Contáctanos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WingtipToys.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %></h2>
        <h3>Aqui podras contactar con la empresa si tienes alguna duda o sugerencia.<br /></h3>
        <address>
            Solo hacemos pedidos virtuales por el momento.<br />
            
        </address>

        <address>
             <strong>Teléfono:</strong> (+57) 300 664 0128<br />
            <strong>Soporte Técnico:</strong>   <a href="mailto:sebastian.penagos.velasquez@pi.edu.co">soporte@scaleracers.com</a><br />
            <strong>Marketing:</strong> <a href="mailto:camilaalfonso747@gmail.com">marketing@scaleracers.com</a>
        </address>
    </main>
</asp:Content>
