using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetDonation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            CommunityAssistEntities1 cae = new CommunityAssistEntities1();
            Donation d = new Donation();
            int pk = (int)Session["personKey"];
            d.DonationAmount = Decimal.Parse(txtDonation.Text);
            d.DonationDate = DateTime.Now;           
            d.PersonKey = pk;
            cae.Donations.Add(d);

            cae.SaveChanges();

            Response.Redirect("Confirmation.aspx");
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    
    }
}