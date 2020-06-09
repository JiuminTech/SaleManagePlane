using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Jium.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Jium.MySQLDAL
{
	/// <summary>
	/// 数据访问类:servicerorder
	/// </summary>
	public partial class servicerorder:Iservicerorder
	{
		public servicerorder()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from servicerorder");
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
		public bool Add(Jium.Model.servicerorder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into servicerorder(");
			strSql.Append("ccode,spid,spnum,spspan,sostatus,createtime,updatetime,updateby,sos1,sos2,sos3,sos4,sos5,sod1,sod2,sod3,sod4,sod5)");
			strSql.Append(" values (");
			strSql.Append("@ccode,@spid,@spnum,@spspan,@sostatus,@createtime,@updatetime,@updateby,@sos1,@sos2,@sos3,@sos4,@sos5,@sod1,@sod2,@sod3,@sod4,@sod5)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ccode", MySqlDbType.VarChar,40),
					new MySqlParameter("@spid", MySqlDbType.VarChar,20),
					new MySqlParameter("@spnum", MySqlDbType.Int32,11),
					new MySqlParameter("@spspan", MySqlDbType.Int32,11),
					new MySqlParameter("@sostatus", MySqlDbType.Int32,11),
					new MySqlParameter("@createtime", MySqlDbType.VarChar,20),
					new MySqlParameter("@updatetime", MySqlDbType.VarChar,20),
					new MySqlParameter("@updateby", MySqlDbType.VarChar,40),
					new MySqlParameter("@sos1", MySqlDbType.VarChar,40),
					new MySqlParameter("@sos2", MySqlDbType.VarChar,40),
					new MySqlParameter("@sos3", MySqlDbType.VarChar,40),
					new MySqlParameter("@sos4", MySqlDbType.VarChar,40),
					new MySqlParameter("@sos5", MySqlDbType.VarChar,40),
					new MySqlParameter("@sod1", MySqlDbType.Int32,11),
					new MySqlParameter("@sod2", MySqlDbType.Int32,11),
					new MySqlParameter("@sod3", MySqlDbType.Int32,11),
					new MySqlParameter("@sod4", MySqlDbType.Int32,11),
					new MySqlParameter("@sod5", MySqlDbType.Int32,11)};
			parameters[0].Value = model.ccode;
			parameters[1].Value = model.spid;
			parameters[2].Value = model.spnum;
			parameters[3].Value = model.spspan;
			parameters[4].Value = model.sostatus;
			parameters[5].Value = model.createtime;
			parameters[6].Value = model.updatetime;
			parameters[7].Value = model.updateby;
			parameters[8].Value = model.sos1;
			parameters[9].Value = model.sos2;
			parameters[10].Value = model.sos3;
			parameters[11].Value = model.sos4;
			parameters[12].Value = model.sos5;
			parameters[13].Value = model.sod1;
			parameters[14].Value = model.sod2;
			parameters[15].Value = model.sod3;
			parameters[16].Value = model.sod4;
			parameters[17].Value = model.sod5;

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
		public bool Update(Jium.Model.servicerorder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update servicerorder set ");
			strSql.Append("ccode=@ccode,");
			strSql.Append("spid=@spid,");
			strSql.Append("spnum=@spnum,");
			strSql.Append("spspan=@spspan,");
			strSql.Append("sostatus=@sostatus,");
			strSql.Append("createtime=@createtime,");
			strSql.Append("updatetime=@updatetime,");
			strSql.Append("updateby=@updateby,");
			strSql.Append("sos1=@sos1,");
			strSql.Append("sos2=@sos2,");
			strSql.Append("sos3=@sos3,");
			strSql.Append("sos4=@sos4,");
			strSql.Append("sos5=@sos5,");
			strSql.Append("sod1=@sod1,");
			strSql.Append("sod2=@sod2,");
			strSql.Append("sod3=@sod3,");
			strSql.Append("sod4=@sod4,");
			strSql.Append("sod5=@sod5");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ccode", MySqlDbType.VarChar,40),
					new MySqlParameter("@spid", MySqlDbType.VarChar,20),
					new MySqlParameter("@spnum", MySqlDbType.Int32,11),
					new MySqlParameter("@spspan", MySqlDbType.Int32,11),
					new MySqlParameter("@sostatus", MySqlDbType.Int32,11),
					new MySqlParameter("@createtime", MySqlDbType.VarChar,20),
					new MySqlParameter("@updatetime", MySqlDbType.VarChar,20),
					new MySqlParameter("@updateby", MySqlDbType.VarChar,40),
					new MySqlParameter("@sos1", MySqlDbType.VarChar,40),
					new MySqlParameter("@sos2", MySqlDbType.VarChar,40),
					new MySqlParameter("@sos3", MySqlDbType.VarChar,40),
					new MySqlParameter("@sos4", MySqlDbType.VarChar,40),
					new MySqlParameter("@sos5", MySqlDbType.VarChar,40),
					new MySqlParameter("@sod1", MySqlDbType.Int32,11),
					new MySqlParameter("@sod2", MySqlDbType.Int32,11),
					new MySqlParameter("@sod3", MySqlDbType.Int32,11),
					new MySqlParameter("@sod4", MySqlDbType.Int32,11),
					new MySqlParameter("@sod5", MySqlDbType.Int32,11),
					new MySqlParameter("@id", MySqlDbType.Int64,20)};
			parameters[0].Value = model.ccode;
			parameters[1].Value = model.spid;
			parameters[2].Value = model.spnum;
			parameters[3].Value = model.spspan;
			parameters[4].Value = model.sostatus;
			parameters[5].Value = model.createtime;
			parameters[6].Value = model.updatetime;
			parameters[7].Value = model.updateby;
			parameters[8].Value = model.sos1;
			parameters[9].Value = model.sos2;
			parameters[10].Value = model.sos3;
			parameters[11].Value = model.sos4;
			parameters[12].Value = model.sos5;
			parameters[13].Value = model.sod1;
			parameters[14].Value = model.sod2;
			parameters[15].Value = model.sod3;
			parameters[16].Value = model.sod4;
			parameters[17].Value = model.sod5;
			parameters[18].Value = model.id;

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
			strSql.Append("delete from servicerorder ");
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
			strSql.Append("delete from servicerorder ");
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
		public Jium.Model.servicerorder GetModel(long id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,ccode,spid,spnum,spspan,sostatus,createtime,updatetime,updateby,sos1,sos2,sos3,sos4,sos5,sod1,sod2,sod3,sod4,sod5 from servicerorder ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64)
			};
			parameters[0].Value = id;

			Jium.Model.servicerorder model=new Jium.Model.servicerorder();
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
		public Jium.Model.servicerorder DataRowToModel(DataRow row)
		{
			Jium.Model.servicerorder model=new Jium.Model.servicerorder();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=long.Parse(row["id"].ToString());
				}
				if(row["ccode"]!=null)
				{
					model.ccode=row["ccode"].ToString();
				}
				if(row["spid"]!=null)
				{
					model.spid=row["spid"].ToString();
				}
				if(row["spnum"]!=null && row["spnum"].ToString()!="")
				{
					model.spnum=int.Parse(row["spnum"].ToString());
				}
				if(row["spspan"]!=null && row["spspan"].ToString()!="")
				{
					model.spspan=int.Parse(row["spspan"].ToString());
				}
				if(row["sostatus"]!=null && row["sostatus"].ToString()!="")
				{
					model.sostatus=int.Parse(row["sostatus"].ToString());
				}
				if(row["createtime"]!=null)
				{
					model.createtime=row["createtime"].ToString();
				}
				if(row["updatetime"]!=null)
				{
					model.updatetime=row["updatetime"].ToString();
				}
				if(row["updateby"]!=null)
				{
					model.updateby=row["updateby"].ToString();
				}
				if(row["sos1"]!=null)
				{
					model.sos1=row["sos1"].ToString();
				}
				if(row["sos2"]!=null)
				{
					model.sos2=row["sos2"].ToString();
				}
				if(row["sos3"]!=null)
				{
					model.sos3=row["sos3"].ToString();
				}
				if(row["sos4"]!=null)
				{
					model.sos4=row["sos4"].ToString();
				}
				if(row["sos5"]!=null)
				{
					model.sos5=row["sos5"].ToString();
				}
				if(row["sod1"]!=null && row["sod1"].ToString()!="")
				{
					model.sod1=int.Parse(row["sod1"].ToString());
				}
				if(row["sod2"]!=null && row["sod2"].ToString()!="")
				{
					model.sod2=int.Parse(row["sod2"].ToString());
				}
				if(row["sod3"]!=null && row["sod3"].ToString()!="")
				{
					model.sod3=int.Parse(row["sod3"].ToString());
				}
				if(row["sod4"]!=null && row["sod4"].ToString()!="")
				{
					model.sod4=int.Parse(row["sod4"].ToString());
				}
				if(row["sod5"]!=null && row["sod5"].ToString()!="")
				{
					model.sod5=int.Parse(row["sod5"].ToString());
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
			strSql.Append("select id,ccode,spid,spnum,spspan,sostatus,createtime,updatetime,updateby,sos1,sos2,sos3,sos4,sos5,sod1,sod2,sod3,sod4,sod5 ");
			strSql.Append(" FROM servicerorder ");
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
			strSql.Append("select count(1) FROM servicerorder ");
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
			strSql.Append(")AS Row, T.*  from servicerorder T ");
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
			parameters[0].Value = "servicerorder";
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

