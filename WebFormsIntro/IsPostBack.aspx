<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IsPostBack.aspx.cs" Inherits="WebFormsIntro.IsPostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList AutoPostBack="true" ID="drpIL" runat="server" OnSelectedIndexChanged="drpIL_SelectedIndexChanged"></asp:DropDownList>

        <asp:DropDownList  ID="drpIlace" runat="server"></asp:DropDownList>
    </div>
    </form>
</body>
</html>
