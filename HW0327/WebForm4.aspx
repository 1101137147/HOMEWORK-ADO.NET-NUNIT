<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="HW0327.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="selecttext" runat="server"></asp:TextBox>
        <asp:Button ID="select" runat="server" OnClick="btnselect_Click" Text="查詢" />
    
    </div>
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
             
            </Columns>
        </asp:GridView>
        <asp:Label ID="namelabel" runat="server" Text="StudentName:"></asp:Label>
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
        <asp:Label ID="agelabel" runat="server" Text="StudentAge:"></asp:Label>
        <asp:TextBox ID="age" runat="server"></asp:TextBox>
        <asp:Label ID="phonelabel" runat="server" Text="StudentPhone:"></asp:Label>
        <asp:TextBox ID="phone" runat="server"></asp:TextBox>
        <asp:Button ID="Insert" runat="server" OnClick="btnadd_Click" Text="新增" /></br>
        <asp:Label ID="Label1" runat="server" Text="StudentId:"></asp:Label>
        <asp:TextBox ID="sid" runat="server"></asp:TextBox>
         <asp:Label ID="Label4" runat="server" Text="StudentName:"></asp:Label>
        <asp:TextBox ID="name2" runat="server"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="StudentAge:"></asp:Label>
        <asp:TextBox ID="age2" runat="server"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="StudentPhone:"></asp:Label>
        <asp:TextBox ID="phone2" runat="server"></asp:TextBox>
        <asp:Button ID="update" runat="server" OnClick="btnupdate_Click" Text="修改" />
        <p>
            StudentId:<asp:TextBox ID="Studentid" runat="server"></asp:TextBox>
            <asp:Button ID="delete" runat="server"   OnClick="btndel_Click" Text="刪除" />
        </p>
    </form>
</body>
</html>
