using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2023_02_1
{
    public partial class Form : System.Web.UI.Page
    {
        Jan2023Exams myS = new Jan2023Exams();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = myS.AkeraiaDiairesi(Convert.ToInt32(TextBox1.Text),Convert.ToInt32(TextBox2.Text)).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = myS.EsoLexi(TextBox3.Text);
        }
    }
}