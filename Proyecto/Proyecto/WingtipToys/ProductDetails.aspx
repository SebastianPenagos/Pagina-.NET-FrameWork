<%@ Page Title="Detalles del Producto" Language="C#" MasterPageFile="~/Site.Master"
AutoEventWireup="true"
 CodeBehind="ProductDetails.aspx.cs"
Inherits="WingtipToys.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="productDetail" runat="server"
ItemType="WingtipToys.Models.Product" SelectMethod ="GetProduct"
RenderOuterTable="false">
    <ItemTemplate>
        <div>
            <h1><%#:Item.ProductName %></h1>
        </div>
        
        <table>
            <tr>
                <td>
                    <img src="Images/Productos/<%#:Item.ImagePath %> "class='<%# "borde-img-detalle" %>'
                         style="border:solid; height:350px; width:350px" alt="<%#:Item.ProductName %>"/>
                    <div style="margin-top: 20px;"> 
                        <a href="/AddToCart.aspx?productID=<%#:Item.ProductID %>" class="btn-AddCart">
                            <span>
                                <b>
                                    Añadir al carrito
                                </b>
                            </span>
                        </a>
                    </div>
                </td>
                <td>&nbsp;</td>
                <td style="vertical-align: top; text-align:left;">
                    <b>Descripción:</b><br /><%#:Item.Description %><br /><span><b>Precio:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %></span><br /><span><b>Número del producto:</b>&nbsp;<%#:Item.ProductID %></span><br /><span><b>Año:</b>&nbsp;<%#:Item.Age %></span></td>
            </tr>
        </table>
    </ItemTemplate>
</asp:FormView>
</asp:Content>
