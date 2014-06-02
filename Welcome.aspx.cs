using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["personKey"] != null)
        {
            CommunityAssistEntities1 ae = new CommunityAssistEntities1();
            int pk = (int)Session["personKey"];
            var customer = from c in ae.People
                           where c.PersonKey == pk
                           select new
                           {
                               c.PersonLastName,
                               c.PersonFirstName,
                               c.PersonUsername
                           };
            foreach (var p in customer)
            {
                lblWelcome.Text = "Welcome! " + p.PersonFirstName + " " + p.PersonLastName + " to Community Assist.";
            }

            GridView1.DataSource = customer.ToList();
            GridView1.DataBind();

        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
    protected void lbDonate_Click(object sender, EventArgs e)
    {
        Response.Redirect("GetDonation.aspx");
    }
    protected void lbGrant_Click(object sender, EventArgs e)
    {
        Response.Redirect("Grant.aspx");
    }
}