using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;  
using System.Web.Services;

namespace CJH.CJHWServer
{
    /// <summary>
    /// CJHWServiceBase 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class CJHWServiceBase : System.Web.Services.WebService
    {
        //Common.JsonHelper jsonHelper = new Common.JsonHelper();
        BLL.Base_Area areaBLL = new BLL.Base_Area();

        [WebMethod(Description="根据地区编码查询地名")]
        [ScriptMethod(UseHttpGet = false)]
        public string GetAreaName(string code)
        {
            return Common.JsonHelper.Serialize(areaBLL.GetAllName(code));
        }
    }
}


