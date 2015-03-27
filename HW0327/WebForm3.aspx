<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="HW0327.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="幾歲:"></asp:Label>
        <asp:TextBox ID="age" runat="server"></asp:TextBox>
    
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="W">西元年</asp:ListItem>
            <asp:ListItem Value="C">民國元</asp:ListItem>
        </asp:DropDownList>
    
        <asp:Button ID="count" runat="server" Text="計算" OnClick="count_Click" />
        取得：<asp:Label ID="ans" runat="server" Text=""></asp:Label>年生
    
    </div>
    </form>
</body>
</html>
