using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2020_06_Ε
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WebService1 service1 = new WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = service1.Vrisko(TextBox1.Text).ToString();

        }
    }
}