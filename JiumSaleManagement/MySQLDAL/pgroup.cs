using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Jium.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Jium.MySQLDAL
{
	/// <summary>
	/// 数据访问类:pgroup
	/// </summary>
	public partial class pgroup:Ipgroup
	{
		public pgroup()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from pgroup");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.bigint,20)			};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Jium.Model.pgroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into pgroup(");
			strSql.Append("id,gid,gindex,gpid,gpcnt,gdesc,gs1,gs2,gs3,gs4,gs5,gd1,gd2,gd3,gd4,gd5,gdc1,gdc2,gdc3,gdc4,gdc5)");
			strSql.Append(" values (");
			strSql.Append("@id,@gid,@gindex,@gpid,@gpcnt,@gdesc,@gs1,@gs2,@gs3,@gs4,@gs5,@gd1,@gd2,@gd3,@gd4,@gd5,@gdc1,@gdc2,@gdc3,@gdc4,@gdc5)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.bigint,20),
					new MySqlParameter("@gid", MySqlDbType.Int32,11),
					new MySqlParameter("@gindex", MySqlDbType.Int32,11),
					new MySqlParameter("@gpid", MySqlDbType.Int32,11),
					new MySqlParameter("@gpcnt", MySqlDbType.Int32,11),
					new MySqlParameter("@gdesc", MySqlDbType.VarChar,200),
					new MySqlParameter("@gs1", MySqlDbType.VarChar,20),
					new MySqlParameter("@gs2", MySqlDbType.VarChar,20),
					new MySqlParameter("@gs3", MySqlDbType.VarChar,20),
					new MySqlParameter("@gs4", MySqlDbType.VarChar,20),
					new MySqlParameter("@gs5", MySqlDbType.VarChar,20),
					new MySqlParameter("@gd1", MySqlDbType.Int32,11),
					new MySqlParameter("@gd2", MySqlDbType.Int32,11),
					new MySqlParameter("@gd3", MySqlDbType.Int32,11),
					new MySqlParameter("@gd4", MySqlDbType.Int32,11),
					new MySqlParameter("@gd5", MySqlDbType.Int32,11),
					new MySqlParameter("@gdc1", MySqlDbType.Decimal,20),
					new MySqlParameter("@gdc2", MySqlDbType.Decimal,20),
					new MySqlParameter("@gdc3", MySqlDbType.Decimal,20),
					new MySqlParameter("@gdc4", MySqlDbType.Decimal,20),
					new MySqlParameter("@gdc5", MySqlDbType.Decimal,20)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.gid;
			parameters[2].Value = model.gindex;
			parameters[3].Value = model.gpid;
			parameters[4].Value = model.gpcnt;
			parameters[5].Value = model.gdesc;
			parameters[6].Value = model.gs1;
			parameters[7].Value = model.gs2;
			parameters[8].Value = model.gs3;
			parameters[9].Value = model.gs4;
			parameters[10].Value = model.gs5;
			parameters[11].Value = model.gd1;
			parameters[12].Value = model.gd2;
			parameters[13].Value = model.gd3;
			parameters[14].Value = model.gd4;
			parameters[15].Value = model.gd5;
			parameters[16].Value = model.gdc1;
			parameters[17].Value = model.gdc2;
			parameters[18].Value = model.gdc3;
			parameters[19].Value = model.gdc4;
			parameters[20].Value = model.gdc5;

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
		public bool Update(Jium.Model.pgroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update pgroup set ");
			strSql.Append("gid=@gid,");
			strSql.Append("gindex=@gindex,");
			strSql.Append("gpid=@gpid,");
			strSql.Append("gpcnt=@gpcnt,");
			strSql.Append("gdesc=@gdesc,");
			strSql.Append("gs1=@gs1,");
			strSql.Append("gs2=@gs2,");
			strSql.Append("gs3=@gs3,");
			strSql.Append("gs4=@gs4,");
			strSql.Append("gs5=@gs5,");
			strSql.Append("gd1=@gd1,");
			strSql.Append("gd2=@gd2,");
			strSql.Append("gd3=@gd3,");
			strSql.Append("gd4=@gd4,");
			strSql.Append("gd5=@gd5,");
			strSql.Append("gdc1=@gdc1,");
			strSql.Append("gdc2=@gdc2,");
			strSql.Append("gdc3=@gdc3,");
			strSql.Append("gdc4=@gdc4,");
			strSql.Append("gdc5=@gdc5");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@gid", MySqlDbType.Int32,11),
					new MySqlParameter("@gindex", MySqlDbType.Int32,11),
					new MySqlParameter("@gpid", MySqlDbType.Int32,11),
					new MySqlParameter("@gpcnt", MySqlDbType.Int32,11),
					new MySqlParameter("@gdesc", MySqlDbType.VarChar,200),
					new MySqlParameter("@gs1", MySqlDbType.VarChar,20),
					new MySqlParameter("@gs2", MySqlDbType.VarChar,20),
					new MySqlParameter("@gs3", MySqlDbType.VarChar,20),
					new MySqlParameter("@gs4", MySqlDbType.VarChar,20),
					new MySqlParameter("@gs5", MySqlDbType.VarChar,20),
					new MySqlParameter("@gd1", MySqlDbType.Int32,11),
					new MySqlParameter("@gd2", MySqlDbType.Int32,11),
					new MySqlParameter("@gd3", MySqlDbType.Int32,11),
					new MySqlParameter("@gd4", MySqlDbType.Int32,11),
					new MySqlParameter("@gd5", MySqlDbType.Int32,11),
					new MySqlParameter("@gdc1", MySqlDbType.Decimal,20),
					new MySqlParameter("@gdc2", MySqlDbType.Decimal,20),
					new MySqlParameter("@gdc3", MySqlDbType.Decimal,20),
					new MySqlParameter("@gdc4", MySqlDbType.Decimal,20),
					new MySqlParameter("@gdc5", MySqlDbType.Decimal,20),
					new MySqlParameter("@id", MySqlDbType.bigint,20)};
			parameters[0].Value = model.gid;
			parameters[1].Value = model.gindex;
			parameters[2].Value = model.gpid;
			parameters[3].Value = model.gpcnt;
			parameters[4].Value = model.gdesc;
			parameters[5].Value = model.gs1;
			parameters[6].Value = model.gs2;
			parameters[7].Value = model.gs3;
			parameters[8].Value = model.gs4;
			parameters[9].Value = model.gs5;
			parameters[10].Value = model.gd1;
			parameters[11].Value = model.gd2;
			parameters[12].Value = model.gd3;
			parameters[13].Value = model.gd4;
			parameters[14].Value = model.gd5;
			parameters[15].Value = model.gdc1;
			parameters[16].Value = model.gdc2;
			parameters[17].Value = model.gdc3;
			parameters[18].Value = model.gdc4;
			parameters[19].Value = model.gdc5;
			parameters[20].Value = model.id;

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
			strSql.Append("delete from pgroup ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.bigint,20)			};
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
			strSql.Append("delete from pgroup ");
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
		public Jium.Model.pgroup GetModel(long id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,gid,gindex,gpid,gpcnt,gdesc,gs1,gs2,gs3,gs4,gs5,gd1,gd2,gd3,gd4,gd5,gdc1,gdc2,gdc3,gdc4,gdc5 from pgroup ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.bigint,20)			};
			parameters[0].Value = id;

			Jium.Model.pgroup model=new Jium.Model.pgroup();
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
		public Jium.Model.pgroup DataRowToModel(DataRow row)
		{
			Jium.Model.pgroup model=new Jium.Model.pgroup();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=long.Parse(row["id"].ToString());
				}
				if(row["gid"]!=null && row["gid"].ToString()!="")
				{
					model.gid=int.Parse(row["gid"].ToString());
				}
				if(row["gindex"]!=null && row["gindex"].ToString()!="")
				{
					model.gindex=int.Parse(row["gindex"].ToString());
				}
				if(row["gpid"]!=null && row["gpid"].ToString()!="")
				{
					model.gpid=int.Parse(row["gpid"].ToString());
				}
				if(row["gpcnt"]!=null && row["gpcnt"].ToString()!="")
				{
					model.gpcnt=int.Parse(row["gpcnt"].ToString());
				}
				if(row["gdesc"]!=null)
				{
					model.gdesc=row["gdesc"].ToString();
				}
				if(row["gs1"]!=null)
				{
					model.gs1=row["gs1"].ToString();
				}
				if(row["gs2"]!=null)
				{
					model.gs2=row["gs2"].ToString();
				}
				if(row["gs3"]!=null)
				{
					model.gs3=row["gs3"].ToString();
				}
				if(row["gs4"]!=null)
				{
					model.gs4=row["gs4"].ToString();
				}
				if(row["gs5"]!=null)
				{
					model.gs5=row["gs5"].ToString();
				}
				if(row["gd1"]!=null && row["gd1"].ToString()!="")
				{
					model.gd1=int.Parse(row["gd1"].ToString());
				}
				if(row["gd2"]!=null && row["gd2"].ToString()!="")
				{
					model.gd2=int.Parse(row["gd2"].ToString());
				}
				if(row["gd3"]!=null && row["gd3"].ToString()!="")
				{
					model.gd3=int.Parse(row["gd3"].ToString());
				}
				if(row["gd4"]!=null && row["gd4"].ToString()!="")
				{
					model.gd4=int.Parse(row["gd4"].ToString());
				}
				if(row["gd5"]!=null && row["gd5"].ToString()!="")
				{
					model.gd5=int.Parse(row["gd5"].ToString());
				}
				if(row["gdc1"]!=null && row["gdc1"].ToString()!="")
				{
					model.gdc1=decimal.Parse(row["gdc1"].ToString());
				}
				if(row["gdc2"]!=null && row["gdc2"].ToString()!="")
				{
					model.gdc2=decimal.Parse(row["gdc2"].ToString());
				}
				if(row["gdc3"]!=null && row["gdc3"].ToString()!="")
				{
					model.gdc3=decimal.Parse(row["gdc3"].ToString());
				}
				if(row["gdc4"]!=null && row["gdc4"].ToString()!="")
				{
					model.gdc4=decimal.Parse(row["gdc4"].ToString());
				}
				if(row["gdc5"]!=null && row["gdc5"].ToString()!="")
				{
					model.gdc5=decimal.Parse(row["gdc5"].ToString());
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
			strSql.Append("select id,gid,gindex,gpid,gpcnt,gdesc,gs1,gs2,gs3,gs4,gs5,gd1,gd2,gd3,gd4,gd5,gdc1,gdc2,gdc3,gdc4,gdc5 ");
			strSql.Append(" FROM pgroup ");
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
			strSql.Append("select count(1) FROM pgroup ");
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
			strSql.Append(")AS Row, T.*  from pgroup T ");
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
			parameters[0].Value = "pgroup";
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

