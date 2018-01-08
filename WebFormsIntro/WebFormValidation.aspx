<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormValidation.aspx.cs" EnableEventValidation="true" Inherits="WebFormsIntro.WebFormValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
   <%--     <asp:ValidationSummary ForeColor="Red" ID="ValidationSummary1" runat="server" />--%>

  <%--      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ControlToValidate="TextBox1" ID="RequiredFieldValidator1"  runat="server" ErrorMessage="1.alan Boş Geçilemez"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBox2" runat="server" ErrorMessage="2.alan Boş Geçilemez"></asp:RequiredFieldValidator>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>--%>

        <asp:TextBox ValidationGroup="V1" TextMode="Password" ID="TextBox3" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" ControlToValidate="TextBox4" ControlToCompare="TextBox3" runat="server" ErrorMessage="Parola Eşleşmedi"></asp:CompareValidator>
        <asp:TextBox ValidationGroup="V1" TextMode="Password" ID="TextBox4" runat="server"></asp:TextBox>

        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />


    </div>
    </form>
</body>
</html>
