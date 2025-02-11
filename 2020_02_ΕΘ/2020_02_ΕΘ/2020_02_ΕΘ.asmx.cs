using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _2020_02_ΕΘ
{
    /// <summary>
    /// Summary description for _2020_02_ΕΘ
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class _2020_02_ΕΘ : System.Web.Services.WebService
    {

        [WebMethod]
        public double THREE(double num)
        {
            return num*num*num;
        }

        public double POW(double num,double num2)
        {
            return Math.Pow(num,num2);
        }
    }
}
