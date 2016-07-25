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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace CJH.DAL
{
	/// <summary>
	/// 数据访问类:Job_Open_Temp
	/// </summary>
	public partial class Job_Open_Temp
	{
		public Job_Open_Temp()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Job_Open_Temp"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Job_Open_Temp");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(CJH.Model.Job_Open_Temp model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Job_Open_Temp(");
			strSql.Append("Job_Code,Group_Name,SCID,CAID,Boarding_Time,Open_Time,State)");
			strSql.Append(" values (");
			strSql.Append("@Job_Code,@Group_Name,@SCID,@CAID,@Boarding_Time,@Open_Time,@State)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Job_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Group_Name", SqlDbType.NVarChar,20),
					new SqlParameter("@SCID", SqlDbType.NVarChar,12),
					new SqlParameter("@CAID", SqlDbType.NVarChar,11),
					new SqlParameter("@Boarding_Time", SqlDbType.DateTime),
					new SqlParameter("@Open_Time", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4)};
			parameters[0].Value = model.Job_Code;
			parameters[1].Value = model.Group_Name;
			parameters[2].Value = model.SCID;
			parameters[3].Value = model.CAID;
			parameters[4].Value = model.Boarding_Time;
			parameters[5].Value = model.Open_Time;
			parameters[6].Value = model.State;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(CJH.Model.Job_Open_Temp model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Job_Open_Temp set ");
			strSql.Append("Job_Code=@Job_Code,");
			strSql.Append("Group_Name=@Group_Name,");
			strSql.Append("SCID=@SCID,");
			strSql.Append("CAID=@CAID,");
			strSql.Append("Boarding_Time=@Boarding_Time,");
			strSql.Append("Open_Time=@Open_Time,");
			strSql.Append("State=@State");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Job_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@Group_Name", SqlDbType.NVarChar,20),
					new SqlParameter("@SCID", SqlDbType.NVarChar,12),
					new SqlParameter("@CAID", SqlDbType.NVarChar,11),
					new SqlParameter("@Boarding_Time", SqlDbType.DateTime),
					new SqlParameter("@Open_Time", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Job_Code;
			parameters[1].Value = model.Group_Name;
			parameters[2].Value = model.SCID;
			parameters[3].Value = model.CAID;
			parameters[4].Value = model.Boarding_Time;
			parameters[5].Value = model.Open_Time;
			parameters[6].Value = model.State;
			parameters[7].Value = model.ID;

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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Job_Open_Temp ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Job_Open_Temp ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public CJH.Model.Job_Open_Temp GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Job_Code,Group_Name,SCID,CAID,Boarding_Time,Open_Time,State from Job_Open_Temp ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			CJH.Model.Job_Open_Temp model=new CJH.Model.Job_Open_Temp();
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
		public CJH.Model.Job_Open_Temp DataRowToModel(DataRow row)
		{
			CJH.Model.Job_Open_Temp model=new CJH.Model.Job_Open_Temp();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Job_Code"]!=null)
				{
					model.Job_Code=row["Job_Code"].ToString();
				}
				if(row["Group_Name"]!=null)
				{
					model.Group_Name=row["Group_Name"].ToString();
				}
				if(row["SCID"]!=null)
				{
					model.SCID=row["SCID"].ToString();
				}
				if(row["CAID"]!=null)
				{
					model.CAID=row["CAID"].ToString();
				}
				if(row["Boarding_Time"]!=null && row["Boarding_Time"].ToString()!="")
				{
					model.Boarding_Time=DateTime.Parse(row["Boarding_Time"].ToString());
				}
				if(row["Open_Time"]!=null && row["Open_Time"].ToString()!="")
				{
					model.Open_Time=DateTime.Parse(row["Open_Time"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
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
			strSql.Append("select ID,Job_Code,Group_Name,SCID,CAID,Boarding_Time,Open_Time,State ");
			strSql.Append(" FROM Job_Open_Temp ");
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
			strSql.Append(" ID,Job_Code,Group_Name,SCID,CAID,Boarding_Time,Open_Time,State ");
			strSql.Append(" FROM Job_Open_Temp ");
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
			strSql.Append("select count(1) FROM Job_Open_Temp ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from Job_Open_Temp T ");
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
			parameters[0].Value = "Job_Open_Temp";
			parameters[1].Value = "ID";
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

