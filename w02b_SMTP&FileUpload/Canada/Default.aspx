<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Canada_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ACIT 4650 lab - Provinces &amp; Cities in Canada</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="divConnectionString" style="color:white;" runat="server">
        
    </div>
    <div>
        <asp:HyperLink ID="hlHome" runat="server" NavigateUrl="~/Default.aspx">Home</asp:HyperLink>
        <h2>Provinces &amp; Cities in Canada</h2>
        Province:
        <asp:DropDownList ID="ddlProvince" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <br />
        <asp:GridView ID="gvCanada" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="edsCities" ForeColor="#333333" GridLines="None" DataKeyNames="alpha_code,city">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="alpha_code" HeaderText="Prov" ReadOnly="True" SortExpression="alpha_code" />
                <asp:BoundField DataField="city" HeaderText="City" ReadOnly="True" SortExpression="city" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:GridView>
        <asp:EntityDataSource ID="edsCities" runat="server" AutoGenerateWhereClause="True" ConnectionString="name=CanadaEntities" DefaultContainerName="CanadaEntities" EnableFlattening="False" EntitySetName="state_city" Where="">
            <WhereParameters>
                <asp:ControlParameter ControlID="ddlProvince" Name="alpha_code" PropertyName="SelectedValue" Type="String" />
            </WhereParameters>
        </asp:EntityDataSource>
        <br />
    
    </div>
    </form>
</body>
</html>
