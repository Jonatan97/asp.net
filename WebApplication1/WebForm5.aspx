<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication1.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            margin-right: 0px;
        }
        .auto-style6 {
            margin-top: 0px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="PRODUCTOS SITE" Font-Size="Larger" Font-Bold="true" ></asp:Label>
    <br />
    <br />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Alta Producto" Font-Bold="true" Width="120" Height="50" OnClick="Button1_Click"  />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="btnModificar" runat="server" Text="Modificar Producto" Font-Bold="true" Width="133px" Height="50px" OnClick="btnModificar_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Eliminar Producto" Font-Bold="true" Width="120" Height="50" OnClick="Button2_Click" />
    <br />
    <br />
    <asp:Panel ID="pSubirProducto" runat="server" Width="756px" Height="600px" HorizontalAlign="Left" CssClass="auto-style5">

        <br />
        <br />
        <asp:GridView ID="gvProductos" runat="server" CaptionAlign="Right" Visible="False" OnRowCommand="gvProductos_RowCommand">
            <Columns>
                <asp:ButtonField CommandName="btnSELECCION" Text="SELECCIONAR DATO" />
            </Columns>
        </asp:GridView>
        <asp:Image ID="imgPreview" runat="server" Height="200px" ImageAlign="Left" ImageUrl="https://previews.123rf.com/images/phonlamaiphoto/phonlamaiphoto1706/phonlamaiphoto170600100/81554651-sistema-de-punto-de-venta-3d-para-la-gesti%C3%B3n-de-tiendas.jpg" Width="200PX" />
        <br />
        &nbsp;
        <asp:Label ID="Label2" runat="server" Font-Bold="true" Font-Size="Large" Text="Nombre Producto:"></asp:Label>
        <asp:TextBox ID="txtProductos" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;
        <asp:Label ID="Label3" runat="server" Font-Bold="true" Font-Size="Large" Text="Image:"></asp:Label>
        <asp:FileUpload ID="fuploadimagen" runat="server" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        &nbsp;
        <asp:Label ID="Label4" runat="server" Font-Bold="true" Font-Size="Large" Text="Codigo:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
        <br />
&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        &nbsp;
        <asp:Label ID="Label5" runat="server" Font-Bold="true" Font-Size="Large" Text="Precio:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
        <br />
&nbsp;<br /> &nbsp;
        <asp:Label ID="Label6" runat="server" Font-Bold="true" Font-Size="Large" Text="Disponibles:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtDisponibles" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnAplicarModificar" runat="server" Font-Bold="true" Font-Size="20px" Height="51px" Text="Modificar" Width="135px" OnClick="btnAplicarModificar_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button6" runat="server" Font-Bold="true" Font-Size="20px" Height="51px" Text="Eliminar" Width="135px" OnClick="Button6_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAlta" runat="server" Font-Bold="true" Font-Size="20px" Height="51px" OnClick="btnAlta_Click" Text="Alta" Width="135px" />
        &nbsp;&nbsp;
       
        <asp:Button ID="btnMenu" runat="server" Font-Bold="true"  CssClass="auto-style6" Height="46px" OnClick="btnMenu_Click" Text="Ir a menu" Width="135px" Font-Size="20px" />
       
    </asp:Panel>
    
</asp:Content>
