using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2022_02_2
{
    public partial class Form : System.Web.UI.Page
    {
        eu.dataaccess.footballpool.ws.Info fbs = new eu.dataaccess.footballpool.ws.Info();

        protected void Page_Load(object sender, EventArgs e)
        {
            eu.dataaccess.footballpool.ws.tTeamPlayerCardRankInfo[] TPCR = fbs.PlayersWithCardsRanked();
            eu.dataaccess.footballpool.ws.tPlayerName[] TPN = fbs.AllPlayerNames(true);

            for (int i = 0; i < TPCR.Length; i++)
            {
                if (TPCR[i].iRedCards>0)
                {
                    for (int j = 0; j < TPN.Length; j++)
                    {
                        if (TPCR[i].sName == TPN[j].sName)
                        {
                            Label1.Text = Label1.Text + "( " + TPCR[i].sName + " " + TPN[j].sCountryName + " ) ";
                        }
                    }
                }
            }

        }

    }
}