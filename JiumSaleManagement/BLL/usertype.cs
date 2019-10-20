using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Jium.Model;
using Jium.DALFactory;
using Jium.IDAL;
namespace Jium.BLL
{
	/// <summary>
	/// usertype
	/// </summary>
	public partial class usertype
	{
		private readonly Iusertype dal=DataAccess.Createusertype();
		public usertype()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int level)
		{
			return dal.Exists(level);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Jium.Model.usertype model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Jium.Model.usertype model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int level)
		{
			
			return dal.Delete(level);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string levellist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(levellist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Jium.Model.usertype GetModel(int level)
		{
			
			return dal.GetModel(level);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Jium.Model.usertype GetModelByCache(int level)
		{
			
			string CacheKey = "usertypeModel-" + level;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(level);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Jium.Model.usertype)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Jium.Model.usertype> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Jium.Model.usertype> DataTableToList(DataTable dt)
		{
			List<Jium.Model.usertype> modelList = new List<Jium.Model.usertype>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Jium.Model.usertype model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

