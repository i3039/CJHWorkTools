/**  版本信息模板在安装目录下，可自行修改。
* Common_Strings.cs
*
* 功 能： N/A
* 类 名： Common_Strings
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/7/25 12:01:58   N/A    初版
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
	/// 常用字符串集
	/// </summary>
	[Serializable]
	public partial class Common_Strings
	{
		public Common_Strings()
		{}
		#region Model
		private int _id;
		private string _common_string;
		private string _string_class;
		private string _string_name;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 常用字符串
		/// </summary>
		public string Common_String
		{
			set{ _common_string=value;}
			get{return _common_string;}
		}
		/// <summary>
		/// 字符串类别
		/// </summary>
		public string String_Class
		{
			set{ _string_class=value;}
			get{return _string_class;}
		}
		/// <summary>
		/// 类型名称
		/// </summary>
		public string String_Name
		{
			set{ _string_name=value;}
			get{return _string_name;}
		}
		#endregion Model

	}
}

