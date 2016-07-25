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
        /// 获取省级列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetProvince()
        {
            return dal.GetList(" Area_Level=1 ");
        }

        /// <summary>
        /// 获取下级区域列表
        /// </summary>
        /// <param name="pcode"></param>
        /// <returns></returns>
        public DataSet GetCity(string pcode)
        {
            return dal.GetList(" Code like '" + Common.StringHelper.GetAreaDelZero(pcode) + "%'");
        }

        #endregion Ext
    }

    //public partial class 
}
