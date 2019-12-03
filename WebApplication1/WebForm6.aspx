<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication1.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>PRODUCTOS&nbsp;&nbsp;&nbsp; </h1>
    <asp:Image ID="imgMuestra" runat="server" Height="173px" Width="296px" ImageUrl="https://previews.123rf.com/images/phonlamaiphoto/phonlamaiphoto1706/phonlamaiphoto170600100/81554651-sistema-de-punto-de-venta-3d-para-la-gesti%C3%B3n-de-tiendas.jpg" />
    <asp:GridView ID="gvDatos" runat="server" OnRowCommand="seleccionderegistro" >

        <Columns>
            <asp:ButtonField CommandName="btnComprar" Text="Comprar" />
        </Columns>

    </asp:GridView>
    <br />
    <asp:Button ID="btnFin" runat="server" Height="46px" OnClick="btnFin_Click" Text="FIN CARRITO" Width="118px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:GridView ID="gvApoyo" runat="server" Visible="False">
    </asp:GridView>
    <br />
</asp:Content>
