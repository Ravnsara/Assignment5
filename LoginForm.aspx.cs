using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Login login = new Login(txtPassword.Text, txtuserName.Text);
        int personkey = login.ValidateLogin();
        if (personkey != 0)
        {
            Session["personKey"] = personkey;
            Response.Redirect("Welcome.aspx");
        }
        else
        {
            lblResult.Text = "Invalid Login";
        }
    }

    protected void lbRegister_Click(object sender, EventArgs e)
    {

    }
}