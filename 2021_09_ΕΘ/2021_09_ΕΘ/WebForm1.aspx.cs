using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2021_09_ΕΘ
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WebService1 service1 = new WebService1 ();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String sentence = service1.operation(TextBox1.Text,TextBox2.Text,Convert.ToInt32(TextBox3.Text));
            Label1.Text = sentence;

        }
    }
}