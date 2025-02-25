using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2023_02_3
{
    public partial class Form : System.Web.UI.Page
    {
        Sept2023Exams myS = new Sept2023Exams();
        org.oorsprong.www.CountryInfoService CIS = new org.oorsprong.www.CountryInfoService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                org.oorsprong.www.tCountryCodeAndName[] countries = CIS.ListOfCountryNamesByName();
                DropDownList1.Items.Add("- Επιλέξτε Χώρα -");

                for (int i = 0; i < countries.Length; i++)
                {
                    DropDownList1.Items.Add(countries[i].sName);
                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Label1.Text = myS.Zigos(Convert.ToInt32(TextBox1.Text));
        }


        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            String ISOCODE;
            String capital;
            ISOCODE = CIS.CountryISOCode(DropDownList1.Text);
            Label2.Text = capital = CIS.CapitalCity(ISOCODE);
        }
    }
}