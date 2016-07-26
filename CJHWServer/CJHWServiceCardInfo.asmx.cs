using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace CJH.CJHWServer
{
    /// <summary>
    /// CJHWServiceCardInfo 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class CJHWServiceCardInfo : System.Web.Services.WebService
    {

        [WebMethod(Description = "查询卡或机子的开户信息")]
        [ScriptMethod(UseHttpGet = false)]
        public string GetCardInfo(string code)
        {
            return "Hello World";
        }

        [WebMethod(Description="保存开户信息")]
        //[]
        public bool SaveCardInfo(string json)
        {
            bool result = false;

            return result;
        }
    }
}
