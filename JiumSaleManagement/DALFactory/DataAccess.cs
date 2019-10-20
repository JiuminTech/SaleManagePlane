using System;
using System.Reflection;
using System.Configuration;
namespace Jium.DALFactory
{
	/// <summary>
    /// Abstract Factory pattern to create the DAL。
    /// 如果在这里创建对象报错，请检查web.config里是否修改了<add key="DAL" value="Maticsoft.SQLServerDAL" />。
	/// </summary>
	public sealed class DataAccess 
	{
        private static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];        
		public DataAccess()
		{ }

        #region CreateObject 

		//不使用缓存
        private static object CreateObjectNoCache(string AssemblyPath,string classNamespace)
		{		
			try
			{
				object objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);	
				return objType;
			}
			catch//(System.Exception ex)
			{
				//string str=ex.Message;// 记录错误日志
				return null;
			}			
			
        }
		//使用缓存
		private static object CreateObject(string AssemblyPath,string classNamespace)
		{			
			object objType = DataCache.GetCache(classNamespace);
			if (objType == null)
			{
				try
				{
					objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);					
					DataCache.SetCache(classNamespace, objType);// 写入缓存
				}
				catch//(System.Exception ex)
				{
					//string str=ex.Message;// 记录错误日志
				}
			}
			return objType;
		}
        #endregion

        #region 泛型生成
        ///// <summary>
        ///// 创建数据层接口。
        ///// </summary>
        //public static t Create(string ClassName)
        //{

        //    string ClassNamespace = AssemblyPath +"."+ ClassName;
        //    object objType = CreateObject(AssemblyPath, ClassNamespace);
        //    return (t)objType;
        //}
        #endregion

        #region CreateSysManage
        public static Jium.IDAL.ISysManage CreateSysManage()
		{
			//方式1			
			//return (Jium.IDAL.ISysManage)Assembly.Load(AssemblyPath).CreateInstance(AssemblyPath+".SysManage");

			//方式2 			
			string classNamespace = AssemblyPath+".SysManage";	
			object objType=CreateObject(AssemblyPath,classNamespace);
            return (Jium.IDAL.ISysManage)objType;		
		}
		#endregion
             
        
   
		/// <summary>
		/// 创建alarmevent数据层接口。
		/// </summary>
		public static Jium.IDAL.Ialarmevent Createalarmevent()
		{

			string ClassNamespace = AssemblyPath +".alarmevent";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Jium.IDAL.Ialarmevent)objType;
		}

		/// <summary>
		/// 创建clerk数据层接口。
		/// </summary>
		public static Jium.IDAL.Iclerk Createclerk()
		{

			string ClassNamespace = AssemblyPath +".clerk";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Jium.IDAL.Iclerk)objType;
		}

		/// <summary>
		/// 创建consumer数据层接口。
		/// </summary>
		public static Jium.IDAL.Iconsumer Createconsumer()
		{

			string ClassNamespace = AssemblyPath +".consumer";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Jium.IDAL.Iconsumer)objType;
		}

		/// <summary>
		/// 创建currentalarm数据层接口。
		/// </summary>
		public static Jium.IDAL.Icurrentalarm Createcurrentalarm()
		{

			string ClassNamespace = AssemblyPath +".currentalarm";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Jium.IDAL.Icurrentalarm)objType;
		}

		/// <summary>
		/// 创建eventtype数据层接口。
		/// </summary>
		public static Jium.IDAL.Ieventtype Createeventtype()
		{

			string ClassNamespace = AssemblyPath +".eventtype";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Jium.IDAL.Ieventtype)objType;
		}

		/// <summary>
		/// 创建historyalarm数据层接口。
		/// </summary>
		public static Jium.IDAL.Ihistoryalarm Createhistoryalarm()
		{

			string ClassNamespace = AssemblyPath +".historyalarm";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Jium.IDAL.Ihistoryalarm)objType;
		}

		/// <summary>
		/// 创建pgroup数据层接口。
		/// </summary>
		public static Jium.IDAL.Ipgroup Createpgroup()
		{

			string ClassNamespace = AssemblyPath +".pgroup";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Jium.IDAL.Ipgroup)objType;
		}

		/// <summary>
		/// 创建piorecord数据层接口。
		/// </summary>
		public static Jium.IDAL.Ipiorecord Createpiorecord()
		{

			string ClassNamespace = AssemblyPath +".piorecord";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Jium.IDAL.Ipiorecord)objType;
		}

		/// <summary>
		/// 创建plib数据层接口。
		/// </summary>
		public static Jium.IDAL.Iplib Createplib()
		{

			string ClassNamespace = AssemblyPath +".plib";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Jium.IDAL.Iplib)objType;
		}

		/// <summary>
		/// 创建product数据层接口。
		/// </summary>
		public static Jium.IDAL.Iproduct Createproduct()
		{

			string ClassNamespace = AssemblyPath +".product";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Jium.IDAL.Iproduct)objType;
		}

		/// <summary>
		/// 创建systemparams数据层接口。
		/// </summary>
		public static Jium.IDAL.Isystemparams Createsystemparams()
		{

			string ClassNamespace = AssemblyPath +".systemparams";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Jium.IDAL.Isystemparams)objType;
		}

		/// <summary>
		/// 创建userevent数据层接口。
		/// </summary>
		public static Jium.IDAL.Iuserevent Createuserevent()
		{

			string ClassNamespace = AssemblyPath +".userevent";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Jium.IDAL.Iuserevent)objType;
		}

		/// <summary>
		/// 创建userinfo数据层接口。
		/// </summary>
		public static Jium.IDAL.Iuserinfo Createuserinfo()
		{

			string ClassNamespace = AssemblyPath +".userinfo";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Jium.IDAL.Iuserinfo)objType;
		}

		/// <summary>
		/// 创建usertype数据层接口。
		/// </summary>
		public static Jium.IDAL.Iusertype Createusertype()
		{

			string ClassNamespace = AssemblyPath +".usertype";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Jium.IDAL.Iusertype)objType;
		}

}
}