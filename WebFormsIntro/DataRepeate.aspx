<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataRepeate.aspx.cs" Inherits="WebFormsIntro.DataRepeate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                <%-- foreach --%>
                <asp:Repeater ID="Repeater1" runat="server">

                    <ItemTemplate>
                        <li><%# Eval("CategoryName") %></li>
                        <li><%#Eval("Description") %></li>
                    </ItemTemplate>

                </asp:Repeater>
            </ul>
        </div>
    </form>
</body>
</html>
