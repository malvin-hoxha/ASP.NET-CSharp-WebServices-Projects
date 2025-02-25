using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _2023_02_3
{
    /// <summary>
    /// Summary description for Sept2023Exams
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Sept2023Exams : System.Web.Services.WebService
    {

        [WebMethod]
        public String Zigos(int number)
        {
            if (number % 2 == 0)
            {
                return "Ζυγός Αριθμός";
            }
            return "Μονός Αριθμός";
        }
    }
}
