using System;
namespace Jium.Model
{
	/// <summary>
	/// historyalarm:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class historyalarm
	{
		public historyalarm()
		{}
		#region Model
		private long _id;
		private string _alarmname;
		private string _alarmdesc;
		private string _createtime;
		private string _updatetime;
		private int _ownerid;
		private int _handlerid=0;
		private int _alarmtype;
		private long _operateid;
		private int _handlestatus=0;
		private string _confirmtime;
		private string _handledetail;
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
		public string alarmname
		{
			set{ _alarmname=value;}
			get{return _alarmname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string alarmdesc
		{
			set{ _alarmdesc=value;}
			get{return _alarmdesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string createtime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string updatetime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ownerid
		{
			set{ _ownerid=value;}
			get{return _ownerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int handlerid
		{
			set{ _handlerid=value;}
			get{return _handlerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int alarmtype
		{
			set{ _alarmtype=value;}
			get{return _alarmtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long operateid
		{
			set{ _operateid=value;}
			get{return _operateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int handlestatus
		{
			set{ _handlestatus=value;}
			get{return _handlestatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string confirmtime
		{
			set{ _confirmtime=value;}
			get{return _confirmtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string handledetail
		{
			set{ _handledetail=value;}
			get{return _handledetail;}
		}
		#endregion Model

	}
}

