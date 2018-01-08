<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="WebFormsIntro.Menu" %>

<ul>
    <asp:HyperLink ID="HyperLink1" NavigateUrl="Default.aspx" runat="server">Link-1</asp:HyperLink>
     <asp:HyperLink ID="HyperLink2" NavigateUrl="IsPostBack.aspx" runat="server">Link-2</asp:HyperLink>
     <asp:HyperLink NavigateUrl="~/ViewState.aspx" ID="HyperLink3" runat="server">Link-3</asp:HyperLink>
</ul>
