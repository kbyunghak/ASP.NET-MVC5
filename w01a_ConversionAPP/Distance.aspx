<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" %>

<script runat="server">

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(tbDistance.Text))
        {
            if (DropDownList1.Text == "Miles to Km")
            {
                double miles = Convert.ToDouble(tbDistance.Text);
                double km = miles * 1.609344;
                lblResult.Text = km.ToString();
            }
            else {
                double km = Convert.ToDouble(tbDistance.Text);
                double miles = km * 0.621371192;
                lblResult.Text = miles.ToString();
            }
        }
    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <p>
        Distance:
        <asp:TextBox ID="tbDistance" runat="server"></asp:TextBox>&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Km to Miles</asp:ListItem>
            <asp:ListItem>Miles to Km</asp:ListItem>
        </asp:DropDownList>&nbsp;
        <asp:Label ID="lblResult" runat="server"></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate &gt;&gt;" />
    </p>
</asp:Content>

