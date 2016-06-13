/**  版本信息模板在安装目录下，可自行修改。
* HHT_Area.cs
*
* 功 能： N/A
* 类 名： HHT_Area
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/6/12 10:53:26   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace CJH.Model
{
	/// <summary>
	/// HHT_Area:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HHT_Area
	{
		public HHT_Area()
		{}
		#region Model
		private string _code;
		private int _area_level;
		private string _areaname;
		private int _isuse=0;
		private int _data_count=0;
		private string _end_hhtid;
		private int _cancel_count=0;
		private string _c_end_hhtid;
		/// <summary>
		/// 地区编码
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 地区等级
		/// </summary>
		public int Area_Level
		{
			set{ _area_level=value;}
			get{return _area_level;}
		}
		/// <summary>
		/// 地区名称
		/// </summary>
		public string AreaName
		{
			set{ _areaname=value;}
			get{return _areaname;}
		}
		/// <summary>
		/// 是否使用
		/// </summary>
		public int IsUse
		{
			set{ _isuse=value;}
			get{return _isuse;}
		}
		/// <summary>
		/// 数量
		/// </summary>
		public int Data_Count
		{
			set{ _data_count=value;}
			get{return _data_count;}
		}
		/// <summary>
		/// HHTID
		/// </summary>
		public string End_HHTID
		{
			set{ _end_hhtid=value;}
			get{return _end_hhtid;}
		}
		/// <summary>
		/// 销户数量
		/// </summary>
		public int Cancel_Count
		{
			set{ _cancel_count=value;}
			get{return _cancel_count;}
		}
		/// <summary>
		/// 销户末HHTID
		/// </summary>
		public string C_End_HHTID
		{
			set{ _c_end_hhtid=value;}
			get{return _c_end_hhtid;}
		}
		#endregion Model

	}
}

