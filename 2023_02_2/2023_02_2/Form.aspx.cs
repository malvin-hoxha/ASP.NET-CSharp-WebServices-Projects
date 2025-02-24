using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2023_02_2
{
    public partial class Form : System.Web.UI.Page
    {
        eu.dataaccess.footballpool.ws.Info FB = new eu.dataaccess.footballpool.ws.Info();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                eu.dataaccess.footballpool.ws.tTeamCoachName[] coaches = FB.AllTeamCoachNames();
                DropDownList1.Items.Add("- Επιλέξτε Προπονητή -");

                for (int i = 0; i < coaches.Length; i++)
                {
                    DropDownList1.Items.Add(coaches[i].sCoachName);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            eu.dataaccess.footballpool.ws.tTeamCoachName[] coaches = FB.AllTeamCoachNames();
            eu.dataaccess.footballpool.ws.tPlayerName[] players = FB.AllPlayerNames(true);
            for (int i = 0;i < coaches.Length; i++)
            {
                for (int j = 0; j < players.Length; j++)
                {
                    if (DropDownList1.Text == coaches[i].sCoachName && coaches[i].sTeamName == players[j].sCountryName)
                    {
                        Label1.Text = coaches[i].sTeamName;
                        Image1.ImageUrl = players[j].sCountryFlag;

                    }
                }
                
            }
        }
    }
}