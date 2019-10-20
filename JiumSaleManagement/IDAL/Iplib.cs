﻿using System;
using System.Data;
namespace Jium.IDAL
{
	/// <summary>
	/// 接口层plib
	/// </summary>
	public interface Iplib
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(long id,string pcode);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		bool Add(Jium.Model.plib model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(Jium.Model.plib model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(long id,string pcode);
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Jium.Model.plib GetModel(long id,string pcode);
		Jium.Model.plib DataRowToModel(DataRow row);
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