using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Jium.DAL
{
	/// <summary>
	/// 数据访问类:consumer
	/// </summary>
	public partial class consumer
	{
		public consumer()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "consumer"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from consumer");
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
		public bool Add(Jium.Model.consumer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into consumer(");
			strSql.Append("cname,ccode,cphone,cemail,clevel,csum,csex,cremark,css1,css2,css3,css4,css5,csd1,csd2,csd3,csd4,csd5,csdc1,csdc2,csdc3,csdc4,csdc5)");
			strSql.Append(" values (");
			strSql.Append("@cname,@ccode,@cphone,@cemail,@clevel,@csum,@csex,@cremark,@css1,@css2,@css3,@css4,@css5,@csd1,@csd2,@csd3,@csd4,@csd5,@csdc1,@csdc2,@csdc3,@csdc4,@csdc5)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@cname", MySqlDbType.VarChar,40),
					new MySqlParameter("@ccode", MySqlDbType.VarChar,20),
					new MySqlParameter("@cphone", MySqlDbType.VarChar,20),
					new MySqlParameter("@cemail", MySqlDbType.VarChar,50),
					new MySqlParameter("@clevel", MySqlDbType.VarChar,11),
					new MySqlParameter("@csum", MySqlDbType.Decimal,20),
					new MySqlParameter("@csex", MySqlDbType.Int32,11),
					new MySqlParameter("@cremark", MySqlDbType.VarChar,200),
					new MySqlParameter("@css1", MySqlDbType.VarChar,20),
					new MySqlParameter("@css2", MySqlDbType.VarChar,20),
					new MySqlParameter("@css3", MySqlDbType.VarChar,20),
					new MySqlParameter("@css4", MySqlDbType.VarChar,20),
					new MySqlParameter("@css5", MySqlDbType.VarChar,20),
					new MySqlParameter("@csd1", MySqlDbType.Int32,11),
					new MySqlParameter("@csd2", MySqlDbType.Int32,11),
					new MySqlParameter("@csd3", MySqlDbType.Int32,11),
					new MySqlParameter("@csd4", MySqlDbType.Int32,11),
					new MySqlParameter("@csd5", MySqlDbType.Int32,11),
					new MySqlParameter("@csdc1", MySqlDbType.Decimal,20),
					new MySqlParameter("@csdc2", MySqlDbType.Decimal,20),
					new MySqlParameter("@csdc3", MySqlDbType.Decimal,20),
					new MySqlParameter("@csdc4", MySqlDbType.Decimal,20),
					new MySqlParameter("@csdc5", MySqlDbType.Decimal,20)};
			parameters[0].Value = model.cname;
			parameters[1].Value = model.ccode;
			parameters[2].Value = model.cphone;
			parameters[3].Value = model.cemail;
			parameters[4].Value = model.clevel;
			parameters[5].Value = model.csum;
			parameters[6].Value = model.csex;
			parameters[7].Value = model.cremark;
			parameters[8].Value = model.css1;
			parameters[9].Value = model.css2;
			parameters[10].Value = model.css3;
			parameters[11].Value = model.css4;
			parameters[12].Value = model.css5;
			parameters[13].Value = model.csd1;
			parameters[14].Value = model.csd2;
			parameters[15].Value = model.csd3;
			parameters[16].Value = model.csd4;
			parameters[17].Value = model.csd5;
			parameters[18].Value = model.csdc1;
			parameters[19].Value = model.csdc2;
			parameters[20].Value = model.csdc3;
			parameters[21].Value = model.csdc4;
			parameters[22].Value = model.csdc5;

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
		public bool Update(Jium.Model.consumer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update consumer set ");
			strSql.Append("cname=@cname,");
			strSql.Append("ccode=@ccode,");
			strSql.Append("cphone=@cphone,");
			strSql.Append("cemail=@cemail,");
			strSql.Append("clevel=@clevel,");
			strSql.Append("csum=@csum,");
			strSql.Append("csex=@csex,");
			strSql.Append("cremark=@cremark,");
			strSql.Append("css1=@css1,");
			strSql.Append("css2=@css2,");
			strSql.Append("css3=@css3,");
			strSql.Append("css4=@css4,");
			strSql.Append("css5=@css5,");
			strSql.Append("csd1=@csd1,");
			strSql.Append("csd2=@csd2,");
			strSql.Append("csd3=@csd3,");
			strSql.Append("csd4=@csd4,");
			strSql.Append("csd5=@csd5,");
			strSql.Append("csdc1=@csdc1,");
			strSql.Append("csdc2=@csdc2,");
			strSql.Append("csdc3=@csdc3,");
			strSql.Append("csdc4=@csdc4,");
			strSql.Append("csdc5=@csdc5");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@cname", MySqlDbType.VarChar,40),
					new MySqlParameter("@ccode", MySqlDbType.VarChar,20),
					new MySqlParameter("@cphone", MySqlDbType.VarChar,20),
					new MySqlParameter("@cemail", MySqlDbType.VarChar,50),
					new MySqlParameter("@clevel", MySqlDbType.VarChar,11),
					new MySqlParameter("@csum", MySqlDbType.Decimal,20),
					new MySqlParameter("@csex", MySqlDbType.Int32,11),
					new MySqlParameter("@cremark", MySqlDbType.VarChar,200),
					new MySqlParameter("@css1", MySqlDbType.VarChar,20),
					new MySqlParameter("@css2", MySqlDbType.VarChar,20),
					new MySqlParameter("@css3", MySqlDbType.VarChar,20),
					new MySqlParameter("@css4", MySqlDbType.VarChar,20),
					new MySqlParameter("@css5", MySqlDbType.VarChar,20),
					new MySqlParameter("@csd1", MySqlDbType.Int32,11),
					new MySqlParameter("@csd2", MySqlDbType.Int32,11),
					new MySqlParameter("@csd3", MySqlDbType.Int32,11),
					new MySqlParameter("@csd4", MySqlDbType.Int32,11),
					new MySqlParameter("@csd5", MySqlDbType.Int32,11),
					new MySqlParameter("@csdc1", MySqlDbType.Decimal,20),
					new MySqlParameter("@csdc2", MySqlDbType.Decimal,20),
					new MySqlParameter("@csdc3", MySqlDbType.Decimal,20),
					new MySqlParameter("@csdc4", MySqlDbType.Decimal,20),
					new MySqlParameter("@csdc5", MySqlDbType.Decimal,20),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.cname;
			parameters[1].Value = model.ccode;
			parameters[2].Value = model.cphone;
			parameters[3].Value = model.cemail;
			parameters[4].Value = model.clevel;
			parameters[5].Value = model.csum;
			parameters[6].Value = model.csex;
			parameters[7].Value = model.cremark;
			parameters[8].Value = model.css1;
			parameters[9].Value = model.css2;
			parameters[10].Value = model.css3;
			parameters[11].Value = model.css4;
			parameters[12].Value = model.css5;
			parameters[13].Value = model.csd1;
			parameters[14].Value = model.csd2;
			parameters[15].Value = model.csd3;
			parameters[16].Value = model.csd4;
			parameters[17].Value = model.csd5;
			parameters[18].Value = model.csdc1;
			parameters[19].Value = model.csdc2;
			parameters[20].Value = model.csdc3;
			parameters[21].Value = model.csdc4;
			parameters[22].Value = model.csdc5;
			parameters[23].Value = model.id;

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
			strSql.Append("delete from consumer ");
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
			strSql.Append("delete from consumer ");
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
		public Jium.Model.consumer GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,cname,ccode,cphone,cemail,clevel,csum,csex,cremark,css1,css2,css3,css4,css5,csd1,csd2,csd3,csd4,csd5,csdc1,csdc2,csdc3,csdc4,csdc5 from consumer ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			Jium.Model.consumer model=new Jium.Model.consumer();
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
		public Jium.Model.consumer DataRowToModel(DataRow row)
		{
			Jium.Model.consumer model=new Jium.Model.consumer();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["cname"]!=null)
				{
					model.cname=row["cname"].ToString();
				}
				if(row["ccode"]!=null)
				{
					model.ccode=row["ccode"].ToString();
				}
				if(row["cphone"]!=null)
				{
					model.cphone=row["cphone"].ToString();
				}
				if(row["cemail"]!=null)
				{
					model.cemail=row["cemail"].ToString();
				}
				if(row["clevel"]!=null)
				{
					model.clevel=row["clevel"].ToString();
				}
				if(row["csum"]!=null && row["csum"].ToString()!="")
				{
					model.csum=decimal.Parse(row["csum"].ToString());
				}
				if(row["csex"]!=null && row["csex"].ToString()!="")
				{
					model.csex=int.Parse(row["csex"].ToString());
				}
				if(row["cremark"]!=null)
				{
					model.cremark=row["cremark"].ToString();
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
				if(row["csd1"]!=null && row["csd1"].ToString()!="")
				{
					model.csd1=int.Parse(row["csd1"].ToString());
				}
				if(row["csd2"]!=null && row["csd2"].ToString()!="")
				{
					model.csd2=int.Parse(row["csd2"].ToString());
				}
				if(row["csd3"]!=null && row["csd3"].ToString()!="")
				{
					model.csd3=int.Parse(row["csd3"].ToString());
				}
				if(row["csd4"]!=null && row["csd4"].ToString()!="")
				{
					model.csd4=int.Parse(row["csd4"].ToString());
				}
				if(row["csd5"]!=null && row["csd5"].ToString()!="")
				{
					model.csd5=int.Parse(row["csd5"].ToString());
				}
				if(row["csdc1"]!=null && row["csdc1"].ToString()!="")
				{
					model.csdc1=decimal.Parse(row["csdc1"].ToString());
				}
				if(row["csdc2"]!=null && row["csdc2"].ToString()!="")
				{
					model.csdc2=decimal.Parse(row["csdc2"].ToString());
				}
				if(row["csdc3"]!=null && row["csdc3"].ToString()!="")
				{
					model.csdc3=decimal.Parse(row["csdc3"].ToString());
				}
				if(row["csdc4"]!=null && row["csdc4"].ToString()!="")
				{
					model.csdc4=decimal.Parse(row["csdc4"].ToString());
				}
				if(row["csdc5"]!=null && row["csdc5"].ToString()!="")
				{
					model.csdc5=decimal.Parse(row["csdc5"].ToString());
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
			strSql.Append("select id,cname,ccode,cphone,cemail,clevel,csum,csex,cremark,css1,css2,css3,css4,css5,csd1,csd2,csd3,csd4,csd5,csdc1,csdc2,csdc3,csdc4,csdc5 ");
			strSql.Append(" FROM consumer ");
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
			strSql.Append("select count(1) FROM consumer ");
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
			strSql.Append(")AS Row, T.*  from consumer T ");
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
			parameters[0].Value = "consumer";
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

