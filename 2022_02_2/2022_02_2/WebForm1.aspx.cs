using _2022_02_2.eu.dataaccess.footballpool.ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2022_02_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        eu.dataaccess.footballpool.ws.Info fbWS = new eu.dataaccess.footballpool.ws.Info();
        protected void Page_Load(object sender, EventArgs e)
        {
            eu.dataaccess.footballpool.ws.tTeamPlayerCardRankInfo[] can = fbWS.PlayersWithCardsRanked();
            eu.dataaccess.footballpool.ws.tPlayerName[] cann;

            for (int i = 0; i < can.Length; i++)
            {

                if (can[i].iRedCards > 0)
                {
                    cann = fbWS.AllPlayerNames(true);
                    for (int j = 0; j < cann.Length; j++)
                    {
                        if (can[i].sName == cann[j].sName)
                        {
                            Label1.Text = Label1.Text + " (" + can[i].sName + " " + cann[j].sCountryName + ") ";
                        }
                    }
                }

                
            }

            


        }
    }
}