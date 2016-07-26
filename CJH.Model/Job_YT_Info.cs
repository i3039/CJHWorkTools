/**  版本信息模板在安装目录下，可自行修改。
* Job_YT_Info.cs
*
* 功 能： N/A
* 类 名： Job_YT_Info
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/7/25 12:02:02   N/A    初版
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
	/// 移机替换记录
	/// </summary>
	[Serializable]
	public partial class Job_YT_Info
	{
		public Job_YT_Info()
		{}
		#region Model
		private int _id;
		private int _state=0;
		private string _job_code;
		private string _scid;
		private string _caid;
		private string _board_model;
		private string _address;
		private string _old_scid;
		private string _old_caid;
		private DateTime _boarding_time= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 记录类型：0=移机,1=替换机
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
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
		/// 品牌型号
		/// </summary>
		public string Board_Model
		{
			set{ _board_model=value;}
			get{return _board_model;}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Old_SCID
		{
			set{ _old_scid=value;}
			get{return _old_scid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Old_CAID
		{
			set{ _old_caid=value;}
			get{return _old_caid;}
		}
		/// <summary>
		/// 登记时间
		/// </summary>
		public DateTime Boarding_Time
		{
			set{ _boarding_time=value;}
			get{return _boarding_time;}
		}
		#endregion Model

	}
}

