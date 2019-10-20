using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Jium.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Jium.MySQLDAL
{
	/// <summary>
	/// 数据访问类:piorecord
	/// </summary>
	public partial class piorecord:Ipiorecord
	{
		public piorecord()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from piorecord");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.bigint)
			};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Jium.Model.piorecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into piorecord(");
			strSql.Append("ptime,pcode,pcnt,psaleprice,prealprice,ptype,pzekou,premark,pguestid,psalerid,pios1,pios2,pios3,pios4,pios5,piod1,piod2,piod3,piod5,piod4,piodc1,piodc2,piodc3,piodc4,piodc5)");
			strSql.Append(" values (");
			strSql.Append("@ptime,@pcode,@pcnt,@psaleprice,@prealprice,@ptype,@pzekou,@premark,@pguestid,@psalerid,@pios1,@pios2,@pios3,@pios4,@pios5,@piod1,@piod2,@piod3,@piod5,@piod4,@piodc1,@piodc2,@piodc3,@piodc4,@piodc5)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ptime", MySqlDbType.VarChar,20),
					new MySqlParameter("@pcode", MySqlDbType.VarChar,20),
					new MySqlParameter("@pcnt", MySqlDbType.Int32,11),
					new MySqlParameter("@psaleprice", MySqlDbType.Decimal,20),
					new MySqlParameter("@prealprice", MySqlDbType.Decimal,20),
					new MySqlParameter("@ptype", MySqlDbType.Int32,11),
					new MySqlParameter("@pzekou", MySqlDbType.Decimal,20),
					new MySqlParameter("@premark", MySqlDbType.VarChar,200),
					new MySqlParameter("@pguestid", MySqlDbType.Int32,11),
					new MySqlParameter("@psalerid", MySqlDbType.Int32,11),
					new MySqlParameter("@pios1", MySqlDbType.VarChar,20),
					new MySqlParameter("@pios2", MySqlDbType.VarChar,20),
					new MySqlParameter("@pios3", MySqlDbType.VarChar,20),
					new MySqlParameter("@pios4", MySqlDbType.VarChar,20),
					new MySqlParameter("@pios5", MySqlDbType.VarChar,20),
					new MySqlParameter("@piod1", MySqlDbType.Int32,11),
					new MySqlParameter("@piod2", MySqlDbType.Int32,11),
					new MySqlParameter("@piod3", MySqlDbType.Int32,11),
					new MySqlParameter("@piod5", MySqlDbType.Int32,11),
					new MySqlParameter("@piod4", MySqlDbType.Int32,11),
					new MySqlParameter("@piodc1", MySqlDbType.Decimal,20),
					new MySqlParameter("@piodc2", MySqlDbType.Decimal,20),
					new MySqlParameter("@piodc3", MySqlDbType.Decimal,20),
					new MySqlParameter("@piodc4", MySqlDbType.Decimal,20),
					new MySqlParameter("@piodc5", MySqlDbType.Decimal,20)};
			parameters[0].Value = model.ptime;
			parameters[1].Value = model.pcode;
			parameters[2].Value = model.pcnt;
			parameters[3].Value = model.psaleprice;
			parameters[4].Value = model.prealprice;
			parameters[5].Value = model.ptype;
			parameters[6].Value = model.pzekou;
			parameters[7].Value = model.premark;
			parameters[8].Value = model.pguestid;
			parameters[9].Value = model.psalerid;
			parameters[10].Value = model.pios1;
			parameters[11].Value = model.pios2;
			parameters[12].Value = model.pios3;
			parameters[13].Value = model.pios4;
			parameters[14].Value = model.pios5;
			parameters[15].Value = model.piod1;
			parameters[16].Value = model.piod2;
			parameters[17].Value = model.piod3;
			parameters[18].Value = model.piod5;
			parameters[19].Value = model.piod4;
			parameters[20].Value = model.piodc1;
			parameters[21].Value = model.piodc2;
			parameters[22].Value = model.piodc3;
			parameters[23].Value = model.piodc4;
			parameters[24].Value = model.piodc5;

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
		public bool Update(Jium.Model.piorecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update piorecord set ");
			strSql.Append("ptime=@ptime,");
			strSql.Append("pcode=@pcode,");
			strSql.Append("pcnt=@pcnt,");
			strSql.Append("psaleprice=@psaleprice,");
			strSql.Append("prealprice=@prealprice,");
			strSql.Append("ptype=@ptype,");
			strSql.Append("pzekou=@pzekou,");
			strSql.Append("premark=@premark,");
			strSql.Append("pguestid=@pguestid,");
			strSql.Append("psalerid=@psalerid,");
			strSql.Append("pios1=@pios1,");
			strSql.Append("pios2=@pios2,");
			strSql.Append("pios3=@pios3,");
			strSql.Append("pios4=@pios4,");
			strSql.Append("pios5=@pios5,");
			strSql.Append("piod1=@piod1,");
			strSql.Append("piod2=@piod2,");
			strSql.Append("piod3=@piod3,");
			strSql.Append("piod5=@piod5,");
			strSql.Append("piod4=@piod4,");
			strSql.Append("piodc1=@piodc1,");
			strSql.Append("piodc2=@piodc2,");
			strSql.Append("piodc3=@piodc3,");
			strSql.Append("piodc4=@piodc4,");
			strSql.Append("piodc5=@piodc5");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ptime", MySqlDbType.VarChar,20),
					new MySqlParameter("@pcode", MySqlDbType.VarChar,20),
					new MySqlParameter("@pcnt", MySqlDbType.Int32,11),
					new MySqlParameter("@psaleprice", MySqlDbType.Decimal,20),
					new MySqlParameter("@prealprice", MySqlDbType.Decimal,20),
					new MySqlParameter("@ptype", MySqlDbType.Int32,11),
					new MySqlParameter("@pzekou", MySqlDbType.Decimal,20),
					new MySqlParameter("@premark", MySqlDbType.VarChar,200),
					new MySqlParameter("@pguestid", MySqlDbType.Int32,11),
					new MySqlParameter("@psalerid", MySqlDbType.Int32,11),
					new MySqlParameter("@pios1", MySqlDbType.VarChar,20),
					new MySqlParameter("@pios2", MySqlDbType.VarChar,20),
					new MySqlParameter("@pios3", MySqlDbType.VarChar,20),
					new MySqlParameter("@pios4", MySqlDbType.VarChar,20),
					new MySqlParameter("@pios5", MySqlDbType.VarChar,20),
					new MySqlParameter("@piod1", MySqlDbType.Int32,11),
					new MySqlParameter("@piod2", MySqlDbType.Int32,11),
					new MySqlParameter("@piod3", MySqlDbType.Int32,11),
					new MySqlParameter("@piod5", MySqlDbType.Int32,11),
					new MySqlParameter("@piod4", MySqlDbType.Int32,11),
					new MySqlParameter("@piodc1", MySqlDbType.Decimal,20),
					new MySqlParameter("@piodc2", MySqlDbType.Decimal,20),
					new MySqlParameter("@piodc3", MySqlDbType.Decimal,20),
					new MySqlParameter("@piodc4", MySqlDbType.Decimal,20),
					new MySqlParameter("@piodc5", MySqlDbType.Decimal,20),
					new MySqlParameter("@id", MySqlDbType.bigint,20)};
			parameters[0].Value = model.ptime;
			parameters[1].Value = model.pcode;
			parameters[2].Value = model.pcnt;
			parameters[3].Value = model.psaleprice;
			parameters[4].Value = model.prealprice;
			parameters[5].Value = model.ptype;
			parameters[6].Value = model.pzekou;
			parameters[7].Value = model.premark;
			parameters[8].Value = model.pguestid;
			parameters[9].Value = model.psalerid;
			parameters[10].Value = model.pios1;
			parameters[11].Value = model.pios2;
			parameters[12].Value = model.pios3;
			parameters[13].Value = model.pios4;
			parameters[14].Value = model.pios5;
			parameters[15].Value = model.piod1;
			parameters[16].Value = model.piod2;
			parameters[17].Value = model.piod3;
			parameters[18].Value = model.piod5;
			parameters[19].Value = model.piod4;
			parameters[20].Value = model.piodc1;
			parameters[21].Value = model.piodc2;
			parameters[22].Value = model.piodc3;
			parameters[23].Value = model.piodc4;
			parameters[24].Value = model.piodc5;
			parameters[25].Value = model.id;

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
			strSql.Append("delete from piorecord ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.bigint)
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
			strSql.Append("delete from piorecord ");
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
		public Jium.Model.piorecord GetModel(long id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,ptime,pcode,pcnt,psaleprice,prealprice,ptype,pzekou,premark,pguestid,psalerid,pios1,pios2,pios3,pios4,pios5,piod1,piod2,piod3,piod5,piod4,piodc1,piodc2,piodc3,piodc4,piodc5 from piorecord ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.bigint)
			};
			parameters[0].Value = id;

			Jium.Model.piorecord model=new Jium.Model.piorecord();
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
		public Jium.Model.piorecord DataRowToModel(DataRow row)
		{
			Jium.Model.piorecord model=new Jium.Model.piorecord();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=long.Parse(row["id"].ToString());
				}
				if(row["ptime"]!=null)
				{
					model.ptime=row["ptime"].ToString();
				}
				if(row["pcode"]!=null)
				{
					model.pcode=row["pcode"].ToString();
				}
				if(row["pcnt"]!=null && row["pcnt"].ToString()!="")
				{
					model.pcnt=int.Parse(row["pcnt"].ToString());
				}
				if(row["psaleprice"]!=null && row["psaleprice"].ToString()!="")
				{
					model.psaleprice=decimal.Parse(row["psaleprice"].ToString());
				}
				if(row["prealprice"]!=null && row["prealprice"].ToString()!="")
				{
					model.prealprice=decimal.Parse(row["prealprice"].ToString());
				}
				if(row["ptype"]!=null && row["ptype"].ToString()!="")
				{
					model.ptype=int.Parse(row["ptype"].ToString());
				}
				if(row["pzekou"]!=null && row["pzekou"].ToString()!="")
				{
					model.pzekou=decimal.Parse(row["pzekou"].ToString());
				}
				if(row["premark"]!=null)
				{
					model.premark=row["premark"].ToString();
				}
				if(row["pguestid"]!=null && row["pguestid"].ToString()!="")
				{
					model.pguestid=int.Parse(row["pguestid"].ToString());
				}
				if(row["psalerid"]!=null && row["psalerid"].ToString()!="")
				{
					model.psalerid=int.Parse(row["psalerid"].ToString());
				}
				if(row["pios1"]!=null)
				{
					model.pios1=row["pios1"].ToString();
				}
				if(row["pios2"]!=null)
				{
					model.pios2=row["pios2"].ToString();
				}
				if(row["pios3"]!=null)
				{
					model.pios3=row["pios3"].ToString();
				}
				if(row["pios4"]!=null)
				{
					model.pios4=row["pios4"].ToString();
				}
				if(row["pios5"]!=null)
				{
					model.pios5=row["pios5"].ToString();
				}
				if(row["piod1"]!=null && row["piod1"].ToString()!="")
				{
					model.piod1=int.Parse(row["piod1"].ToString());
				}
				if(row["piod2"]!=null && row["piod2"].ToString()!="")
				{
					model.piod2=int.Parse(row["piod2"].ToString());
				}
				if(row["piod3"]!=null && row["piod3"].ToString()!="")
				{
					model.piod3=int.Parse(row["piod3"].ToString());
				}
				if(row["piod5"]!=null && row["piod5"].ToString()!="")
				{
					model.piod5=int.Parse(row["piod5"].ToString());
				}
				if(row["piod4"]!=null && row["piod4"].ToString()!="")
				{
					model.piod4=int.Parse(row["piod4"].ToString());
				}
				if(row["piodc1"]!=null && row["piodc1"].ToString()!="")
				{
					model.piodc1=decimal.Parse(row["piodc1"].ToString());
				}
				if(row["piodc2"]!=null && row["piodc2"].ToString()!="")
				{
					model.piodc2=decimal.Parse(row["piodc2"].ToString());
				}
				if(row["piodc3"]!=null && row["piodc3"].ToString()!="")
				{
					model.piodc3=decimal.Parse(row["piodc3"].ToString());
				}
				if(row["piodc4"]!=null && row["piodc4"].ToString()!="")
				{
					model.piodc4=decimal.Parse(row["piodc4"].ToString());
				}
				if(row["piodc5"]!=null && row["piodc5"].ToString()!="")
				{
					model.piodc5=decimal.Parse(row["piodc5"].ToString());
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
			strSql.Append("select id,ptime,pcode,pcnt,psaleprice,prealprice,ptype,pzekou,premark,pguestid,psalerid,pios1,pios2,pios3,pios4,pios5,piod1,piod2,piod3,piod5,piod4,piodc1,piodc2,piodc3,piodc4,piodc5 ");
			strSql.Append(" FROM piorecord ");
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
			strSql.Append("select count(1) FROM piorecord ");
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
			strSql.Append(")AS Row, T.*  from piorecord T ");
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
			parameters[0].Value = "piorecord";
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

