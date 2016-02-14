<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default"
    MasterPageFile="~/Public.master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">

    <div>
        <asp:FileUpload ID="fileUpload" runat="server" />
        <br />
        <asp:Button ID="btnUpload" runat="server" Text="Upload File" OnClick="btnUpload_Click" />
        <br />
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:ListBox ID="lbFiles" runat="server" Height="179px" Width="583px" AutoPostBack="True" OnSelectedIndexChanged="lbFiles_SelectedIndexChanged"></asp:ListBox>
    </div>
    <div>
        <asp:TextBox ID="tbContent" runat="server" Height="62px" TextMode="MultiLine" Width="567px"></asp:TextBox>
        <br />
        <asp:Button ID="btnSave" Text="Save" runat="server" OnClick="btnSave_Click" />
    </div>
</asp:Content>
