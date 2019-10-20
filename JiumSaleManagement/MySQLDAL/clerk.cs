using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Jium.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Jium.MySQLDAL
{
	/// <summary>
	/// 数据访问类:clerk
	/// </summary>
	public partial class clerk:Iclerk
	{
		public clerk()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "clerk"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ccode,int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from clerk");
			strSql.Append(" where ccode=@ccode and id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ccode", MySqlDbType.VarChar,20),
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
			parameters[0].Value = ccode;
			parameters[1].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Jium.Model.clerk model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into clerk(");
			strSql.Append("cname,cphone,cemail,csex,clevel,ccode,caddress,csalesum,cremark,cls1,cls2,cls3,cls4,cls5,cld1,cld2,cld3,cld4,cld5,cldc1,cldc2,cldc3,cldc4,cldc5)");
			strSql.Append(" values (");
			strSql.Append("@cname,@cphone,@cemail,@csex,@clevel,@ccode,@caddress,@csalesum,@cremark,@cls1,@cls2,@cls3,@cls4,@cls5,@cld1,@cld2,@cld3,@cld4,@cld5,@cldc1,@cldc2,@cldc3,@cldc4,@cldc5)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@cname", MySqlDbType.VarChar,40),
					new MySqlParameter("@cphone", MySqlDbType.VarChar,20),
					new MySqlParameter("@cemail", MySqlDbType.VarChar,50),
					new MySqlParameter("@csex", MySqlDbType.Int32,11),
					new MySqlParameter("@clevel", MySqlDbType.Int32,11),
					new MySqlParameter("@ccode", MySqlDbType.VarChar,20),
					new MySqlParameter("@caddress", MySqlDbType.VarChar,100),
					new MySqlParameter("@csalesum", MySqlDbType.Decimal,20),
					new MySqlParameter("@cremark", MySqlDbType.VarChar,200),
					new MySqlParameter("@cls1", MySqlDbType.VarChar,20),
					new MySqlParameter("@cls2", MySqlDbType.VarChar,20),
					new MySqlParameter("@cls3", MySqlDbType.VarChar,20),
					new MySqlParameter("@cls4", MySqlDbType.VarChar,20),
					new MySqlParameter("@cls5", MySqlDbType.VarChar,20),
					new MySqlParameter("@cld1", MySqlDbType.Int32,11),
					new MySqlParameter("@cld2", MySqlDbType.Int32,11),
					new MySqlParameter("@cld3", MySqlDbType.Int32,11),
					new MySqlParameter("@cld4", MySqlDbType.Int32,11),
					new MySqlParameter("@cld5", MySqlDbType.Int32,11),
					new MySqlParameter("@cldc1", MySqlDbType.Decimal,20),
					new MySqlParameter("@cldc2", MySqlDbType.Decimal,20),
					new MySqlParameter("@cldc3", MySqlDbType.Decimal,20),
					new MySqlParameter("@cldc4", MySqlDbType.Decimal,20),
					new MySqlParameter("@cldc5", MySqlDbType.Decimal,20)};
			parameters[0].Value = model.cname;
			parameters[1].Value = model.cphone;
			parameters[2].Value = model.cemail;
			parameters[3].Value = model.csex;
			parameters[4].Value = model.clevel;
			parameters[5].Value = model.ccode;
			parameters[6].Value = model.caddress;
			parameters[7].Value = model.csalesum;
			parameters[8].Value = model.cremark;
			parameters[9].Value = model.cls1;
			parameters[10].Value = model.cls2;
			parameters[11].Value = model.cls3;
			parameters[12].Value = model.cls4;
			parameters[13].Value = model.cls5;
			parameters[14].Value = model.cld1;
			parameters[15].Value = model.cld2;
			parameters[16].Value = model.cld3;
			parameters[17].Value = model.cld4;
			parameters[18].Value = model.cld5;
			parameters[19].Value = model.cldc1;
			parameters[20].Value = model.cldc2;
			parameters[21].Value = model.cldc3;
			parameters[22].Value = model.cldc4;
			parameters[23].Value = model.cldc5;

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
		public bool Update(Jium.Model.clerk model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update clerk set ");
			strSql.Append("cname=@cname,");
			strSql.Append("cphone=@cphone,");
			strSql.Append("cemail=@cemail,");
			strSql.Append("csex=@csex,");
			strSql.Append("clevel=@clevel,");
			strSql.Append("caddress=@caddress,");
			strSql.Append("csalesum=@csalesum,");
			strSql.Append("cremark=@cremark,");
			strSql.Append("cls1=@cls1,");
			strSql.Append("cls2=@cls2,");
			strSql.Append("cls3=@cls3,");
			strSql.Append("cls4=@cls4,");
			strSql.Append("cls5=@cls5,");
			strSql.Append("cld1=@cld1,");
			strSql.Append("cld2=@cld2,");
			strSql.Append("cld3=@cld3,");
			strSql.Append("cld4=@cld4,");
			strSql.Append("cld5=@cld5,");
			strSql.Append("cldc1=@cldc1,");
			strSql.Append("cldc2=@cldc2,");
			strSql.Append("cldc3=@cldc3,");
			strSql.Append("cldc4=@cldc4,");
			strSql.Append("cldc5=@cldc5");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@cname", MySqlDbType.VarChar,40),
					new MySqlParameter("@cphone", MySqlDbType.VarChar,20),
					new MySqlParameter("@cemail", MySqlDbType.VarChar,50),
					new MySqlParameter("@csex", MySqlDbType.Int32,11),
					new MySqlParameter("@clevel", MySqlDbType.Int32,11),
					new MySqlParameter("@caddress", MySqlDbType.VarChar,100),
					new MySqlParameter("@csalesum", MySqlDbType.Decimal,20),
					new MySqlParameter("@cremark", MySqlDbType.VarChar,200),
					new MySqlParameter("@cls1", MySqlDbType.VarChar,20),
					new MySqlParameter("@cls2", MySqlDbType.VarChar,20),
					new MySqlParameter("@cls3", MySqlDbType.VarChar,20),
					new MySqlParameter("@cls4", MySqlDbType.VarChar,20),
					new MySqlParameter("@cls5", MySqlDbType.VarChar,20),
					new MySqlParameter("@cld1", MySqlDbType.Int32,11),
					new MySqlParameter("@cld2", MySqlDbType.Int32,11),
					new MySqlParameter("@cld3", MySqlDbType.Int32,11),
					new MySqlParameter("@cld4", MySqlDbType.Int32,11),
					new MySqlParameter("@cld5", MySqlDbType.Int32,11),
					new MySqlParameter("@cldc1", MySqlDbType.Decimal,20),
					new MySqlParameter("@cldc2", MySqlDbType.Decimal,20),
					new MySqlParameter("@cldc3", MySqlDbType.Decimal,20),
					new MySqlParameter("@cldc4", MySqlDbType.Decimal,20),
					new MySqlParameter("@cldc5", MySqlDbType.Decimal,20),
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@ccode", MySqlDbType.VarChar,20)};
			parameters[0].Value = model.cname;
			parameters[1].Value = model.cphone;
			parameters[2].Value = model.cemail;
			parameters[3].Value = model.csex;
			parameters[4].Value = model.clevel;
			parameters[5].Value = model.caddress;
			parameters[6].Value = model.csalesum;
			parameters[7].Value = model.cremark;
			parameters[8].Value = model.cls1;
			parameters[9].Value = model.cls2;
			parameters[10].Value = model.cls3;
			parameters[11].Value = model.cls4;
			parameters[12].Value = model.cls5;
			parameters[13].Value = model.cld1;
			parameters[14].Value = model.cld2;
			parameters[15].Value = model.cld3;
			parameters[16].Value = model.cld4;
			parameters[17].Value = model.cld5;
			parameters[18].Value = model.cldc1;
			parameters[19].Value = model.cldc2;
			parameters[20].Value = model.cldc3;
			parameters[21].Value = model.cldc4;
			parameters[22].Value = model.cldc5;
			parameters[23].Value = model.id;
			parameters[24].Value = model.ccode;

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
			strSql.Append("delete from clerk ");
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ccode,int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from clerk ");
			strSql.Append(" where ccode=@ccode and id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ccode", MySqlDbType.VarChar,20),
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
			parameters[0].Value = ccode;
			parameters[1].Value = id;

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
			strSql.Append("delete from clerk ");
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
		public Jium.Model.clerk GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,cname,cphone,cemail,csex,clevel,ccode,caddress,csalesum,cremark,cls1,cls2,cls3,cls4,cls5,cld1,cld2,cld3,cld4,cld5,cldc1,cldc2,cldc3,cldc4,cldc5 from clerk ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			Jium.Model.clerk model=new Jium.Model.clerk();
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
		public Jium.Model.clerk DataRowToModel(DataRow row)
		{
			Jium.Model.clerk model=new Jium.Model.clerk();
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
				if(row["cphone"]!=null)
				{
					model.cphone=row["cphone"].ToString();
				}
				if(row["cemail"]!=null)
				{
					model.cemail=row["cemail"].ToString();
				}
				if(row["csex"]!=null && row["csex"].ToString()!="")
				{
					model.csex=int.Parse(row["csex"].ToString());
				}
				if(row["clevel"]!=null && row["clevel"].ToString()!="")
				{
					model.clevel=int.Parse(row["clevel"].ToString());
				}
				if(row["ccode"]!=null)
				{
					model.ccode=row["ccode"].ToString();
				}
				if(row["caddress"]!=null)
				{
					model.caddress=row["caddress"].ToString();
				}
				if(row["csalesum"]!=null && row["csalesum"].ToString()!="")
				{
					model.csalesum=decimal.Parse(row["csalesum"].ToString());
				}
				if(row["cremark"]!=null)
				{
					model.cremark=row["cremark"].ToString();
				}
				if(row["cls1"]!=null)
				{
					model.cls1=row["cls1"].ToString();
				}
				if(row["cls2"]!=null)
				{
					model.cls2=row["cls2"].ToString();
				}
				if(row["cls3"]!=null)
				{
					model.cls3=row["cls3"].ToString();
				}
				if(row["cls4"]!=null)
				{
					model.cls4=row["cls4"].ToString();
				}
				if(row["cls5"]!=null)
				{
					model.cls5=row["cls5"].ToString();
				}
				if(row["cld1"]!=null && row["cld1"].ToString()!="")
				{
					model.cld1=int.Parse(row["cld1"].ToString());
				}
				if(row["cld2"]!=null && row["cld2"].ToString()!="")
				{
					model.cld2=int.Parse(row["cld2"].ToString());
				}
				if(row["cld3"]!=null && row["cld3"].ToString()!="")
				{
					model.cld3=int.Parse(row["cld3"].ToString());
				}
				if(row["cld4"]!=null && row["cld4"].ToString()!="")
				{
					model.cld4=int.Parse(row["cld4"].ToString());
				}
				if(row["cld5"]!=null && row["cld5"].ToString()!="")
				{
					model.cld5=int.Parse(row["cld5"].ToString());
				}
				if(row["cldc1"]!=null && row["cldc1"].ToString()!="")
				{
					model.cldc1=decimal.Parse(row["cldc1"].ToString());
				}
				if(row["cldc2"]!=null && row["cldc2"].ToString()!="")
				{
					model.cldc2=decimal.Parse(row["cldc2"].ToString());
				}
				if(row["cldc3"]!=null && row["cldc3"].ToString()!="")
				{
					model.cldc3=decimal.Parse(row["cldc3"].ToString());
				}
				if(row["cldc4"]!=null && row["cldc4"].ToString()!="")
				{
					model.cldc4=decimal.Parse(row["cldc4"].ToString());
				}
				if(row["cldc5"]!=null && row["cldc5"].ToString()!="")
				{
					model.cldc5=decimal.Parse(row["cldc5"].ToString());
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
			strSql.Append("select id,cname,cphone,cemail,csex,clevel,ccode,caddress,csalesum,cremark,cls1,cls2,cls3,cls4,cls5,cld1,cld2,cld3,cld4,cld5,cldc1,cldc2,cldc3,cldc4,cldc5 ");
			strSql.Append(" FROM clerk ");
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
			strSql.Append("select count(1) FROM clerk ");
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
			strSql.Append(")AS Row, T.*  from clerk T ");
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
			parameters[0].Value = "clerk";
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

