using System;
namespace Jium.Model
{
	/// <summary>
	/// piorecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class piorecord
	{
		public piorecord()
		{}
		#region Model
		private long _id;
		private string _ptime;
		private string _pcode;
		private int _pcnt;
		private decimal _psaleprice;
		private decimal _prealprice;
		private int _ptype;
		private decimal _pzekou;
		private string _premark;
		private int _pguestid;
		private int _psalerid;
		private string _pios1;
		private string _pios2;
		private string _pios3;
		private string _pios4;
		private string _pios5;
		private int? _piod1;
		private int? _piod2;
		private int? _piod3;
		private int? _piod5;
		private int? _piod4;
		private decimal? _piodc1;
		private decimal? _piodc2;
		private decimal? _piodc3;
		private decimal? _piodc4;
		private decimal? _piodc5;
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
		public string ptime
		{
			set{ _ptime=value;}
			get{return _ptime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pcode
		{
			set{ _pcode=value;}
			get{return _pcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pcnt
		{
			set{ _pcnt=value;}
			get{return _pcnt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal psaleprice
		{
			set{ _psaleprice=value;}
			get{return _psaleprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal prealprice
		{
			set{ _prealprice=value;}
			get{return _prealprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ptype
		{
			set{ _ptype=value;}
			get{return _ptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal pzekou
		{
			set{ _pzekou=value;}
			get{return _pzekou;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string premark
		{
			set{ _premark=value;}
			get{return _premark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pguestid
		{
			set{ _pguestid=value;}
			get{return _pguestid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int psalerid
		{
			set{ _psalerid=value;}
			get{return _psalerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pios1
		{
			set{ _pios1=value;}
			get{return _pios1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pios2
		{
			set{ _pios2=value;}
			get{return _pios2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pios3
		{
			set{ _pios3=value;}
			get{return _pios3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pios4
		{
			set{ _pios4=value;}
			get{return _pios4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pios5
		{
			set{ _pios5=value;}
			get{return _pios5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? piod1
		{
			set{ _piod1=value;}
			get{return _piod1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? piod2
		{
			set{ _piod2=value;}
			get{return _piod2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? piod3
		{
			set{ _piod3=value;}
			get{return _piod3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? piod5
		{
			set{ _piod5=value;}
			get{return _piod5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? piod4
		{
			set{ _piod4=value;}
			get{return _piod4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? piodc1
		{
			set{ _piodc1=value;}
			get{return _piodc1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? piodc2
		{
			set{ _piodc2=value;}
			get{return _piodc2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? piodc3
		{
			set{ _piodc3=value;}
			get{return _piodc3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? piodc4
		{
			set{ _piodc4=value;}
			get{return _piodc4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? piodc5
		{
			set{ _piodc5=value;}
			get{return _piodc5;}
		}
		#endregion Model

	}
}

