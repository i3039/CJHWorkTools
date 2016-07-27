using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CJH.BLL
{
    #region 地区相关
    public partial class Base_Area
    {
        #region Ext

        /// <summary>
        /// 根据编码得到完整地址
        /// </summary>
        public string GetAllName(string code)
        {
            string pname = "", ciname = "", coname = "";
            Model.Base_Area m = dal.GetModel(code);
            if (m != null)
            {
                if (m.Area_Level == 1)
                {
                    pname = m.AreaName;
                }
                else if (m.Area_Level == 2)
                {
                    Model.Base_Area pm = dal.GetModel(code.Substring(0, 2) + "0000");
                    pname = pm.AreaName;
                    ciname = m.AreaName;
                }
                else if (m.Area_Level == 3)
                {
                    Model.Base_Area pm = dal.GetModel(code.Substring(0, 2) + "0000");
                    Model.Base_Area cm = dal.GetModel(code.Substring(0, 4) + "00");
                    pname = pm.AreaName;
                    ciname = cm.AreaName;
                    coname = m.AreaName;
                }
            }

            return pname + "" + ciname + "" + coname;
        }

        /// <summary>
        /// 根据编码得到准确匹配地址
        /// </summary>
        public string GetTheName(string code)
        {
            Model.Base_Area m = dal.GetModel(code);
            if (m != null)
            {
                return m.AreaName;
            }

            return "";
        }

        public List<Model.Base_Area> GetAreaCode(string areaname)
        {
            return GetModelList(" AreaName like '" + areaname + "%' ");
        }

        /// <summary>
        /// 获取省级列表
        /// </summary>
        /// <returns></returns>
        public List<Model.Base_Area> GetProvince()
        {
            return GetModelList(" Area_Level=1 ");
        }

        /// <summary>
        /// 获取下级区域列表
        /// </summary>
        /// <param name="pcode">父地区</param>
        /// <param name="level">地区级别</param>
        /// <returns></returns>
        public List<Model.Base_Area> GetAreaList(string pcode, int level)
        {
            if (level == 2)
            {
                pcode = pcode.Substring(0, 2);
            }
            else if (level == 3)
            {
                pcode = pcode.Substring(0, 4);
            }
            return GetModelList(" Code like '" + pcode + "%' and Area_Level=" + level);
        }

        #endregion Ext
    }

    public partial class HHT_Area
    {
        #region Ext

        public List<Model.HHT_Area> GetHHTAreaList(string pcode)
        {
            pcode = pcode.Substring(0, 9);
            return GetModelList(" Code like '" + pcode + "%'");
        }

        public List<Model.HHT_Area> GetHHTAreaListByName(string name)
        {
            return GetModelList(" AreaName like '%" + name + "%'");
        }

        #endregion Ext
    }

    #endregion 地区相关
    

    public partial class Job_CardInfo
    {
        #region Ext



        #endregion Ext
    }

    public partial class Job_YT_Info
    {
        #region Ext

        public List<Model.Job_YT_Info> GetYTList(string code)
        {
            string strWhere = "";
            if (code.Length == 11)
            {
                strWhere = string.Format(" CAID='{0}' or Old_CAID='{0}'", code);
            }
            else
            {
                strWhere = string.Format(" SCID='{0}' or Old_SCID='{0}'", code);
            }
            //strWhere = (code.Length == 11) ? "CAID=" : "SCID=";
            return GetModelList(strWhere);
        }

        public string SaveYTInfo(string jsonStr)
        {
            Model.Job_YT_Info ytM = Common.JsonHelper.ParseFormJson<Model.Job_YT_Info>(jsonStr);
            int id = dal.Add(ytM);

            if (id > 0)
            {
                return "OK";
            }
            else
            {
                return "Error";
            }
        }

        #endregion Ext
    }

    public partial class Job_Open_Temp
    {
        #region Ext
        #endregion Ext
    }

    public partial class Common_Strings
    {
        #region Ext

        /// <summary>
        /// 获取常用字符集
        /// </summary>
        /// <returns></returns>
        public string GetCommonString(int id)
        {
            Model.Common_Strings commStrM = dal.GetModel(id);

            return commStrM.Common_String;
        }

        #endregion Ext
    }
    /*
     DataSet ds = dal.GetList(strWhere);
            DataTable dt = ds.Tables[0];

            List<CJH.Model.Customer> modelList = new List<CJH.Model.Customer>();
            Model.Customer cm = new Model.Customer();
            cm.Area_Name = "贵州";
            cm.Cust_Name = "请选择";
            cm.ID = 0;
            modelList.Add(cm);

            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                CJH.Model.Customer model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
     */
}
