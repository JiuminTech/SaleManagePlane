using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Jium.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Jium.MySQLDAL
{
	/// <summary>
	/// 数据访问类:consumerservice
	/// </summary>
	public partial class consumerservice:Iconsumerservice
	{
		public consumerservice()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from consumerservice");
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
		public bool Add(Jium.Model.consumerservice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into consumerservice(");
			strSql.Append("ccode,cphone,cstype,csnum,csleft,csiostatus,cstime0,cstime1,cstime2,cstime3,cstime4,cstime5,cstime6,cstime7,cstime8,cstime9,cstime10,css1,css2,css3,css4,css5,csd1,csd2,csd3,csd4,csd5)");
			strSql.Append(" values (");
			strSql.Append("@ccode,@cphone,@cstype,@csnum,@csleft,@csiostatus,@cstime0,@cstime1,@cstime2,@cstime3,@cstime4,@cstime5,@cstime6,@cstime7,@cstime8,@cstime9,@cstime10,@css1,@css2,@css3,@css4,@css5,@csd1,@csd2,@csd3,@csd4,@csd5)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ccode", MySqlDbType.VarChar,20),
					new MySqlParameter("@cphone", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstype", MySqlDbType.VarChar,40),
					new MySqlParameter("@csnum", MySqlDbType.Int32,11),
					new MySqlParameter("@csleft", MySqlDbType.Int32,11),
					new MySqlParameter("@csiostatus", MySqlDbType.Int32,11),
					new MySqlParameter("@cstime0", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime1", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime2", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime3", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime4", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime5", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime6", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime7", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime8", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime9", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime10", MySqlDbType.VarChar,20),
					new MySqlParameter("@css1", MySqlDbType.VarChar,20),
					new MySqlParameter("@css2", MySqlDbType.VarChar,20),
					new MySqlParameter("@css3", MySqlDbType.VarChar,20),
					new MySqlParameter("@css4", MySqlDbType.VarChar,20),
					new MySqlParameter("@css5", MySqlDbType.VarChar,20),
					new MySqlParameter("@csd1", MySqlDbType.VarChar,20),
					new MySqlParameter("@csd2", MySqlDbType.VarChar,20),
					new MySqlParameter("@csd3", MySqlDbType.VarChar,20),
					new MySqlParameter("@csd4", MySqlDbType.VarChar,20),
					new MySqlParameter("@csd5", MySqlDbType.VarChar,20)};
			parameters[0].Value = model.ccode;
			parameters[1].Value = model.cphone;
			parameters[2].Value = model.cstype;
			parameters[3].Value = model.csnum;
			parameters[4].Value = model.csleft;
			parameters[5].Value = model.csiostatus;
			parameters[6].Value = model.cstime0;
			parameters[7].Value = model.cstime1;
			parameters[8].Value = model.cstime2;
			parameters[9].Value = model.cstime3;
			parameters[10].Value = model.cstime4;
			parameters[11].Value = model.cstime5;
			parameters[12].Value = model.cstime6;
			parameters[13].Value = model.cstime7;
			parameters[14].Value = model.cstime8;
			parameters[15].Value = model.cstime9;
			parameters[16].Value = model.cstime10;
			parameters[17].Value = model.css1;
			parameters[18].Value = model.css2;
			parameters[19].Value = model.css3;
			parameters[20].Value = model.css4;
			parameters[21].Value = model.css5;
			parameters[22].Value = model.csd1;
			parameters[23].Value = model.csd2;
			parameters[24].Value = model.csd3;
			parameters[25].Value = model.csd4;
			parameters[26].Value = model.csd5;

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
		public bool Update(Jium.Model.consumerservice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update consumerservice set ");
			strSql.Append("ccode=@ccode,");
			strSql.Append("cphone=@cphone,");
			strSql.Append("cstype=@cstype,");
			strSql.Append("csnum=@csnum,");
			strSql.Append("csleft=@csleft,");
			strSql.Append("csiostatus=@csiostatus,");
			strSql.Append("cstime0=@cstime0,");
			strSql.Append("cstime1=@cstime1,");
			strSql.Append("cstime2=@cstime2,");
			strSql.Append("cstime3=@cstime3,");
			strSql.Append("cstime4=@cstime4,");
			strSql.Append("cstime5=@cstime5,");
			strSql.Append("cstime6=@cstime6,");
			strSql.Append("cstime7=@cstime7,");
			strSql.Append("cstime8=@cstime8,");
			strSql.Append("cstime9=@cstime9,");
			strSql.Append("cstime10=@cstime10,");
			strSql.Append("css1=@css1,");
			strSql.Append("css2=@css2,");
			strSql.Append("css3=@css3,");
			strSql.Append("css4=@css4,");
			strSql.Append("css5=@css5,");
			strSql.Append("csd1=@csd1,");
			strSql.Append("csd2=@csd2,");
			strSql.Append("csd3=@csd3,");
			strSql.Append("csd4=@csd4,");
			strSql.Append("csd5=@csd5");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ccode", MySqlDbType.VarChar,20),
					new MySqlParameter("@cphone", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstype", MySqlDbType.VarChar,40),
					new MySqlParameter("@csnum", MySqlDbType.Int32,11),
					new MySqlParameter("@csleft", MySqlDbType.Int32,11),
					new MySqlParameter("@csiostatus", MySqlDbType.Int32,11),
					new MySqlParameter("@cstime0", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime1", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime2", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime3", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime4", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime5", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime6", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime7", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime8", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime9", MySqlDbType.VarChar,20),
					new MySqlParameter("@cstime10", MySqlDbType.VarChar,20),
					new MySqlParameter("@css1", MySqlDbType.VarChar,20),
					new MySqlParameter("@css2", MySqlDbType.VarChar,20),
					new MySqlParameter("@css3", MySqlDbType.VarChar,20),
					new MySqlParameter("@css4", MySqlDbType.VarChar,20),
					new MySqlParameter("@css5", MySqlDbType.VarChar,20),
					new MySqlParameter("@csd1", MySqlDbType.VarChar,20),
					new MySqlParameter("@csd2", MySqlDbType.VarChar,20),
					new MySqlParameter("@csd3", MySqlDbType.VarChar,20),
					new MySqlParameter("@csd4", MySqlDbType.VarChar,20),
					new MySqlParameter("@csd5", MySqlDbType.VarChar,20),
					new MySqlParameter("@id", MySqlDbType.Int64,20)};
			parameters[0].Value = model.ccode;
			parameters[1].Value = model.cphone;
			parameters[2].Value = model.cstype;
			parameters[3].Value = model.csnum;
			parameters[4].Value = model.csleft;
			parameters[5].Value = model.csiostatus;
			parameters[6].Value = model.cstime0;
			parameters[7].Value = model.cstime1;
			parameters[8].Value = model.cstime2;
			parameters[9].Value = model.cstime3;
			parameters[10].Value = model.cstime4;
			parameters[11].Value = model.cstime5;
			parameters[12].Value = model.cstime6;
			parameters[13].Value = model.cstime7;
			parameters[14].Value = model.cstime8;
			parameters[15].Value = model.cstime9;
			parameters[16].Value = model.cstime10;
			parameters[17].Value = model.css1;
			parameters[18].Value = model.css2;
			parameters[19].Value = model.css3;
			parameters[20].Value = model.css4;
			parameters[21].Value = model.css5;
			parameters[22].Value = model.csd1;
			parameters[23].Value = model.csd2;
			parameters[24].Value = model.csd3;
			parameters[25].Value = model.csd4;
			parameters[26].Value = model.csd5;
			parameters[27].Value = model.id;

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
			strSql.Append("delete from consumerservice ");
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
			strSql.Append("delete from consumerservice ");
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
		public Jium.Model.consumerservice GetModel(long id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,ccode,cphone,cstype,csnum,csleft,csiostatus,cstime0,cstime1,cstime2,cstime3,cstime4,cstime5,cstime6,cstime7,cstime8,cstime9,cstime10,css1,css2,css3,css4,css5,csd1,csd2,csd3,csd4,csd5 from consumerservice ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64)
			};
			parameters[0].Value = id;

            Jium.Model.consumerservice model=new Jium.Model.consumerservice();
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
		public Jium.Model.consumerservice DataRowToModel(DataRow row)
		{
            Jium.Model.consumerservice model=new Jium.Model.consumerservice();
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
				if(row["cphone"]!=null)
				{
					model.cphone=row["cphone"].ToString();
				}
				if(row["cstype"]!=null)
				{
					model.cstype=row["cstype"].ToString();
				}
				if(row["csnum"]!=null && row["csnum"].ToString()!="")
				{
					model.csnum=int.Parse(row["csnum"].ToString());
				}
				if(row["csleft"]!=null && row["csleft"].ToString()!="")
				{
					model.csleft=int.Parse(row["csleft"].ToString());
				}
				if(row["csiostatus"]!=null && row["csiostatus"].ToString()!="")
				{
					model.csiostatus=int.Parse(row["csiostatus"].ToString());
				}
				if(row["cstime0"]!=null)
				{
					model.cstime0=row["cstime0"].ToString();
				}
				if(row["cstime1"]!=null)
				{
					model.cstime1=row["cstime1"].ToString();
				}
				if(row["cstime2"]!=null)
				{
					model.cstime2=row["cstime2"].ToString();
				}
				if(row["cstime3"]!=null)
				{
					model.cstime3=row["cstime3"].ToString();
				}
				if(row["cstime4"]!=null)
				{
					model.cstime4=row["cstime4"].ToString();
				}
				if(row["cstime5"]!=null)
				{
					model.cstime5=row["cstime5"].ToString();
				}
				if(row["cstime6"]!=null)
				{
					model.cstime6=row["cstime6"].ToString();
				}
				if(row["cstime7"]!=null)
				{
					model.cstime7=row["cstime7"].ToString();
				}
				if(row["cstime8"]!=null)
				{
					model.cstime8=row["cstime8"].ToString();
				}
				if(row["cstime9"]!=null)
				{
					model.cstime9=row["cstime9"].ToString();
				}
				if(row["cstime10"]!=null)
				{
					model.cstime10=row["cstime10"].ToString();
				}
				if(row["css1"]!=null)
				{
					model.css1=row["css1"].ToString();
				}
				if(row["css2"]!=null)
				{
					model.css2=row["css2"].ToString();
				}
				if(row["css3"]!=null)
				{
					model.css3=row["css3"].ToString();
				}
				if(row["css4"]!=null)
				{
					model.css4=row["css4"].ToString();
				}
				if(row["css5"]!=null)
				{
					model.css5=row["css5"].ToString();
				}
				if(row["csd1"]!=null)
				{
					model.csd1=row["csd1"].ToString();
				}
				if(row["csd2"]!=null)
				{
					model.csd2=row["csd2"].ToString();
				}
				if(row["csd3"]!=null)
				{
					model.csd3=row["csd3"].ToString();
				}
				if(row["csd4"]!=null)
				{
					model.csd4=row["csd4"].ToString();
				}
				if(row["csd5"]!=null)
				{
					model.csd5=row["csd5"].ToString();
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
			strSql.Append("select id,ccode,cphone,cstype,csnum,csleft,csiostatus,cstime0,cstime1,cstime2,cstime3,cstime4,cstime5,cstime6,cstime7,cstime8,cstime9,cstime10,css1,css2,css3,css4,css5,csd1,csd2,csd3,csd4,csd5 ");
			strSql.Append(" FROM consumerservice ");
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
			strSql.Append("select count(1) FROM consumerservice ");
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
			strSql.Append(")AS Row, T.*  from consumerservice T ");
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
			parameters[0].Value = "consumerservice";
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

