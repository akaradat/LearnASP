<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LearnASP.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Learn Web App ASP</title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p class="auto-style1">
            <asp:FileUpload ID="file_up" runat="server" />
        </p>
        <p class="auto-style1">
            Mode [ (E)ncrypt or (D)ecrypt ] :
            <asp:TextBox ID="txt_check" runat="server" Width="106px"></asp:TextBox>
        </p>
        <p>
            Pass for Encrypt or Decrypt [number]:
            <asp:TextBox ID="txt_code" runat="server"  Width="170px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="bt_summit" runat="server" Text="ตกลง" OnClick="bt_summit_Click" />
        <asp:Label ID="lblMessage" runat="server"  Font-Bold="true"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txt_view" runat="server" Height="142px" TextMode="MultiLine" Width="477px"></asp:TextBox>
        </p>
        <asp:Button ID="bt_download" runat="server" Enabled="False" OnClick="bt_download_Click" Text="Download" />
        <asp:Label ID="lb_download" runat="server" Enabled="False"></asp:Label>
    </form>
</body>
</html>
