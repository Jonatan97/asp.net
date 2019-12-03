<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Panel ID="Panel3" runat="server" CssClass="panelLogueo">
        <asp:Image ID="Image1" runat="server" Height="94px" Width="146px" ImageUrl="http://blog.aulaformativa.com/wp-content/uploads/2016/08/consideraciones-mejorar-primera-experiencia-de-usuario-aplicaciones-web-perfil-usuario.jpg"  />
        <br />
        <br />
    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" Width="150px" Height="29px" Font-Bold="true" Font-Size="Large" CssClass="btn"/>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Sign In" OnClick="Button2_Click" Width="150px" Height="29px" Font-Bold="true" Font-Size="Large" CssClass="btn"/>
    </asp:Panel>
    <br />
        <br />
    

   
</asp:Content>
