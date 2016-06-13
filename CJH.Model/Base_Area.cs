/**  版本信息模板在安装目录下，可自行修改。
* Base_Area.cs
*
* 功 能： N/A
* 类 名： Base_Area
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/6/12 10:53:24   N/A    初版
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
	/// Base_Area:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Base_Area
	{
		public Base_Area()
		{}
		#region Model
		private string _code;
		private string _areaname;
		private int _area_level=1;
		/// <summary>
		/// 地区编码
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
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
		/// 地区等级
		/// </summary>
		public int Area_Level
		{
			set{ _area_level=value;}
			get{return _area_level;}
		}
		#endregion Model

	}
}

