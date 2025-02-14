using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2021_02_ΕΘ
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WebService1 service1 = new WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double number = service1.first(Convert.ToDouble(TextBox1.Text));
            Label1.Text = number.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double number = service1.second(Convert.ToDouble(TextBox2.Text), Convert.ToDouble(TextBox3.Text));
            Label2.Text = number.ToString();
        }
    }
}