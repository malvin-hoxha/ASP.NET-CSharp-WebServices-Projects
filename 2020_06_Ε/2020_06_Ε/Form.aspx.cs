using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2020_06_Ε
{
    public partial class Form : System.Web.UI.Page
    {
        _2020_06_Ε myS = new _2020_06_Ε();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Label1.Text = myS.Vrisko(TextBox1.Text).ToString();
        }
    }
}