/**  版本信息模板在安装目录下，可自行修改。
* Act_Common.cs
*
* 功 能： N/A
* 类 名： Act_Common
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/7/25 12:01:54   N/A    初版
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
	/// 帐务常用
	/// </summary>
	[Serializable]
	public partial class Act_Common
	{
		public Act_Common()
		{}
		#region Model
		private int _id;
		private string _itemname;
		private int _state;
		private decimal? _unit_price=0M;
		private int? _quantity=0;
		private decimal _money=0M;
		private DateTime? _info_date;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 说明
		/// </summary>
		public string ItemName
		{
			set{ _itemname=value;}
			get{return _itemname;}
		}
		/// <summary>
		/// 类型：0=支, 1=收
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 单价
		/// </summary>
		public decimal? Unit_Price
		{
			set{ _unit_price=value;}
			get{return _unit_price;}
		}
		/// <summary>
		/// 数量
		/// </summary>
		public int? Quantity
		{
			set{ _quantity=value;}
			get{return _quantity;}
		}
		/// <summary>
		/// 金额
		/// </summary>
		public decimal Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 发生日期
		/// </summary>
		public DateTime? Info_Date
		{
			set{ _info_date=value;}
			get{return _info_date;}
		}
		#endregion Model

	}
}

