using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2022_02_1
{
    public partial class Form : System.Web.UI.Page
    {
        _2020_02_1 myS = new _2020_02_1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = myS.REPLACE(TextBox1.Text,TextBox2.Text,TextBox3.Text);
        }
    }
}