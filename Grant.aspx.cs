using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class Grant : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            CommunityAssistEntities1 cae = new CommunityAssistEntities1();
            ServiceGrant sg = new ServiceGrant();
            int pk = (int)Session["personKey"];
            sg.ServiceKey = int.Parse(ddlGrantType.SelectedValue.ToString());
            sg.GrantAmount = Decimal.Parse(txtGrantAmount.Text);
            sg.GrantDate = DateTime.Now;
            sg.GrantNeedExplanation = txtExplanation.Text;
            sg.PersonKey = pk;
            cae.ServiceGrants.Add(sg);

            cae.SaveChanges();

            Response.Redirect("Confirmation.aspx");
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
}