<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryString.aspx.cs" Inherits="WebFormsIntro.QueryString" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%-- sayfalar arası url üzerinden veri alışverişi sağlayan bir yöntem --%>
        <%-- arama ve detay görüntüleme gibi id üzerinden yapılan işlemlerde tercih edilir. --%>
        <asp:LinkButton OnClick="LinkButton1_Click" ID="LinkButton1" runat="server">Tıkla ve Gör</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
