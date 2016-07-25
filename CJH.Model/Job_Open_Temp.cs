/**  版本信息模板在安装目录下，可自行修改。
* Job_Open_Temp.cs
*
* 功 能： N/A
* 类 名： Job_Open_Temp
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/7/25 12:02:01   N/A    初版
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
	/// 开户登记信息
	/// </summary>
	[Serializable]
	public partial class Job_Open_Temp
	{
		public Job_Open_Temp()
		{}
		#region Model
		private int _id;
		private string _job_code;
		private string _group_name;
		private string _scid;
		private string _caid;
		private DateTime? _boarding_time= DateTime.Now;
		private DateTime? _open_time;
		private int _state=0;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 开户工号
		/// </summary>
		public string Job_Code
		{
			set{ _job_code=value;}
			get{return _job_code;}
		}
		/// <summary>
		/// 编组名称
		/// </summary>
		public string Group_Name
		{
			set{ _group_name=value;}
			get{return _group_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SCID
		{
			set{ _scid=value;}
			get{return _scid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CAID
		{
			set{ _caid=value;}
			get{return _caid;}
		}
		/// <summary>
		/// 登记时间
		/// </summary>
		public DateTime? Boarding_Time
		{
			set{ _boarding_time=value;}
			get{return _boarding_time;}
		}
		/// <summary>
		/// 开户日期
		/// </summary>
		public DateTime? Open_Time
		{
			set{ _open_time=value;}
			get{return _open_time;}
		}
		/// <summary>
		/// 状态：0=登记,1=已开卡,2=已安装
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		#endregion Model

	}
}

