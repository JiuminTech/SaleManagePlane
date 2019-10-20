using System;
namespace Jium.Model
{
	/// <summary>
	/// eventtype:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class eventtype
	{
		public eventtype()
		{}
		#region Model
		private long _id;
		private string _eventname;
		private string _remark;
		private bool _isnotify= false;
		private string _udatetime;
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
		public string eventname
		{
			set{ _eventname=value;}
			get{return _eventname;}
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
		public bool isnotify
		{
			set{ _isnotify=value;}
			get{return _isnotify;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string udatetime
		{
			set{ _udatetime=value;}
			get{return _udatetime;}
		}
		#endregion Model

	}
}

