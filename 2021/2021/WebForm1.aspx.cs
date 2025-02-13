using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2021
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WebService1 service1 = new WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double number;
            number = service1.sqrtService(Convert.ToDouble(TextBox1.Text));
            Label1.Text = number.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double number;
            number = service1.ceilingService(Double.Parse(TextBox1.Text));
            Label1.Text = number.ToString();
        }
    }
}