<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="smtp_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ACIT 4650 lab - Send Email</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="hlHome" runat="server"
                NavigateUrl="~/Default.aspx">Home</asp:HyperLink>
            <h2>Send Email</h2>
            <table>
                <tr>
                    <td style="width: 100px">To:</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="tbTo" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">From:</td>
                    <td style="width: 100px">
                        <asp:Label ID="lblFromName" runat="server" Text="Fred Smith"></asp:Label>
                        &nbsp; &nbsp; &nbsp; &nbsp;
                    <asp:Label ID="lblFromEmail" runat="server" Text="fred.smith@abc.ca"></asp:Label></td>
                </tr>
                <tr>
                    <td style="width: 100px">Subject:</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="tbSubject" runat="server" Width="464px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" style="height: 42px">
                        <asp:TextBox ID="tbEmailBody" runat="server" Height="200px" TextMode="MultiLine" Width="565px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align:center" colspan="2">
                        <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click" /></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMsg" runat="server"></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
