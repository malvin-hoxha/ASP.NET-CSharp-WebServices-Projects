﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2023_06
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WebService1 service1 = new WebService1 ();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = service1.intDivision(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label3.Text = service1.MiddleWord(TextBox3.Text);
        }
    }
}