﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Jium.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Jium.MySQLDAL
{
	/// <summary>
	/// 数据访问类:usertype
	/// </summary>
	public partial class usertype:Iusertype
	{
		public usertype()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("level", "usertype"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int level)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from usertype");
			strSql.Append(" where level=@level");
			MySqlParameter[] parameters = {
					new MySqlParameter("@level", MySqlDbType.Int16)
			};
			parameters[0].Value = level;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Jium.Model.usertype model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into usertype(");
			strSql.Append("tagname,authvalue)");
			strSql.Append(" values (");
			strSql.Append("@tagname,@authvalue)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@tagname", MySqlDbType.VarChar,20),
					new MySqlParameter("@authvalue", MySqlDbType.Int16,8)};
			parameters[0].Value = model.tagname;
			parameters[1].Value = model.authvalue;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(Jium.Model.usertype model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update usertype set ");
			strSql.Append("tagname=@tagname,");
			strSql.Append("authvalue=@authvalue");
			strSql.Append(" where level=@level");
			MySqlParameter[] parameters = {
					new MySqlParameter("@tagname", MySqlDbType.VarChar,20),
					new MySqlParameter("@authvalue", MySqlDbType.Int16,8),
					new MySqlParameter("@level", MySqlDbType.Int16,8)};
			parameters[0].Value = model.tagname;
			parameters[1].Value = model.authvalue;
			parameters[2].Value = model.level;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int level)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from usertype ");
			strSql.Append(" where level=@level");
			MySqlParameter[] parameters = {
					new MySqlParameter("@level", MySqlDbType.Int16)
			};
			parameters[0].Value = level;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string levellist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from usertype ");
			strSql.Append(" where level in ("+levellist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
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
		public Jium.Model.usertype GetModel(int level)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select tagname,level,authvalue from usertype ");
			strSql.Append(" where level=@level");
			MySqlParameter[] parameters = {
					new MySqlParameter("@level", MySqlDbType.Int16)
			};
			parameters[0].Value = level;

			Jium.Model.usertype model=new Jium.Model.usertype();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
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
		public Jium.Model.usertype DataRowToModel(DataRow row)
		{
			Jium.Model.usertype model=new Jium.Model.usertype();
			if (row != null)
			{
				if(row["tagname"]!=null)
				{
					model.tagname=row["tagname"].ToString();
				}
				if(row["level"]!=null && row["level"].ToString()!="")
				{
					model.level=int.Parse(row["level"].ToString());
				}
				if(row["authvalue"]!=null && row["authvalue"].ToString()!="")
				{
					model.authvalue=int.Parse(row["authvalue"].ToString());
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
			strSql.Append("select tagname,level,authvalue ");
			strSql.Append(" FROM usertype ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM usertype ");
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
				strSql.Append("order by T.level desc");
			}
			strSql.Append(")AS Row, T.*  from usertype T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "usertype";
			parameters[1].Value = "level";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

