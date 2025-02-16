using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _2021_09_ΕΘ
{
    /// <summary>
    /// Summary description for _2021_09_ΕΘ
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class _2021_09_ΕΘ : System.Web.Services.WebService
    {

        [WebMethod]
        public string SUBSTRING(String sentence1,String sentence2, int plithos)
        {
            return sentence1.Substring(0, plithos) + sentence2.Substring(sentence2.Length - plithos);
        }
    }
}
