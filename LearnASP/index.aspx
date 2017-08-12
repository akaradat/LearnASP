<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LearnASP.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Learn Web App ASP</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
        <p>
            <asp:TextBox ID="txt_age" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ตกลง" />
        </p>
    </form>
</body>
</html>
