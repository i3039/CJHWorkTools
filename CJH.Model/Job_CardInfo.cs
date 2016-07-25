/**  版本信息模板在安装目录下，可自行修改。
* Job_CardInfo.cs
*
* 功 能： N/A
* 类 名： Job_CardInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/7/25 12:01:59   N/A    初版
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
	/// 开户记录
	/// </summary>
	[Serializable]
	public partial class Job_CardInfo
	{
		public Job_CardInfo()
		{}
		#region Model
		private string _job_code;
		private string _hht_id;
		private string _customer;
		private string _state;
		private string _scid;
		private string _caid;
		private string _board;
		private string _address;
		private DateTime? _open_time;
		/// <summary>
		/// 工号
		/// </summary>
		public string Job_Code
		{
			set{ _job_code=value;}
			get{return _job_code;}
		}
		/// <summary>
		/// HHT_ID
		/// </summary>
		public string HHT_ID
		{
			set{ _hht_id=value;}
			get{return _hht_id;}
		}
		/// <summary>
		/// 注册用户名
		/// </summary>
		public string Customer
		{
			set{ _customer=value;}
			get{return _customer;}
		}
		/// <summary>
		/// 设备状态
		/// </summary>
		public string State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// SCID
		/// </summary>
		public string SCID
		{
			set{ _scid=value;}
			get{return _scid;}
		}
		/// <summary>
		/// CAID
		/// </summary>
		public string CAID
		{
			set{ _caid=value;}
			get{return _caid;}
		}
		/// <summary>
		/// 品牌型号
		/// </summary>
		public string Board
		{
			set{ _board=value;}
			get{return _board;}
		}
		/// <summary>
		/// 开户地址
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 开户日期
		/// </summary>
		public DateTime? Open_Time
		{
			set{ _open_time=value;}
			get{return _open_time;}
		}
		#endregion Model

	}
}

