/**  版本信息模板在安装目录下，可自行修改。
* HHT_Address.cs
*
* 功 能： N/A
* 类 名： HHT_Address
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/6/14 11:39:45   N/A    初版
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
	/// HHT_Address:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HHT_Address
	{
		public HHT_Address()
		{}
		#region Model
		private int _id;
		private string _old_address;
		private string _new_address;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 系统地址
		/// </summary>
		public string Old_Address
		{
			set{ _old_address=value;}
			get{return _old_address;}
		}
		/// <summary>
		/// 简化地址
		/// </summary>
		public string New_Address
		{
			set{ _new_address=value;}
			get{return _new_address;}
		}
		#endregion Model

	}
}

