using System;
namespace CJH.Model
{
    /// <summary>
    /// 户户通地区编码
    /// </summary>
    [Serializable]
    public partial class HHT_Area
    {
        public HHT_Area()
        { }
        #region Model
        private string _code;
        private int _area_level;
        private string _areaname;
        /// <summary>
        /// 地区编码
        /// </summary>
        public string Code
        {
            set { _code = value; }
            get { return _code; }
        }
        /// <summary>
        /// 地区等级
        /// </summary>
        public int Area_Level
        {
            set { _area_level = value; }
            get { return _area_level; }
        }
        /// <summary>
        /// 地区名称
        /// </summary>
        public string AreaName
        {
            set { _areaname = value; }
            get { return _areaname; }
        }
        #endregion Model

    }
}

