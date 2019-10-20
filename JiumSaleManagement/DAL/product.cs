using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Jium.DAL
{
	/// <summary>
	/// 数据访问类:product
	/// </summary>
	public partial class product
	{
		public product()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "product"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from product");
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
		public bool Add(Jium.Model.product model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into product(");
			strSql.Append("pcode,pname,psaleprice,prealprice,ptype,pisgroup,pdesc,ps1,ps2,ps3,ps4,ps5,pd1,pd2,pd3,pd4,pd5,pdc1,pdc2,pdc3)");
			strSql.Append(" values (");
			strSql.Append("@pcode,@pname,@psaleprice,@prealprice,@ptype,@pisgroup,@pdesc,@ps1,@ps2,@ps3,@ps4,@ps5,@pd1,@pd2,@pd3,@pd4,@pd5,@pdc1,@pdc2,@pdc3)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@pcode", MySqlDbType.VarChar,20),
					new MySqlParameter("@pname", MySqlDbType.VarChar,50),
					new MySqlParameter("@psaleprice", MySqlDbType.Decimal,20),
					new MySqlParameter("@prealprice", MySqlDbType.Decimal,20),
					new MySqlParameter("@ptype", MySqlDbType.VarChar,20),
					new MySqlParameter("@pisgroup", MySqlDbType.Int32,11),
					new MySqlParameter("@pdesc", MySqlDbType.VarChar,200),
					new MySqlParameter("@ps1", MySqlDbType.VarChar,20),
					new MySqlParameter("@ps2", MySqlDbType.VarChar,20),
					new MySqlParameter("@ps3", MySqlDbType.VarChar,20),
					new MySqlParameter("@ps4", MySqlDbType.VarChar,20),
					new MySqlParameter("@ps5", MySqlDbType.VarChar,20),
					new MySqlParameter("@pd1", MySqlDbType.Int32,11),
					new MySqlParameter("@pd2", MySqlDbType.Int32,11),
					new MySqlParameter("@pd3", MySqlDbType.Int32,11),
					new MySqlParameter("@pd4", MySqlDbType.Int32,11),
					new MySqlParameter("@pd5", MySqlDbType.Int32,11),
					new MySqlParameter("@pdc1", MySqlDbType.Decimal,20),
					new MySqlParameter("@pdc2", MySqlDbType.Decimal,20),
					new MySqlParameter("@pdc3", MySqlDbType.Decimal,20)};
			parameters[0].Value = model.pcode;
			parameters[1].Value = model.pname;
			parameters[2].Value = model.psaleprice;
			parameters[3].Value = model.prealprice;
			parameters[4].Value = model.ptype;
			parameters[5].Value = model.pisgroup;
			parameters[6].Value = model.pdesc;
			parameters[7].Value = model.ps1;
			parameters[8].Value = model.ps2;
			parameters[9].Value = model.ps3;
			parameters[10].Value = model.ps4;
			parameters[11].Value = model.ps5;
			parameters[12].Value = model.pd1;
			parameters[13].Value = model.pd2;
			parameters[14].Value = model.pd3;
			parameters[15].Value = model.pd4;
			parameters[16].Value = model.pd5;
			parameters[17].Value = model.pdc1;
			parameters[18].Value = model.pdc2;
			parameters[19].Value = model.pdc3;

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
		public bool Update(Jium.Model.product model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update product set ");
			strSql.Append("pcode=@pcode,");
			strSql.Append("pname=@pname,");
			strSql.Append("psaleprice=@psaleprice,");
			strSql.Append("prealprice=@prealprice,");
			strSql.Append("ptype=@ptype,");
			strSql.Append("pisgroup=@pisgroup,");
			strSql.Append("pdesc=@pdesc,");
			strSql.Append("ps1=@ps1,");
			strSql.Append("ps2=@ps2,");
			strSql.Append("ps3=@ps3,");
			strSql.Append("ps4=@ps4,");
			strSql.Append("ps5=@ps5,");
			strSql.Append("pd1=@pd1,");
			strSql.Append("pd2=@pd2,");
			strSql.Append("pd3=@pd3,");
			strSql.Append("pd4=@pd4,");
			strSql.Append("pd5=@pd5,");
			strSql.Append("pdc1=@pdc1,");
			strSql.Append("pdc2=@pdc2,");
			strSql.Append("pdc3=@pdc3");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@pcode", MySqlDbType.VarChar,20),
					new MySqlParameter("@pname", MySqlDbType.VarChar,50),
					new MySqlParameter("@psaleprice", MySqlDbType.Decimal,20),
					new MySqlParameter("@prealprice", MySqlDbType.Decimal,20),
					new MySqlParameter("@ptype", MySqlDbType.VarChar,20),
					new MySqlParameter("@pisgroup", MySqlDbType.Int32,11),
					new MySqlParameter("@pdesc", MySqlDbType.VarChar,200),
					new MySqlParameter("@ps1", MySqlDbType.VarChar,20),
					new MySqlParameter("@ps2", MySqlDbType.VarChar,20),
					new MySqlParameter("@ps3", MySqlDbType.VarChar,20),
					new MySqlParameter("@ps4", MySqlDbType.VarChar,20),
					new MySqlParameter("@ps5", MySqlDbType.VarChar,20),
					new MySqlParameter("@pd1", MySqlDbType.Int32,11),
					new MySqlParameter("@pd2", MySqlDbType.Int32,11),
					new MySqlParameter("@pd3", MySqlDbType.Int32,11),
					new MySqlParameter("@pd4", MySqlDbType.Int32,11),
					new MySqlParameter("@pd5", MySqlDbType.Int32,11),
					new MySqlParameter("@pdc1", MySqlDbType.Decimal,20),
					new MySqlParameter("@pdc2", MySqlDbType.Decimal,20),
					new MySqlParameter("@pdc3", MySqlDbType.Decimal,20),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.pcode;
			parameters[1].Value = model.pname;
			parameters[2].Value = model.psaleprice;
			parameters[3].Value = model.prealprice;
			parameters[4].Value = model.ptype;
			parameters[5].Value = model.pisgroup;
			parameters[6].Value = model.pdesc;
			parameters[7].Value = model.ps1;
			parameters[8].Value = model.ps2;
			parameters[9].Value = model.ps3;
			parameters[10].Value = model.ps4;
			parameters[11].Value = model.ps5;
			parameters[12].Value = model.pd1;
			parameters[13].Value = model.pd2;
			parameters[14].Value = model.pd3;
			parameters[15].Value = model.pd4;
			parameters[16].Value = model.pd5;
			parameters[17].Value = model.pdc1;
			parameters[18].Value = model.pdc2;
			parameters[19].Value = model.pdc3;
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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from product ");
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
			strSql.Append("delete from product ");
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
		public Jium.Model.product GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,pcode,pname,psaleprice,prealprice,ptype,pisgroup,pdesc,ps1,ps2,ps3,ps4,ps5,pd1,pd2,pd3,pd4,pd5,pdc1,pdc2,pdc3 from product ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			Jium.Model.product model=new Jium.Model.product();
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
		public Jium.Model.product DataRowToModel(DataRow row)
		{
			Jium.Model.product model=new Jium.Model.product();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["pcode"]!=null)
				{
					model.pcode=row["pcode"].ToString();
				}
				if(row["pname"]!=null)
				{
					model.pname=row["pname"].ToString();
				}
				if(row["psaleprice"]!=null && row["psaleprice"].ToString()!="")
				{
					model.psaleprice=decimal.Parse(row["psaleprice"].ToString());
				}
				if(row["prealprice"]!=null && row["prealprice"].ToString()!="")
				{
					model.prealprice=decimal.Parse(row["prealprice"].ToString());
				}
				if(row["ptype"]!=null)
				{
					model.ptype=row["ptype"].ToString();
				}
				if(row["pisgroup"]!=null && row["pisgroup"].ToString()!="")
				{
					model.pisgroup=int.Parse(row["pisgroup"].ToString());
				}
				if(row["pdesc"]!=null)
				{
					model.pdesc=row["pdesc"].ToString();
				}
				if(row["ps1"]!=null)
				{
					model.ps1=row["ps1"].ToString();
				}
				if(row["ps2"]!=null)
				{
					model.ps2=row["ps2"].ToString();
				}
				if(row["ps3"]!=null)
				{
					model.ps3=row["ps3"].ToString();
				}
				if(row["ps4"]!=null)
				{
					model.ps4=row["ps4"].ToString();
				}
				if(row["ps5"]!=null)
				{
					model.ps5=row["ps5"].ToString();
				}
				if(row["pd1"]!=null && row["pd1"].ToString()!="")
				{
					model.pd1=int.Parse(row["pd1"].ToString());
				}
				if(row["pd2"]!=null && row["pd2"].ToString()!="")
				{
					model.pd2=int.Parse(row["pd2"].ToString());
				}
				if(row["pd3"]!=null && row["pd3"].ToString()!="")
				{
					model.pd3=int.Parse(row["pd3"].ToString());
				}
				if(row["pd4"]!=null && row["pd4"].ToString()!="")
				{
					model.pd4=int.Parse(row["pd4"].ToString());
				}
				if(row["pd5"]!=null && row["pd5"].ToString()!="")
				{
					model.pd5=int.Parse(row["pd5"].ToString());
				}
				if(row["pdc1"]!=null && row["pdc1"].ToString()!="")
				{
					model.pdc1=decimal.Parse(row["pdc1"].ToString());
				}
				if(row["pdc2"]!=null && row["pdc2"].ToString()!="")
				{
					model.pdc2=decimal.Parse(row["pdc2"].ToString());
				}
				if(row["pdc3"]!=null && row["pdc3"].ToString()!="")
				{
					model.pdc3=decimal.Parse(row["pdc3"].ToString());
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
			strSql.Append("select id,pcode,pname,psaleprice,prealprice,ptype,pisgroup,pdesc,ps1,ps2,ps3,ps4,ps5,pd1,pd2,pd3,pd4,pd5,pdc1,pdc2,pdc3 ");
			strSql.Append(" FROM product ");
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
			strSql.Append("select count(1) FROM product ");
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
			strSql.Append(")AS Row, T.*  from product T ");
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
			parameters[0].Value = "product";
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

