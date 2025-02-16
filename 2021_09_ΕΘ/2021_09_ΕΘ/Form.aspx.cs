using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2021_09_ΕΘ
{
    public partial class Form : System.Web.UI.Page
    {
        _2021_09_ΕΘ myS = new _2021_09_ΕΘ();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = myS.SUBSTRING(TextBox1.Text, TextBox2.Text, Convert.ToInt32(TextBox3.Text));
        }
    }
}