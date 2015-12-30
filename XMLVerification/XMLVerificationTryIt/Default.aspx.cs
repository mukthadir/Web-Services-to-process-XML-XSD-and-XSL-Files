using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XMLVerificationTryIt
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                XMLVerification.Service1Client xmlVerificationClient = new XMLVerification.Service1Client();
                TextBox4.Text = xmlVerificationClient.Verification(TextBox1.Text, TextBox2.Text);
            }
            catch (Exception ex)
            {
                TextBox4.Text = ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                XMLVerification.Service1Client xmlVerificationClient = new XMLVerification.Service1Client();
                TextBox5.Text = xmlVerificationClient.XPathSearch(TextBox1.Text, TextBox3.Text);
            }
            catch (Exception ex)
            {
                TextBox5.Text = ex.Message;
            }
        }
    }
}