using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Canada_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            using (var ctx = new CanadaEntities()) {
                var qry = (from p in ctx.state_alpha_code
                           orderby p.description
                           where p.country == "Canada"
                           select new { p.alpha_code, p.description }).Distinct();

                ddlProvince.DataSource = qry.ToList();
                ddlProvince.DataValueField = "alpha_code";
                ddlProvince.DataTextField = "description";
                ddlProvince.DataBind();
            }

            divConnectionString.InnerText = ConfigurationManager.ConnectionStrings["CanadaEntities"].ConnectionString;
        }
    }
}