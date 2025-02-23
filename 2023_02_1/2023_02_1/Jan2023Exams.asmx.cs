using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _2023_02_1
{
    /// <summary>
    /// Summary description for Jan2023Exams
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Jan2023Exams : System.Web.Services.WebService
    {

        [WebMethod]
        public (int, int) AkeraiaDiairesi(int number, int number1)
        {
            int num = Math.DivRem(number, number1, out int result);
            return (num, result);
        }

        public String EndiamesiLexi(String lexi)
        {
            int plithos = lexi.IndexOf(' ');
            String lexi2 = lexi.Remove(0, plithos+1);
            plithos = lexi2.IndexOf(' ');
            return lexi2.Remove(plithos);
        }

    }
}
