using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //public string GetCode(string areaname)

        #endregion Ext
    }

    //public partial class 
}
