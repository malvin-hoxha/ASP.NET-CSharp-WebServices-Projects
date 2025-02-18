using _2022_09.eu.dataaccess.footballpool.ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2022_09
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        eu.dataaccess.footballpool.ws.Info fbWS = new eu.dataaccess.footballpool.ws.Info();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                string[] teamNames = fbWS.TeamNames();
                DropDownList1.Items.Add("- Επιλέξτε Εθνική Ομάδα -");

                for (int i=0; i < teamNames.Length;i++)
                {
                    DropDownList1.Items.Add(teamNames[i]);
                }
            }

        }

        

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            eu.dataaccess.footballpool.ws.tTeamCoachName[] coaches = fbWS.AllTeamCoachNames();
            for (int i = 0; i < coaches.Length; i++)
            {
                if (DropDownList1.Text == coaches[i].sTeamName)
                {
                    Label2.Text = coaches[i].sCoachName;
                }
            }
        }
    }
}