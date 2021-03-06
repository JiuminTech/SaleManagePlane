﻿using System;
using System.Data;
namespace Jium.IDAL
{
	/// <summary>
	/// 接口层userlog
	/// </summary>
	public interface Iuserlog
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(long id);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		bool Add(Jium.Model.userlog model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(Jium.Model.userlog model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(long id);
		bool DeleteList(string idlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Jium.Model.userlog GetModel(long id);
		Jium.Model.userlog DataRowToModel(DataRow row);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
        /// <summary>
        /// 根据分页获得数据列表
        /// </summary>
        //DataSet GetList(int PageSize,int PageIndex,string strWhere);
        /// <summary>
        /// 分页获取数据数量
        /// </summary>
        int GetRecordCount(string strWhere);
        /// <summary>
        /// 分页获取数据列表
        /// </summary> 
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
        #endregion  成员方法
        #region  MethodEx

        #endregion  MethodEx
    } 
}
