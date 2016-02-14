using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string uploadsDir = MapPath("~/uploads");
            string[] files = Directory.GetFiles(uploadsDir);
            lbFiles.DataSource = files;
            lbFiles.DataBind();
        }
    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(fileUpload.FileName))
        {
            string uploadsDir = MapPath("~/uploads");
            try {
                fileUpload.SaveAs(uploadsDir + "/" + fileUpload.FileName);
            } catch (Exception ex)
            {
                lblMsg.Text = ex.ToString();
            }
            lblMsg.Text = "File uploaded to  " + uploadsDir;
        }
    }

    protected void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
    {
        string file = lbFiles.SelectedValue;
        string content = File.ReadAllText(file);
        tbContent.Text = content;
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(tbContent.Text)) {
            string file = lbFiles.SelectedValue;
            File.WriteAllText(file, tbContent.Text);
        }
    }
}