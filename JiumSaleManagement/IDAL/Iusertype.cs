using System;
using System.Data;
namespace Jium.IDAL
{
	/// <summary>
	/// 接口层usertype
	/// </summary>
	public interface Iusertype
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int level);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		bool Add(Jium.Model.usertype model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(Jium.Model.usertype model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int level);
		bool DeleteList(string levellist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Jium.Model.usertype GetModel(int level);
		Jium.Model.usertype DataRowToModel(DataRow row);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  成员方法
		#region  MethodEx

		#endregion  MethodEx
	} 
}
