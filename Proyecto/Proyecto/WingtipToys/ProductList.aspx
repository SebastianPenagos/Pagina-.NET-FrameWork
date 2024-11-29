<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="ProductList.aspx.cs" Inherits="WingtipToys.ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>
            <asp:ListView ID="productList" runat="server"
                DataKeyNames="ProductID"
                GroupItemCount="4"
                ItemType="WingtipToys.Models.Product"
                SelectMethod="GetProducts">
                <EmptyDataTemplate>
                    <table runat="server">
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td runat="server" />
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td style="text-align: center;">
                                    <a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>">
                                        <img src="Images/Productos/<%#:Item.ImagePath%>" class='<%# "borde-img" %>' width="300" height="300" />
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center;">
                                    <span>
                                        <b><%#:Item.ProductName%></b>
                                    </span>
                                    <br />
                                    <span>
                                        <b>Precio:</b><%#:String.Format("{0:c}", Item.UnitPrice)%>
                                    </span>
                                    <br />
                                    <div style="margin-top: 20px;"> 
                                    <a href="/AddToCart.aspx?productID=<%#:Item.ProductID %>" class='<%# "Boton-carrito" %>'>
                                        <span class="ProductListItem">
                                            <b>Añadir</b>
                                        </span>
                                    </a>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server" style="width:100%;">
                        <tbody>
                            <tr runat="server">
                                <td runat="server">
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder" runat="server"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr runat="server">
                                <td runat="server"></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>