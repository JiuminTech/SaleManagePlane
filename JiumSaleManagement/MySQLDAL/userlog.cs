using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Jium.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Jium.MySQLDAL
{
	/// <summary>
	/// 数据访问类:userlog
	/// </summary>
	public partial class userlog:Iuserlog
	{
		public userlog()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from userlog");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64)
			};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Jium.Model.userlog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into userlog(");
			strSql.Append("usercode,useraddr,opertype,operobject,opervalue,operdesc,opertime)");
			strSql.Append(" values (");
			strSql.Append("@usercode,@useraddr,@opertype,@operobject,@opervalue,@operdesc,@opertime)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@usercode", MySqlDbType.VarChar,40),
					new MySqlParameter("@useraddr", MySqlDbType.VarChar,40),
					new MySqlParameter("@opertype", MySqlDbType.VarChar,20),
					new MySqlParameter("@operobject", MySqlDbType.VarChar,40),
					new MySqlParameter("@opervalue", MySqlDbType.VarChar,40),
					new MySqlParameter("@operdesc", MySqlDbType.VarChar,100),
					new MySqlParameter("@opertime", MySqlDbType.VarChar,20)};
			parameters[0].Value = model.usercode;
			parameters[1].Value = model.useraddr;
			parameters[2].Value = model.opertype;
			parameters[3].Value = model.operobject;
			parameters[4].Value = model.opervalue;
			parameters[5].Value = model.operdesc;
			parameters[6].Value = model.opertime;

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
		public bool Update(Jium.Model.userlog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update userlog set ");
			strSql.Append("usercode=@usercode,");
			strSql.Append("useraddr=@useraddr,");
			strSql.Append("opertype=@opertype,");
			strSql.Append("operobject=@operobject,");
			strSql.Append("opervalue=@opervalue,");
			strSql.Append("operdesc=@operdesc,");
			strSql.Append("opertime=@opertime");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@usercode", MySqlDbType.VarChar,40),
					new MySqlParameter("@useraddr", MySqlDbType.VarChar,40),
					new MySqlParameter("@opertype", MySqlDbType.VarChar,20),
					new MySqlParameter("@operobject", MySqlDbType.VarChar,40),
					new MySqlParameter("@opervalue", MySqlDbType.VarChar,40),
					new MySqlParameter("@operdesc", MySqlDbType.VarChar,100),
					new MySqlParameter("@opertime", MySqlDbType.VarChar,20),
					new MySqlParameter("@id", MySqlDbType.Int64,20)};
			parameters[0].Value = model.usercode;
			parameters[1].Value = model.useraddr;
			parameters[2].Value = model.opertype;
			parameters[3].Value = model.operobject;
			parameters[4].Value = model.opervalue;
			parameters[5].Value = model.operdesc;
			parameters[6].Value = model.opertime;
			parameters[7].Value = model.id;

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
		public bool Delete(long id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from userlog ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64)
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
			strSql.Append("delete from userlog ");
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
		public Jium.Model.userlog GetModel(long id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,usercode,useraddr,opertype,operobject,opervalue,operdesc,opertime from userlog ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64)
			};
			parameters[0].Value = id;

			Jium.Model.userlog model=new Jium.Model.userlog();
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
		public Jium.Model.userlog DataRowToModel(DataRow row)
		{
			Jium.Model.userlog model=new Jium.Model.userlog();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=long.Parse(row["id"].ToString());
				}
				if(row["usercode"]!=null)
				{
					model.usercode=row["usercode"].ToString();
				}
				if(row["useraddr"]!=null)
				{
					model.useraddr=row["useraddr"].ToString();
				}
				if(row["opertype"]!=null)
				{
					model.opertype=row["opertype"].ToString();
				}
				if(row["operobject"]!=null)
				{
					model.operobject=row["operobject"].ToString();
				}
				if(row["opervalue"]!=null)
				{
					model.opervalue=row["opervalue"].ToString();
				}
				if(row["operdesc"]!=null)
				{
					model.operdesc=row["operdesc"].ToString();
				}
				if(row["opertime"]!=null)
				{
					model.opertime=row["opertime"].ToString();
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
			strSql.Append("select id,usercode,useraddr,opertype,operobject,opervalue,operdesc,opertime ");
			strSql.Append(" FROM userlog ");
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
			strSql.Append("select count(1) FROM userlog ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from userlog T ");
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
			parameters[0].Value = "userlog";
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

