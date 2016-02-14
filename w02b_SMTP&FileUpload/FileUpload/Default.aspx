<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="FileUpload_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BCIT lab - File Upload</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="hlHome" runat="server"
                NavigateUrl="~/Default.aspx">Home</asp:HyperLink>
            <h2>File Upload</h2>
            <div>
                <asp:FileUpload ID="fileUpload" runat="server" />
            </div>
            <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click"
                Text="Upload File" />
            <br />
            <br />
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
