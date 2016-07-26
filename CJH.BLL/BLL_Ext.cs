using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CJH.BLL
{
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

    //public partial class 
}
