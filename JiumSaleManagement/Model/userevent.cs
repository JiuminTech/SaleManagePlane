using System;
namespace Jium.Model
{
	/// <summary>
	/// userevent:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class userevent
	{
		public userevent()
		{}
		#region Model
		private long _id;
		private int _userid;
		private long _eventid;
		private string _eventtime;
		private string _remark;
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
		public int userid
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long eventid
		{
			set{ _eventid=value;}
			get{return _eventid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string eventtime
		{
			set{ _eventtime=value;}
			get{return _eventtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

