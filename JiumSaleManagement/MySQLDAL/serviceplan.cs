using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Jium.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Jium.MySQLDAL
{
	/// <summary>
	/// 数据访问类:serviceplan
	/// </summary>
	public partial class serviceplan:Iserviceplan
	{
		public serviceplan()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from serviceplan");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.VarChar,20)			};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Jium.Model.serviceplan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into serviceplan(");
			strSql.Append("id,plandate,plantime,totalnum,leftnum,nexttotal,nextleft,nextid,pss1,pss2,pss3,pss4,pss5,psd1,psd2,psd3,psd4,psd5)");
			strSql.Append(" values (");
			strSql.Append("@id,@plandate,@plantime,@totalnum,@leftnum,@nexttotal,@nextleft,@nextid,@pss1,@pss2,@pss3,@pss4,@pss5,@psd1,@psd2,@psd3,@psd4,@psd5)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.VarChar,20),
					new MySqlParameter("@plandate", MySqlDbType.VarChar,10),
					new MySqlParameter("@plantime", MySqlDbType.VarChar,10),
					new MySqlParameter("@totalnum", MySqlDbType.Int32,11),
					new MySqlParameter("@leftnum", MySqlDbType.Int32,11),
					new MySqlParameter("@nexttotal", MySqlDbType.Int32,11),
					new MySqlParameter("@nextleft", MySqlDbType.Int32,11),
					new MySqlParameter("@nextid", MySqlDbType.VarChar,20),
					new MySqlParameter("@pss1", MySqlDbType.VarChar,20),
					new MySqlParameter("@pss2", MySqlDbType.VarChar,20),
					new MySqlParameter("@pss3", MySqlDbType.VarChar,20),
					new MySqlParameter("@pss4", MySqlDbType.VarChar,20),
					new MySqlParameter("@pss5", MySqlDbType.VarChar,20),
					new MySqlParameter("@psd1", MySqlDbType.Int32,11),
					new MySqlParameter("@psd2", MySqlDbType.Int32,11),
					new MySqlParameter("@psd3", MySqlDbType.Int32,11),
					new MySqlParameter("@psd4", MySqlDbType.Int32,11),
					new MySqlParameter("@psd5", MySqlDbType.Int32,11)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.plandate;
			parameters[2].Value = model.plantime;
			parameters[3].Value = model.totalnum;
			parameters[4].Value = model.leftnum;
			parameters[5].Value = model.nexttotal;
			parameters[6].Value = model.nextleft;
			parameters[7].Value = model.nextid;
			parameters[8].Value = model.pss1;
			parameters[9].Value = model.pss2;
			parameters[10].Value = model.pss3;
			parameters[11].Value = model.pss4;
			parameters[12].Value = model.pss5;
			parameters[13].Value = model.psd1;
			parameters[14].Value = model.psd2;
			parameters[15].Value = model.psd3;
			parameters[16].Value = model.psd4;
			parameters[17].Value = model.psd5;

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
		public bool Update(Jium.Model.serviceplan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update serviceplan set ");
			strSql.Append("plandate=@plandate,");
			strSql.Append("plantime=@plantime,");
			strSql.Append("totalnum=@totalnum,");
			strSql.Append("leftnum=@leftnum,");
			strSql.Append("nexttotal=@nexttotal,");
			strSql.Append("nextleft=@nextleft,");
			strSql.Append("nextid=@nextid,");
			strSql.Append("pss1=@pss1,");
			strSql.Append("pss2=@pss2,");
			strSql.Append("pss3=@pss3,");
			strSql.Append("pss4=@pss4,");
			strSql.Append("pss5=@pss5,");
			strSql.Append("psd1=@psd1,");
			strSql.Append("psd2=@psd2,");
			strSql.Append("psd3=@psd3,");
			strSql.Append("psd4=@psd4,");
			strSql.Append("psd5=@psd5");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@plandate", MySqlDbType.VarChar,10),
					new MySqlParameter("@plantime", MySqlDbType.VarChar,10),
					new MySqlParameter("@totalnum", MySqlDbType.Int32,11),
					new MySqlParameter("@leftnum", MySqlDbType.Int32,11),
					new MySqlParameter("@nexttotal", MySqlDbType.Int32,11),
					new MySqlParameter("@nextleft", MySqlDbType.Int32,11),
					new MySqlParameter("@nextid", MySqlDbType.VarChar,20),
					new MySqlParameter("@pss1", MySqlDbType.VarChar,20),
					new MySqlParameter("@pss2", MySqlDbType.VarChar,20),
					new MySqlParameter("@pss3", MySqlDbType.VarChar,20),
					new MySqlParameter("@pss4", MySqlDbType.VarChar,20),
					new MySqlParameter("@pss5", MySqlDbType.VarChar,20),
					new MySqlParameter("@psd1", MySqlDbType.Int32,11),
					new MySqlParameter("@psd2", MySqlDbType.Int32,11),
					new MySqlParameter("@psd3", MySqlDbType.Int32,11),
					new MySqlParameter("@psd4", MySqlDbType.Int32,11),
					new MySqlParameter("@psd5", MySqlDbType.Int32,11),
					new MySqlParameter("@id", MySqlDbType.VarChar,20)};
			parameters[0].Value = model.plandate;
			parameters[1].Value = model.plantime;
			parameters[2].Value = model.totalnum;
			parameters[3].Value = model.leftnum;
			parameters[4].Value = model.nexttotal;
			parameters[5].Value = model.nextleft;
			parameters[6].Value = model.nextid;
			parameters[7].Value = model.pss1;
			parameters[8].Value = model.pss2;
			parameters[9].Value = model.pss3;
			parameters[10].Value = model.pss4;
			parameters[11].Value = model.pss5;
			parameters[12].Value = model.psd1;
			parameters[13].Value = model.psd2;
			parameters[14].Value = model.psd3;
			parameters[15].Value = model.psd4;
			parameters[16].Value = model.psd5;
			parameters[17].Value = model.id;

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
		public bool Delete(string id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from serviceplan ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.VarChar,20)			};
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
			strSql.Append("delete from serviceplan ");
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
		public Jium.Model.serviceplan GetModel(string id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,plandate,plantime,totalnum,leftnum,nexttotal,nextleft,nextid,pss1,pss2,pss3,pss4,pss5,psd1,psd2,psd3,psd4,psd5 from serviceplan ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.VarChar,20)			};
			parameters[0].Value = id;

			Jium.Model.serviceplan model=new Jium.Model.serviceplan();
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
		public Jium.Model.serviceplan DataRowToModel(DataRow row)
		{
			Jium.Model.serviceplan model=new Jium.Model.serviceplan();
			if (row != null)
			{
				if(row["id"]!=null)
				{
					model.id=row["id"].ToString();
				}
				if(row["plandate"]!=null)
				{
					model.plandate=row["plandate"].ToString();
				}
				if(row["plantime"]!=null)
				{
					model.plantime=row["plantime"].ToString();
				}
				if(row["totalnum"]!=null && row["totalnum"].ToString()!="")
				{
					model.totalnum=int.Parse(row["totalnum"].ToString());
				}
				if(row["leftnum"]!=null && row["leftnum"].ToString()!="")
				{
					model.leftnum=int.Parse(row["leftnum"].ToString());
				}
				if(row["nexttotal"]!=null && row["nexttotal"].ToString()!="")
				{
					model.nexttotal=int.Parse(row["nexttotal"].ToString());
				}
				if(row["nextleft"]!=null && row["nextleft"].ToString()!="")
				{
					model.nextleft=int.Parse(row["nextleft"].ToString());
				}
				if(row["nextid"]!=null)
				{
					model.nextid=row["nextid"].ToString();
				}
				if(row["pss1"]!=null)
				{
					model.pss1=row["pss1"].ToString();
				}
				if(row["pss2"]!=null)
				{
					model.pss2=row["pss2"].ToString();
				}
				if(row["pss3"]!=null)
				{
					model.pss3=row["pss3"].ToString();
				}
				if(row["pss4"]!=null)
				{
					model.pss4=row["pss4"].ToString();
				}
				if(row["pss5"]!=null)
				{
					model.pss5=row["pss5"].ToString();
				}
				if(row["psd1"]!=null && row["psd1"].ToString()!="")
				{
					model.psd1=int.Parse(row["psd1"].ToString());
				}
				if(row["psd2"]!=null && row["psd2"].ToString()!="")
				{
					model.psd2=int.Parse(row["psd2"].ToString());
				}
				if(row["psd3"]!=null && row["psd3"].ToString()!="")
				{
					model.psd3=int.Parse(row["psd3"].ToString());
				}
				if(row["psd4"]!=null && row["psd4"].ToString()!="")
				{
					model.psd4=int.Parse(row["psd4"].ToString());
				}
				if(row["psd5"]!=null && row["psd5"].ToString()!="")
				{
					model.psd5=int.Parse(row["psd5"].ToString());
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
			strSql.Append("select id,plandate,plantime,totalnum,leftnum,nexttotal,nextleft,nextid,pss1,pss2,pss3,pss4,pss5,psd1,psd2,psd3,psd4,psd5 ");
			strSql.Append(" FROM serviceplan ");
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
			strSql.Append("select count(1) FROM serviceplan ");
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
			strSql.Append(")AS Row, T.*  from serviceplan T ");
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
			parameters[0].Value = "serviceplan";
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

