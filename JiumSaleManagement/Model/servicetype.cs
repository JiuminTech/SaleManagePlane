using System;
namespace Jium.Model
{
	/// <summary>
	/// servicetype:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class servicetype
	{
		public servicetype()
		{}
		#region Model
		private int _id;
		private string _sname;
		private int _sminutes;
		private string _sdesc;
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
		public string sname
		{
			set{ _sname=value;}
			get{return _sname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sminutes
		{
			set{ _sminutes=value;}
			get{return _sminutes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sdesc
		{
			set{ _sdesc=value;}
			get{return _sdesc;}
		}
		#endregion Model

	}
}

