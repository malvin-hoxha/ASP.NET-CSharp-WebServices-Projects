﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _2020_06_Ε
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        string[] PLACES = new string[3] { "ios", "thira", "kos" };
        [WebMethod]
        public int Vrisko(String lexi)
        {
            for (int i = 0;i< PLACES.Length; i++)
            {
                if (lexi == PLACES[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
