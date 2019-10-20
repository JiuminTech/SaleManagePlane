using System;
namespace Jium.Model
{
	/// <summary>
	/// systemparams:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class systemparams
	{
		public systemparams()
		{}
		#region Model
		private int _id;
		private string _paramname;
		private string _paramvalue;
		private string _remark;
		private int _status=0;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string paramname
		{
			set{ _paramname=value;}
			get{return _paramname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string paramvalue
		{
			set{ _paramvalue=value;}
			get{return _paramvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int status
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}

