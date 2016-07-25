/**  版本信息模板在安装目录下，可自行修改。
* Job_HHTCode.cs
*
* 功 能： N/A
* 类 名： Job_HHTCode
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/7/25 12:02:00   N/A    初版
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
	/// 户户通工号
	/// </summary>
	[Serializable]
	public partial class Job_HHTCode
	{
		public Job_HHTCode()
		{}
		#region Model
		private int _id;
		private string _area_code;
		private string _job_code;
		private string _password;
		private int _ischild=0;
		private int _iscommon=0;
		private string _comm_code;
		private string _comm_pwd;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 地区编码
		/// </summary>
		public string Area_Code
		{
			set{ _area_code=value;}
			get{return _area_code;}
		}
		/// <summary>
		/// 工号
		/// </summary>
		public string Job_Code
		{
			set{ _job_code=value;}
			get{return _job_code;}
		}
		/// <summary>
		/// 密码
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 是否子工号
		/// </summary>
		public int IsChild
		{
			set{ _ischild=value;}
			get{return _ischild;}
		}
		/// <summary>
		/// 是否常用工号
		/// </summary>
		public int IsCommon
		{
			set{ _iscommon=value;}
			get{return _iscommon;}
		}
		/// <summary>
		/// 常用工号
		/// </summary>
		public string Comm_Code
		{
			set{ _comm_code=value;}
			get{return _comm_code;}
		}
		/// <summary>
		/// 常用密码
		/// </summary>
		public string Comm_PWD
		{
			set{ _comm_pwd=value;}
			get{return _comm_pwd;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

