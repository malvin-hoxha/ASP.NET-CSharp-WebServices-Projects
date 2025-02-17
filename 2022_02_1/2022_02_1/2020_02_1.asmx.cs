using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _2022_02_1
{
    /// <summary>
    /// Summary description for _2020_02_1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class _2020_02_1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string REPLACE(String sentence, String replaced1, String replaced2)
        {
            return sentence.Replace(replaced1, replaced2);
        }
    }
}
