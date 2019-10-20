using System;
namespace Jium.Model
{
	/// <summary>
	/// alarmevent:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class alarmevent
	{
		public alarmevent()
		{}
		#region Model
		private long _id;
		private string _alarmname;
		private string _alarmdesc;
		private string _createtime;
		private string _updatetime;
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
		#endregion Model

	}
}

