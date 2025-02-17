using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2022_02_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WebService1 service1 = new WebService1 ();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String sentence = service1.operation(TextBox1.Text, TextBox2.Text,TextBox3.Text);
            Label1.Text = sentence;
        }
    }
}