using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Services;

namespace _2023_02_1
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
        public int num;

        [WebMethod]
        public int AkeraiaDiairesi(int num1,int num2)
        {
            int result;
            num = Math.DivRem(num1, num2, out result);
            return result;
        }

        public String EndiamesiLexi(String word)
        {
            String sentence;
            int index1 = word.IndexOf(' ');
            sentence = word.Remove(0, index1+1);
            int index2 = sentence.IndexOf(' ');
            return sentence.Remove(index2);
        }
    }
}
