using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _2021
{
    /// <summary>
    /// Summary description for _2021
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class _2021 : System.Web.Services.WebService
    {

        [WebMethod]
        public double SQRT(double num)
        {
            return Math.Sqrt(num);
        }

        public double CEIL(double num)
        {
            return Math.Ceiling(num);
        }
    }
}
