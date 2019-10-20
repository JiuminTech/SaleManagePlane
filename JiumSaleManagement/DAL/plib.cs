using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Jium.DAL
{
	/// <summary>
	/// 数据访问类:plib
	/// </summary>
	public partial class plib
	{
		public plib()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id,string pcode)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from plib");
			strSql.Append(" where id=@id and pcode=@pcode ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.bigint,20),
					new MySqlParameter("@pcode", MySqlDbType.VarChar,20)			};
			parameters[0].Value = id;
			parameters[1].Value = pcode;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Jium.Model.plib model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into plib(");
			strSql.Append("id,pcode,pname,pdesc,pleftcnt,plupdatetime,psumcnt,psalecnt,pls1,pls2,pls3,pls4,pls5,pld1,pld2,pld3,pld4,pld5)");
			strSql.Append(" values (");
			strSql.Append("@id,@pcode,@pname,@pdesc,@pleftcnt,@plupdatetime,@psumcnt,@psalecnt,@pls1,@pls2,@pls3,@pls4,@pls5,@pld1,@pld2,@pld3,@pld4,@pld5)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.bigint,20),
					new MySqlParameter("@pcode", MySqlDbType.VarChar,20),
					new MySqlParameter("@pname", MySqlDbType.VarChar,50),
					new MySqlParameter("@pdesc", MySqlDbType.VarChar,200),
					new MySqlParameter("@pleftcnt", MySqlDbType.Int32,11),
					new MySqlParameter("@plupdatetime", MySqlDbType.VarChar,20),
					new MySqlParameter("@psumcnt", MySqlDbType.Int32,11),
					new MySqlParameter("@psalecnt", MySqlDbType.Int32,11),
					new MySqlParameter("@pls1", MySqlDbType.VarChar,20),
					new MySqlParameter("@pls2", MySqlDbType.VarChar,20),
					new MySqlParameter("@pls3", MySqlDbType.VarChar,20),
					new MySqlParameter("@pls4", MySqlDbType.VarChar,20),
					new MySqlParameter("@pls5", MySqlDbType.VarChar,20),
					new MySqlParameter("@pld1", MySqlDbType.Int32,11),
					new MySqlParameter("@pld2", MySqlDbType.Int32,11),
					new MySqlParameter("@pld3", MySqlDbType.Int32,11),
					new MySqlParameter("@pld4", MySqlDbType.Int32,11),
					new MySqlParameter("@pld5", MySqlDbType.Int32,11)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.pcode;
			parameters[2].Value = model.pname;
			parameters[3].Value = model.pdesc;
			parameters[4].Value = model.pleftcnt;
			parameters[5].Value = model.plupdatetime;
			parameters[6].Value = model.psumcnt;
			parameters[7].Value = model.psalecnt;
			parameters[8].Value = model.pls1;
			parameters[9].Value = model.pls2;
			parameters[10].Value = model.pls3;
			parameters[11].Value = model.pls4;
			parameters[12].Value = model.pls5;
			parameters[13].Value = model.pld1;
			parameters[14].Value = model.pld2;
			parameters[15].Value = model.pld3;
			parameters[16].Value = model.pld4;
			parameters[17].Value = model.pld5;

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
		public bool Update(Jium.Model.plib model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update plib set ");
			strSql.Append("pname=@pname,");
			strSql.Append("pdesc=@pdesc,");
			strSql.Append("pleftcnt=@pleftcnt,");
			strSql.Append("plupdatetime=@plupdatetime,");
			strSql.Append("psumcnt=@psumcnt,");
			strSql.Append("psalecnt=@psalecnt,");
			strSql.Append("pls1=@pls1,");
			strSql.Append("pls2=@pls2,");
			strSql.Append("pls3=@pls3,");
			strSql.Append("pls4=@pls4,");
			strSql.Append("pls5=@pls5,");
			strSql.Append("pld1=@pld1,");
			strSql.Append("pld2=@pld2,");
			strSql.Append("pld3=@pld3,");
			strSql.Append("pld4=@pld4,");
			strSql.Append("pld5=@pld5");
			strSql.Append(" where id=@id and pcode=@pcode ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@pname", MySqlDbType.VarChar,50),
					new MySqlParameter("@pdesc", MySqlDbType.VarChar,200),
					new MySqlParameter("@pleftcnt", MySqlDbType.Int32,11),
					new MySqlParameter("@plupdatetime", MySqlDbType.VarChar,20),
					new MySqlParameter("@psumcnt", MySqlDbType.Int32,11),
					new MySqlParameter("@psalecnt", MySqlDbType.Int32,11),
					new MySqlParameter("@pls1", MySqlDbType.VarChar,20),
					new MySqlParameter("@pls2", MySqlDbType.VarChar,20),
					new MySqlParameter("@pls3", MySqlDbType.VarChar,20),
					new MySqlParameter("@pls4", MySqlDbType.VarChar,20),
					new MySqlParameter("@pls5", MySqlDbType.VarChar,20),
					new MySqlParameter("@pld1", MySqlDbType.Int32,11),
					new MySqlParameter("@pld2", MySqlDbType.Int32,11),
					new MySqlParameter("@pld3", MySqlDbType.Int32,11),
					new MySqlParameter("@pld4", MySqlDbType.Int32,11),
					new MySqlParameter("@pld5", MySqlDbType.Int32,11),
					new MySqlParameter("@id", MySqlDbType.bigint,20),
					new MySqlParameter("@pcode", MySqlDbType.VarChar,20)};
			parameters[0].Value = model.pname;
			parameters[1].Value = model.pdesc;
			parameters[2].Value = model.pleftcnt;
			parameters[3].Value = model.plupdatetime;
			parameters[4].Value = model.psumcnt;
			parameters[5].Value = model.psalecnt;
			parameters[6].Value = model.pls1;
			parameters[7].Value = model.pls2;
			parameters[8].Value = model.pls3;
			parameters[9].Value = model.pls4;
			parameters[10].Value = model.pls5;
			parameters[11].Value = model.pld1;
			parameters[12].Value = model.pld2;
			parameters[13].Value = model.pld3;
			parameters[14].Value = model.pld4;
			parameters[15].Value = model.pld5;
			parameters[16].Value = model.id;
			parameters[17].Value = model.pcode;

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
		public bool Delete(long id,string pcode)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from plib ");
			strSql.Append(" where id=@id and pcode=@pcode ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.bigint,20),
					new MySqlParameter("@pcode", MySqlDbType.VarChar,20)			};
			parameters[0].Value = id;
			parameters[1].Value = pcode;

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
		/// 得到一个对象实体
		/// </summary>
		public Jium.Model.plib GetModel(long id,string pcode)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,pcode,pname,pdesc,pleftcnt,plupdatetime,psumcnt,psalecnt,pls1,pls2,pls3,pls4,pls5,pld1,pld2,pld3,pld4,pld5 from plib ");
			strSql.Append(" where id=@id and pcode=@pcode ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.bigint,20),
					new MySqlParameter("@pcode", MySqlDbType.VarChar,20)			};
			parameters[0].Value = id;
			parameters[1].Value = pcode;

			Jium.Model.plib model=new Jium.Model.plib();
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
		public Jium.Model.plib DataRowToModel(DataRow row)
		{
			Jium.Model.plib model=new Jium.Model.plib();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=long.Parse(row["id"].ToString());
				}
				if(row["pcode"]!=null)
				{
					model.pcode=row["pcode"].ToString();
				}
				if(row["pname"]!=null)
				{
					model.pname=row["pname"].ToString();
				}
				if(row["pdesc"]!=null)
				{
					model.pdesc=row["pdesc"].ToString();
				}
				if(row["pleftcnt"]!=null && row["pleftcnt"].ToString()!="")
				{
					model.pleftcnt=int.Parse(row["pleftcnt"].ToString());
				}
				if(row["plupdatetime"]!=null)
				{
					model.plupdatetime=row["plupdatetime"].ToString();
				}
				if(row["psumcnt"]!=null && row["psumcnt"].ToString()!="")
				{
					model.psumcnt=int.Parse(row["psumcnt"].ToString());
				}
				if(row["psalecnt"]!=null && row["psalecnt"].ToString()!="")
				{
					model.psalecnt=int.Parse(row["psalecnt"].ToString());
				}
				if(row["pls1"]!=null)
				{
					model.pls1=row["pls1"].ToString();
				}
				if(row["pls2"]!=null)
				{
					model.pls2=row["pls2"].ToString();
				}
				if(row["pls3"]!=null)
				{
					model.pls3=row["pls3"].ToString();
				}
				if(row["pls4"]!=null)
				{
					model.pls4=row["pls4"].ToString();
				}
				if(row["pls5"]!=null)
				{
					model.pls5=row["pls5"].ToString();
				}
				if(row["pld1"]!=null && row["pld1"].ToString()!="")
				{
					model.pld1=int.Parse(row["pld1"].ToString());
				}
				if(row["pld2"]!=null && row["pld2"].ToString()!="")
				{
					model.pld2=int.Parse(row["pld2"].ToString());
				}
				if(row["pld3"]!=null && row["pld3"].ToString()!="")
				{
					model.pld3=int.Parse(row["pld3"].ToString());
				}
				if(row["pld4"]!=null && row["pld4"].ToString()!="")
				{
					model.pld4=int.Parse(row["pld4"].ToString());
				}
				if(row["pld5"]!=null && row["pld5"].ToString()!="")
				{
					model.pld5=int.Parse(row["pld5"].ToString());
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
			strSql.Append("select id,pcode,pname,pdesc,pleftcnt,plupdatetime,psumcnt,psalecnt,pls1,pls2,pls3,pls4,pls5,pld1,pld2,pld3,pld4,pld5 ");
			strSql.Append(" FROM plib ");
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
			strSql.Append("select count(1) FROM plib ");
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
				strSql.Append("order by T.pcode desc");
			}
			strSql.Append(")AS Row, T.*  from plib T ");
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
			parameters[0].Value = "plib";
			parameters[1].Value = "pcode";
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

