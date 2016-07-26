using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace CJH.CJHWServer
{
    /// <summary>
    /// CJHWServiceCode 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class CJHWServiceCode : System.Web.Services.WebService
    {
        BLL.Job_HHTCode jcodeBLL = new BLL.Job_HHTCode();

        [WebMethod(Description = "根据地区编码查询工号")]
        [ScriptMethod(UseHttpGet = false)]
        public string GetJobCodeByArea(string areacode)
        {
            string strCode = Common.StringHelper.GetAreaDelZero(areacode);
            return Common.JsonHelper.Serialize(jcodeBLL.GetModelList(" Area_Code like '" + strCode + "%'"));
        }
    }
}
