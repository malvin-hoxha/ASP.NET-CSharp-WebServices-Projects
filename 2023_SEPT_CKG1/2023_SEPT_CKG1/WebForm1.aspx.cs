using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2023_SEPT_CKG1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Sept2023Exams myWS = new Sept2023Exams();
        org.oorsprong.www.CountryInfoService CInfo = new org.oorsprong.www.CountryInfoService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                DropDownList1.Items.Add("‐Select‐");
                // η μέθοδος επιστρέφει έναν πίνακα tCountryCodeAndName[]
                // ΠΡΟΣΟΧΗ λοιπόν στον τρόπο δήλωσης (τύπο) της μεταβλητής μας
                org.oorsprong.www.tCountryCodeAndName[] countries = CInfo.ListOfCountryNamesByName();
                for (int i = 0; i < countries.Length; i++)
                    DropDownList1.Items.Add(countries[i].sName);
            }


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Label1.Text = myWS.Zigos(Convert.ToInt32(TextBox1.Text));
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            org.oorsprong.www.tCountryCodeAndName[] countries = CInfo.ListOfCountryNamesByName();
            string ISOCODE;
            for (int i = 0;i < countries.Length; i++)
            {
                
                if (DropDownList1.Text == countries[i].sName)
                {
                    ISOCODE = CInfo.CountryISOCode(countries[i].sName);
                    Label2.Text = CInfo.CapitalCity(ISOCODE);
                }
            }

        }
    }
}