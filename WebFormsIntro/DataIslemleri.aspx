<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataIslemleri.aspx.cs" Inherits="WebFormsIntro.DataIslemleri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <ul>
            <asp:ListView ID="ListView1" runat="server">
                <ItemTemplate>
                    <li>
                        <%-- databasedeki alanlara bağlanmak için Eval özel methodu kullanılır. --%>
                        <%-- # ile c# methodlara bağlanılır = ile ise değişkenlere bağlanılır --%>
                        <p><%#Eval("CategoryName") %></p>
                    </li>
                </ItemTemplate>
            </asp:ListView>
        </ul>
    </form>
</body>

</html>
