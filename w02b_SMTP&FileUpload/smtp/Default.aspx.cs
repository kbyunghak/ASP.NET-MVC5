using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class smtp_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        try {
            MailAddress fromAdd = new MailAddress(lblFromEmail.Text, lblFromEmail.Text);
            MailAddress toAdd = new MailAddress(tbTo.Text);
            MailMessage msg = new MailMessage(fromAdd, toAdd);
            msg.Subject = tbSubject.Text;
            msg.Body = tbEmailBody.Text;
            msg.To.Add(toAdd);

            // Settings are read from the <System.Net> section of the web.config file
            SmtpClient client = new SmtpClient();

            client.Send(msg);

            lblMsg.ForeColor = System.Drawing.Color.Green;
            lblMsg.Text = "Email message sent";
        } catch (Exception ex) {
            lblMsg.ForeColor = System.Drawing.Color.Red;
            lblMsg.Text = ex.ToString();
        }
    }
}