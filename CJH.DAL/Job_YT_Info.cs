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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace CJH.DAL
{
	/// <summary>
	/// 数据访问类:Job_YT_Info
	/// </summary>
	public partial class Job_YT_Info
	{
		public Job_YT_Info()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Job_YT_Info"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Job_YT_Info");
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
		public int Add(CJH.Model.Job_YT_Info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Job_YT_Info(");
			strSql.Append("State,Job_Code,SCID,CAID,Board_Model,Address,Old_SCID,Old_CAID,Boarding_Time)");
			strSql.Append(" values (");
			strSql.Append("@State,@Job_Code,@SCID,@CAID,@Board_Model,@Address,@Old_SCID,@Old_CAID,@Boarding_Time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Job_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@SCID", SqlDbType.NVarChar,12),
					new SqlParameter("@CAID", SqlDbType.NVarChar,11),
					new SqlParameter("@Board_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Address", SqlDbType.NVarChar,100),
					new SqlParameter("@Old_SCID", SqlDbType.NVarChar,12),
					new SqlParameter("@Old_CAID", SqlDbType.NVarChar,11),
					new SqlParameter("@Boarding_Time", SqlDbType.DateTime)};
			parameters[0].Value = model.State;
			parameters[1].Value = model.Job_Code;
			parameters[2].Value = model.SCID;
			parameters[3].Value = model.CAID;
			parameters[4].Value = model.Board_Model;
			parameters[5].Value = model.Address;
			parameters[6].Value = model.Old_SCID;
			parameters[7].Value = model.Old_CAID;
			parameters[8].Value = model.Boarding_Time;

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
		public bool Update(CJH.Model.Job_YT_Info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Job_YT_Info set ");
			strSql.Append("State=@State,");
			strSql.Append("Job_Code=@Job_Code,");
			strSql.Append("SCID=@SCID,");
			strSql.Append("CAID=@CAID,");
			strSql.Append("Board_Model=@Board_Model,");
			strSql.Append("Address=@Address,");
			strSql.Append("Old_SCID=@Old_SCID,");
			strSql.Append("Old_CAID=@Old_CAID,");
			strSql.Append("Boarding_Time=@Boarding_Time");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Job_Code", SqlDbType.NVarChar,50),
					new SqlParameter("@SCID", SqlDbType.NVarChar,12),
					new SqlParameter("@CAID", SqlDbType.NVarChar,11),
					new SqlParameter("@Board_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Address", SqlDbType.NVarChar,100),
					new SqlParameter("@Old_SCID", SqlDbType.NVarChar,12),
					new SqlParameter("@Old_CAID", SqlDbType.NVarChar,11),
					new SqlParameter("@Boarding_Time", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.State;
			parameters[1].Value = model.Job_Code;
			parameters[2].Value = model.SCID;
			parameters[3].Value = model.CAID;
			parameters[4].Value = model.Board_Model;
			parameters[5].Value = model.Address;
			parameters[6].Value = model.Old_SCID;
			parameters[7].Value = model.Old_CAID;
			parameters[8].Value = model.Boarding_Time;
			parameters[9].Value = model.ID;

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
			strSql.Append("delete from Job_YT_Info ");
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
			strSql.Append("delete from Job_YT_Info ");
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
		public CJH.Model.Job_YT_Info GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,State,Job_Code,SCID,CAID,Board_Model,Address,Old_SCID,Old_CAID,Boarding_Time from Job_YT_Info ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			CJH.Model.Job_YT_Info model=new CJH.Model.Job_YT_Info();
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
		public CJH.Model.Job_YT_Info DataRowToModel(DataRow row)
		{
			CJH.Model.Job_YT_Info model=new CJH.Model.Job_YT_Info();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
				}
				if(row["Job_Code"]!=null)
				{
					model.Job_Code=row["Job_Code"].ToString();
				}
				if(row["SCID"]!=null)
				{
					model.SCID=row["SCID"].ToString();
				}
				if(row["CAID"]!=null)
				{
					model.CAID=row["CAID"].ToString();
				}
				if(row["Board_Model"]!=null)
				{
					model.Board_Model=row["Board_Model"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["Old_SCID"]!=null)
				{
					model.Old_SCID=row["Old_SCID"].ToString();
				}
				if(row["Old_CAID"]!=null)
				{
					model.Old_CAID=row["Old_CAID"].ToString();
				}
				if(row["Boarding_Time"]!=null && row["Boarding_Time"].ToString()!="")
				{
					model.Boarding_Time=DateTime.Parse(row["Boarding_Time"].ToString());
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
			strSql.Append("select ID,State,Job_Code,SCID,CAID,Board_Model,Address,Old_SCID,Old_CAID,Boarding_Time ");
			strSql.Append(" FROM Job_YT_Info ");
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
			strSql.Append(" ID,State,Job_Code,SCID,CAID,Board_Model,Address,Old_SCID,Old_CAID,Boarding_Time ");
			strSql.Append(" FROM Job_YT_Info ");
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
			strSql.Append("select count(1) FROM Job_YT_Info ");
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
			strSql.Append(")AS Row, T.*  from Job_YT_Info T ");
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
			parameters[0].Value = "Job_YT_Info";
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

