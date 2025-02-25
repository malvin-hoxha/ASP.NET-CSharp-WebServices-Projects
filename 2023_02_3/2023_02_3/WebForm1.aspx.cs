using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2023_02_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        eu.dataaccess.footballpool.ws.Info fbWS = new eu.dataaccess.footballpool.ws.Info();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                // η λειτουργία επιστρέφει πίνακα string
                eu.dataaccess.footballpool.ws.tTeamCoachName[] coaches = fbWS.AllTeamCoachNames();

                DropDownList1.Items.Add("- Προπονητή -");
                for (int i = 0; i < coaches.Length; i++)
                {
                    DropDownList1.Items.Add(coaches[i].sCoachName);
                }

                    
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            eu.dataaccess.footballpool.ws.tTeamCoachName[] coaches = fbWS.AllTeamCoachNames();
            eu.dataaccess.footballpool.ws.tPlayerName[] players = fbWS.AllPlayerNames(true);
            
            for (int i = 0; i < coaches.Length; i++)
            {
                for (int j = 0; j < players.Length; j++)
                {
                    if (DropDownList1.Text == coaches[i].sCoachName && players[j].sCountryName == coaches[i].sTeamName)
                    {
                        Label1.Text = "<br>"  + coaches[i].sTeamName;
                        Image1.ImageUrl = players[j].sCountryFlag;
                    }
                }
                
            }
            
            
            
        }
    }
}