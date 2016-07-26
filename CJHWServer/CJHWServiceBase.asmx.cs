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
        BLL.HHT_Area hhtAreaBLL = new BLL.HHT_Area();

        [WebMethod(Description="根据地区编码查询地名")]
        [ScriptMethod(UseHttpGet = false)]
        public string GetAreaName(string code)
        {
            return Common.JsonHelper.Serialize(areaBLL.GetAllName(code));
            //return Common.JsonHelper.GetJosn<List<Model.Base_Area>>(areaBLL.GetAllName(code));
        }

        [WebMethod(Description = "根据地名查询地区编码")]
        [ScriptMethod(UseHttpGet = false)]
        public string GetAreaCode(string areaname)
        {
            //return Common.JsonHelper.Serialize(areaBLL.GetAreaCode(areaname));
            return Common.JsonHelper.GetJosn<List<Model.Base_Area>>(areaBLL.GetAreaCode(areaname));
        }

        [WebMethod(Description = "获取省级列表")]
        [ScriptMethod(UseHttpGet = false)]
        public string GetProvinces()
        {
            //return Common.JsonHelper.Serialize(areaBLL.GetProvince());
            return Common.JsonHelper.GetJosn<List<Model.Base_Area>>(areaBLL.GetProvince());
        }

        [WebMethod(Description = "获取地市级列表")]
        [ScriptMethod(UseHttpGet = false)]
        public string GetCity(string pcode)
        {
            //return Common.JsonHelper.Serialize(areaBLL.GetAreaList(pcode, 2));
            return Common.JsonHelper.GetJosn<List<Model.Base_Area>>(areaBLL.GetAreaList(pcode, 2));
        }

        [WebMethod(Description = "获取区县级列表")]
        [ScriptMethod(UseHttpGet = false)]
        public string GetCounty(string pcode)
        {
            //return Common.JsonHelper.Serialize(areaBLL.GetAreaList(pcode, 3));
            return Common.JsonHelper.GetJosn<List<Model.Base_Area>>(areaBLL.GetAreaList(pcode, 3));
        }

        [WebMethod(Description="保存户户通乡镇村信息")]
        [ScriptMethod(UseHttpGet = false)]
        public string SaveHHTArea(string value)
        {
            string result = "OK";

            Model.HHT_Area hhtArea = Common.JsonHelper.ParseFormJson<Model.HHT_Area>(value);
            result = (hhtAreaBLL.Add(hhtArea)) ? "OK" : "增加失败";

            return result;
        }

        [WebMethod(Description = "获取户户通编码对应说明")]
        [ScriptMethod(UseHttpGet = false)]
        public string GetHHTAreaRemark(string value)
        {
            string result = "";

            if (value.Length > 6)
            {
                //Model.HHT_Area 
            }
            return result;
        }

        [WebMethod(Description = "获取户户通编码指定乡镇列表")]
        [ScriptMethod(UseHttpGet = false)]
        public string GetHHTAreaList(string value)
        {
            //if (value.Length >= 9)
            //{
            //    //Model.HHT_Area 
            //}
            return Common.JsonHelper.GetJosn<List<Model.HHT_Area>>(hhtAreaBLL.GetHHTAreaList(value));
        }
    }

    
}


