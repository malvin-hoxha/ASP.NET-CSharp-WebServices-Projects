using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2020_02_ΕΘ
{
    public partial class Form : System.Web.UI.Page
    {
        _2020_02_ΕΘ myS = new _2020_02_ΕΘ();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = myS.THREE(Convert.ToDouble(TextBox1.Text)).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = myS.POW(Convert.ToDouble(TextBox2.Text), Convert.ToDouble(TextBox3.Text)).ToString();
        }
    }
}