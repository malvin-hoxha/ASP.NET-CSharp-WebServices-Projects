using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2021
{
    public partial class Form : System.Web.UI.Page
    {
        _2021 myS = new _2021();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = myS.SQRT(Convert.ToDouble(TextBox1.Text)).ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = myS.CEIL(Convert.ToDouble(TextBox2.Text)).ToString();

        }
    }
}