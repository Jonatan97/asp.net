<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="WebApplication1.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" CssClass="prueba">
        <asp:GridView ID="gvFormato" runat="server" >
        </asp:GridView>
  
      
        <br />
        <asp:GridView ID="gvPagar" runat="server">
        </asp:GridView>
        <br />
  
      
        <asp:Button ID="btnReporte" runat="server" OnClick="btnReporte_Click" Text="Generar Reporte" />
  
      
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnPagar" runat="server" OnClick="btnPagar_Click" Text="Pagar" Width="116px" />
        &nbsp;</asp:Panel>
    
</asp:Content>