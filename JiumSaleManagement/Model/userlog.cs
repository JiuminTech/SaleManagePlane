using System;
namespace Jium.Model
{
	/// <summary>
	/// userlog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class userlog
	{
		public userlog()
		{}
		#region Model
		private long _id;
		private string _usercode;
		private string _useraddr;
		private string _opertype;
		private string _operobject;
		private string _opervalue;
		private string _operdesc;
		private string _opertime;
		/// <summary>
		/// auto_increment
		/// </summary>
		public long id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string usercode
		{
			set{ _usercode=value;}
			get{return _usercode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string useraddr
		{
			set{ _useraddr=value;}
			get{return _useraddr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string opertype
		{
			set{ _opertype=value;}
			get{return _opertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string operobject
		{
			set{ _operobject=value;}
			get{return _operobject;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string opervalue
		{
			set{ _opervalue=value;}
			get{return _opervalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string operdesc
		{
			set{ _operdesc=value;}
			get{return _operdesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string opertime
		{
			set{ _opertime=value;}
			get{return _opertime;}
		}
		#endregion Model

	}
}

