﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="TacoSuccess.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/site.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <asp:Label ID="lblCartHeader" runat="server" Text="Your Cart" CssClass="h2"></asp:Label>
            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Prev" />
            <asp:Button ID="btnCart" runat="server" Text="Cart" OnClick="btnCart_Click" />
        </div>
    <div>
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <asp:Image ID="imgProduct" runat="server" ImageUrl='<%# Eval("entree.imagePath","~/Images/{0}") %>' Width="200px" /><br />
                <asp:Label ID="lblProduct" runat="server" Text='<%# Eval("entree.entreeName") %>' CssClass="h3"></asp:Label>
                <asp:DataList ID="dlIngredients" runat="server" DataSource='<%# Eval("selectedIngredients") %>'>
                    <ItemTemplate>
                        <asp:Label ID="lblIngredient" runat="server" Text='<%# Eval("ingredient.ingredientsName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:DataList>

            </ItemTemplate>
        </asp:DataList>
        <!--<asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>-->
        <!--<asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <asp:Image ID="imgProduct" runat="server" />
                <asp:Label ID="lblProduct" runat="server"></asp:Label>
                <asp:BulletedList ID="bltLstExtras" runat="server"></asp:BulletedList>
            </ItemTemplate>
        </asp:Repeater>-->
        
        <asp:Button ID="btnRemoveItem" runat="server" Text="Remove Item" OnClick="btnRemoveItem_Click" />
        <asp:Button ID="btnClearOrder" runat="server" Text="Clear Order" OnClick="btnClearOrder_Click" />
        <asp:Button ID="btnContinueOrdering" runat="server" Text="Continue Ordering" OnClick="btnContinueOrdering_Click" />
        <asp:Button ID="btnCheckout" runat="server" Text="Checkout" OnClick="btnCheckout_Click" />      

    </div>
    </form>
</body>
</html>
