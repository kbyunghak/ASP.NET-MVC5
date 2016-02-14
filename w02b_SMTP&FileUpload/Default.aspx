<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BCIT IIS/SMTP/Upload lab</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>BCIT IIS/SMTP/Upload lab</h2>
            <asp:HyperLink ID="hlCanada" runat="server"
                NavigateUrl="~/Canada/Default.aspx">Canada</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="hlSendEmail" runat="server"
                NavigateUrl="~/smtp/Default.aspx">Send Email</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="hlFileUpload" runat="server"
                NavigateUrl="~/FileUpload/Default.aspx">File Uploads</asp:HyperLink>
        </div>
    </form>
</body>
</html>
