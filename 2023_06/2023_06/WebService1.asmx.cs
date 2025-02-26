using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _2023_06
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
        
        [WebMethod]
        public (int result1, int result2) intDivision(int num1, int num2)
        {
            
            int result2;
            result2 =  Math.DivRem(num1, num2, out int result1);
            return (result1,result2);   
        }

        public String MiddleWord(String word)
        {
            int firstSpaceIndex = word.IndexOf(' ');
            string sentence = word.Remove(0, firstSpaceIndex + 1);
            int secondSpaceIndex = sentence.IndexOf(' ');
            string middleWord = sentence.Remove(secondSpaceIndex);

            return middleWord;
        }
    }
}
