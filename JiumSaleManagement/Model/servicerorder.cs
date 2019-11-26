using System;
namespace Jium.Model
{
	/// <summary>
	/// servicerorder:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class servicerorder
	{
		public servicerorder()
		{}
		#region Model
		private long _id;
		private string _ccode;
		private string _spid;
		private int _spnum=1;
		private int _spspan=1;
		private int _sostatus=0;
		private string _createtime;
		private string _updatetime;
		private string _updateby;
		private string _sos1;
		private string _sos2;
		private string _sos3;
		private string _sos4;
		private string _sos5;
		private int? _sod1;
		private int? _sod2;
		private int? _sod3;
		private int? _sod4;
		private int? _sod5;
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
		public string ccode
		{
			set{ _ccode=value;}
			get{return _ccode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string spid
		{
			set{ _spid=value;}
			get{return _spid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int spnum
		{
			set{ _spnum=value;}
			get{return _spnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int spspan
		{
			set{ _spspan=value;}
			get{return _spspan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sostatus
		{
			set{ _sostatus=value;}
			get{return _sostatus;}
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
		public string updateby
		{
			set{ _updateby=value;}
			get{return _updateby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sos1
		{
			set{ _sos1=value;}
			get{return _sos1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sos2
		{
			set{ _sos2=value;}
			get{return _sos2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sos3
		{
			set{ _sos3=value;}
			get{return _sos3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sos4
		{
			set{ _sos4=value;}
			get{return _sos4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sos5
		{
			set{ _sos5=value;}
			get{return _sos5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sod1
		{
			set{ _sod1=value;}
			get{return _sod1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sod2
		{
			set{ _sod2=value;}
			get{return _sod2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sod3
		{
			set{ _sod3=value;}
			get{return _sod3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sod4
		{
			set{ _sod4=value;}
			get{return _sod4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sod5
		{
			set{ _sod5=value;}
			get{return _sod5;}
		}
		#endregion Model

	}
}

