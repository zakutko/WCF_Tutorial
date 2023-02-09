using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SummatorServiceClient
{
    public partial class Summator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var a = int.Parse(TextBox1.Text);
            var b = int.Parse(TextBox2.Text);
            var client = new ServiceReference1.SummatorServiceClient("BasicHttpBinding_ISummatorService");
            var result = client.GetSum(a, b);

            Label1.Text = result.ToString();
        }
    }
}