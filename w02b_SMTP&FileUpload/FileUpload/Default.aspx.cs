using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FileUpload_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        // Specify the path on the server to save the uploaded file to.
        string savePath = Server.MapPath("./uploads/");
        System.IO.Directory.CreateDirectory(savePath);
        // Before attempting to perform operations on the file,
        // verify that the FileUpload control contains a file
        if (fileUpload.HasFile) {
            // Get the name of the file to upload and append to path
            savePath += fileUpload.FileName;
            // Call the SaveAs method to save uploaded file to specified path. 
            // This example does not perform all the necessary error checking. 
            // If file with same name exists, the uploaded file overwrites it.
            fileUpload.SaveAs(savePath);
            // Notify the user of the name the file was saved under.
            lblMsg.ForeColor = System.Drawing.Color.Green;
            lblMsg.Text = "File saved as: <i>" + savePath + "</i>";
        } else {
            // Notify the user that a file was not uploaded.
            lblMsg.ForeColor = System.Drawing.Color.Red;
            lblMsg.Text = "You did not specify a file to upload.";
        }
    }
}