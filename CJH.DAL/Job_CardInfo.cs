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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace CJH.DAL
{
	/// <summary>
	/// 数据访问类:Job_CardInfo
	/// </summary>
	public partial class Job_CardInfo
	{
		public Job_CardInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string HHT_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Job_CardInfo");
			strSql.Append(" where HHT_ID=@HHT_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@HHT_ID", SqlDbType.NVarChar,20)			};
			parameters[0].Value = HHT_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CJH.Model.Job_CardInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Job_CardInfo(");
			strSql.Append("Job_Code,HHT_ID,Customer,State,SCID,CAID,Board,Address,Open_Time)");
			strSql.Append(" values (");
			strSql.Append("@Job_Code,@HHT_ID,@Customer,@State,@SCID,@CAID,@Board,@Address,@Open_Time)");
			SqlParameter[] parameters = {
					new SqlParameter("@Job_Code", SqlDbType.NVarChar,30),
					new SqlParameter("@HHT_ID", SqlDbType.NVarChar,20),
					new SqlParameter("@Customer", SqlDbType.NVarChar,10),
					new SqlParameter("@State", SqlDbType.NVarChar,10),
					new SqlParameter("@SCID", SqlDbType.NVarChar,12),
					new SqlParameter("@CAID", SqlDbType.NVarChar,11),
					new SqlParameter("@Board", SqlDbType.NVarChar,30),
					new SqlParameter("@Address", SqlDbType.NVarChar,50),
					new SqlParameter("@Open_Time", SqlDbType.DateTime)};
			parameters[0].Value = model.Job_Code;
			parameters[1].Value = model.HHT_ID;
			parameters[2].Value = model.Customer;
			parameters[3].Value = model.State;
			parameters[4].Value = model.SCID;
			parameters[5].Value = model.CAID;
			parameters[6].Value = model.Board;
			parameters[7].Value = model.Address;
			parameters[8].Value = model.Open_Time;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CJH.Model.Job_CardInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Job_CardInfo set ");
			strSql.Append("Job_Code=@Job_Code,");
			strSql.Append("Customer=@Customer,");
			strSql.Append("State=@State,");
			strSql.Append("SCID=@SCID,");
			strSql.Append("CAID=@CAID,");
			strSql.Append("Board=@Board,");
			strSql.Append("Address=@Address,");
			strSql.Append("Open_Time=@Open_Time");
			strSql.Append(" where HHT_ID=@HHT_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Job_Code", SqlDbType.NVarChar,30),
					new SqlParameter("@Customer", SqlDbType.NVarChar,10),
					new SqlParameter("@State", SqlDbType.NVarChar,10),
					new SqlParameter("@SCID", SqlDbType.NVarChar,12),
					new SqlParameter("@CAID", SqlDbType.NVarChar,11),
					new SqlParameter("@Board", SqlDbType.NVarChar,30),
					new SqlParameter("@Address", SqlDbType.NVarChar,50),
					new SqlParameter("@Open_Time", SqlDbType.DateTime),
					new SqlParameter("@HHT_ID", SqlDbType.NVarChar,20)};
			parameters[0].Value = model.Job_Code;
			parameters[1].Value = model.Customer;
			parameters[2].Value = model.State;
			parameters[3].Value = model.SCID;
			parameters[4].Value = model.CAID;
			parameters[5].Value = model.Board;
			parameters[6].Value = model.Address;
			parameters[7].Value = model.Open_Time;
			parameters[8].Value = model.HHT_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string HHT_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Job_CardInfo ");
			strSql.Append(" where HHT_ID=@HHT_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@HHT_ID", SqlDbType.NVarChar,20)			};
			parameters[0].Value = HHT_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string HHT_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Job_CardInfo ");
			strSql.Append(" where HHT_ID in ("+HHT_IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CJH.Model.Job_CardInfo GetModel(string HHT_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Job_Code,HHT_ID,Customer,State,SCID,CAID,Board,Address,Open_Time from Job_CardInfo ");
			strSql.Append(" where HHT_ID=@HHT_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@HHT_ID", SqlDbType.NVarChar,20)			};
			parameters[0].Value = HHT_ID;

			CJH.Model.Job_CardInfo model=new CJH.Model.Job_CardInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CJH.Model.Job_CardInfo DataRowToModel(DataRow row)
		{
			CJH.Model.Job_CardInfo model=new CJH.Model.Job_CardInfo();
			if (row != null)
			{
				if(row["Job_Code"]!=null)
				{
					model.Job_Code=row["Job_Code"].ToString();
				}
				if(row["HHT_ID"]!=null)
				{
					model.HHT_ID=row["HHT_ID"].ToString();
				}
				if(row["Customer"]!=null)
				{
					model.Customer=row["Customer"].ToString();
				}
				if(row["State"]!=null)
				{
					model.State=row["State"].ToString();
				}
				if(row["SCID"]!=null)
				{
					model.SCID=row["SCID"].ToString();
				}
				if(row["CAID"]!=null)
				{
					model.CAID=row["CAID"].ToString();
				}
				if(row["Board"]!=null)
				{
					model.Board=row["Board"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["Open_Time"]!=null && row["Open_Time"].ToString()!="")
				{
					model.Open_Time=DateTime.Parse(row["Open_Time"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Job_Code,HHT_ID,Customer,State,SCID,CAID,Board,Address,Open_Time ");
			strSql.Append(" FROM Job_CardInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Job_Code,HHT_ID,Customer,State,SCID,CAID,Board,Address,Open_Time ");
			strSql.Append(" FROM Job_CardInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Job_CardInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.HHT_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Job_CardInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Job_CardInfo";
			parameters[1].Value = "HHT_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

