<%@ Page Title="" Language="C#" MasterPageFile="~/Public.master" %>

<script runat="server">

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(tbDegree.Text))
        {
            if (DropDownList1.Text == "C to F")
            {
                double C = Convert.ToDouble(tbDegree.Text);
                double F = (C * 9) / 5 + 32;
                lblResult.Text = F.ToString();
            }
            else {
                double F = Convert.ToDouble(tbDegree.Text);
                double C = 5.0 / 9.0 * (F - 32);
                lblResult.Text = C.ToString();
            }
        }
    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
    <p>
        Temperature:
        <asp:TextBox ID="tbDegree" runat="server"></asp:TextBox>&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>C to F</asp:ListItem>
            <asp:ListItem>F to C</asp:ListItem>
        </asp:DropDownList>&nbsp;
        <asp:Label ID="lblResult" runat="server"></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate &gt;&gt;" />
    </p>
</asp:Content>

