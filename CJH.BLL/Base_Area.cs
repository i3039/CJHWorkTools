﻿/**  版本信息模板在安装目录下，可自行修改。
* Base_Area.cs
*
* 功 能： N/A
* 类 名： Base_Area
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
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using CJH.Model;
namespace CJH.BLL
{
	/// <summary>
	/// 国标行政区划
	/// </summary>
	public partial class Base_Area
	{
		private readonly CJH.DAL.Base_Area dal=new CJH.DAL.Base_Area();
		public Base_Area()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Code)
		{
			return dal.Exists(Code);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CJH.Model.Base_Area model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CJH.Model.Base_Area model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string Code)
		{
			
			return dal.Delete(Code);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Codelist )
		{
			return dal.DeleteList(Codelist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CJH.Model.Base_Area GetModel(string Code)
		{
			
			return dal.GetModel(Code);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public CJH.Model.Base_Area GetModelByCache(string Code)
		{
			
			string CacheKey = "Base_AreaModel-" + Code;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Code);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (CJH.Model.Base_Area)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CJH.Model.Base_Area> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<CJH.Model.Base_Area> DataTableToList(DataTable dt)
		{
			List<CJH.Model.Base_Area> modelList = new List<CJH.Model.Base_Area>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				CJH.Model.Base_Area model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

