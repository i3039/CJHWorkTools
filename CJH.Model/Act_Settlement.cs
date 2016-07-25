/**  版本信息模板在安装目录下，可自行修改。
* Act_Settlement.cs
*
* 功 能： N/A
* 类 名： Act_Settlement
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/7/25 12:01:57   N/A    初版
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
	/// 帐务明细
	/// </summary>
	[Serializable]
	public partial class Act_Settlement
	{
		public Act_Settlement()
		{}
		#region Model
		private int _id;
		private DateTime? _section_start;
		private DateTime? _section_end;
		private decimal? _balance;
		private decimal? _curr_balance;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 结算开始日期
		/// </summary>
		public DateTime? Section_Start
		{
			set{ _section_start=value;}
			get{return _section_start;}
		}
		/// <summary>
		/// 结算结束日期
		/// </summary>
		public DateTime? Section_End
		{
			set{ _section_end=value;}
			get{return _section_end;}
		}
		/// <summary>
		/// 上期余额
		/// </summary>
		public decimal? Balance
		{
			set{ _balance=value;}
			get{return _balance;}
		}
		/// <summary>
		/// 本期余额
		/// </summary>
		public decimal? Curr_Balance
		{
			set{ _curr_balance=value;}
			get{return _curr_balance;}
		}
		#endregion Model

	}
}

