using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Jium.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Jium.MySQLDAL
{
	/// <summary>
	/// 数据访问类:userinfo
	/// </summary>
	public partial class userinfo:Iuserinfo
	{
		public userinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "userinfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from userinfo");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Jium.Model.userinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into userinfo(");
			strSql.Append("tagname,email,level,pwd,remark,createtime,token,tokentime,status)");
			strSql.Append(" values (");
			strSql.Append("@tagname,@email,@level,@pwd,@remark,@createtime,@token,@tokentime,@status)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@tagname", MySqlDbType.VarChar,40),
					new MySqlParameter("@email", MySqlDbType.VarChar,40),
					new MySqlParameter("@level", MySqlDbType.Int16,8),
					new MySqlParameter("@pwd", MySqlDbType.VarChar,40),
					new MySqlParameter("@remark", MySqlDbType.VarChar,256),
					new MySqlParameter("@createtime", MySqlDbType.VarChar,20),
					new MySqlParameter("@token", MySqlDbType.VarChar,128),
					new MySqlParameter("@tokentime", MySqlDbType.VarChar,20),
					new MySqlParameter("@status", MySqlDbType.Int32,11)};
			parameters[0].Value = model.tagname;
			parameters[1].Value = model.email;
			parameters[2].Value = model.level;
			parameters[3].Value = model.pwd;
			parameters[4].Value = model.remark;
			parameters[5].Value = model.createtime;
			parameters[6].Value = model.token;
			parameters[7].Value = model.tokentime;
			parameters[8].Value = model.status;

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
		public bool Update(Jium.Model.userinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update userinfo set ");
			strSql.Append("tagname=@tagname,");
			strSql.Append("email=@email,");
			strSql.Append("level=@level,");
			strSql.Append("pwd=@pwd,");
			strSql.Append("remark=@remark,");
			strSql.Append("createtime=@createtime,");
			strSql.Append("token=@token,");
			strSql.Append("tokentime=@tokentime,");
			strSql.Append("status=@status");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@tagname", MySqlDbType.VarChar,40),
					new MySqlParameter("@email", MySqlDbType.VarChar,40),
					new MySqlParameter("@level", MySqlDbType.Int16,8),
					new MySqlParameter("@pwd", MySqlDbType.VarChar,40),
					new MySqlParameter("@remark", MySqlDbType.VarChar,256),
					new MySqlParameter("@createtime", MySqlDbType.VarChar,20),
					new MySqlParameter("@token", MySqlDbType.VarChar,128),
					new MySqlParameter("@tokentime", MySqlDbType.VarChar,20),
					new MySqlParameter("@status", MySqlDbType.Int32,11),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.tagname;
			parameters[1].Value = model.email;
			parameters[2].Value = model.level;
			parameters[3].Value = model.pwd;
			parameters[4].Value = model.remark;
			parameters[5].Value = model.createtime;
			parameters[6].Value = model.token;
			parameters[7].Value = model.tokentime;
			parameters[8].Value = model.status;
			parameters[9].Value = model.id;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from userinfo ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from userinfo ");
			strSql.Append(" where id in ("+idlist + ")  ");
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
		public Jium.Model.userinfo GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,tagname,email,level,pwd,remark,createtime,token,tokentime,status from userinfo ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			Jium.Model.userinfo model=new Jium.Model.userinfo();
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
		public Jium.Model.userinfo DataRowToModel(DataRow row)
		{
			Jium.Model.userinfo model=new Jium.Model.userinfo();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["tagname"]!=null)
				{
					model.tagname=row["tagname"].ToString();
				}
				if(row["email"]!=null)
				{
					model.email=row["email"].ToString();
				}
				if(row["level"]!=null && row["level"].ToString()!="")
				{
					model.level=int.Parse(row["level"].ToString());
				}
				if(row["pwd"]!=null)
				{
					model.pwd=row["pwd"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["createtime"]!=null)
				{
					model.createtime=row["createtime"].ToString();
				}
				if(row["token"]!=null)
				{
					model.token=row["token"].ToString();
				}
				if(row["tokentime"]!=null)
				{
					model.tokentime=row["tokentime"].ToString();
				}
				if(row["status"]!=null && row["status"].ToString()!="")
				{
					model.status=int.Parse(row["status"].ToString());
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
			strSql.Append("select id,tagname,email,level,pwd,remark,createtime,token,tokentime,status ");
			strSql.Append(" FROM userinfo ");
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
			strSql.Append("select count(1) FROM userinfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperMySQL.GetSingle(strSql.ToString());
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from userinfo T ");
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
			parameters[0].Value = "userinfo";
			parameters[1].Value = "id";
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

