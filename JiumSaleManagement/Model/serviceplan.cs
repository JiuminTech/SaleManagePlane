using System;
namespace Jium.Model
{
	/// <summary>
	/// serviceplan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class serviceplan
	{
		public serviceplan()
		{}
		#region Model
		private string _id;
		private string _plandate;
		private string _plantime;
		private int _totalnum;
		private int _leftnum;
		private int _nexttotal=0;
		private int _nextleft=0;
		private string _nextid;
		private string _pss1;
		private string _pss2;
		private string _pss3;
		private string _pss4;
		private string _pss5;
		private int? _psd1;
		private int? _psd2;
		private int? _psd3;
		private int? _psd4;
		private int? _psd5;
		/// <summary>
		/// 
		/// </summary>
		public string id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string plandate
		{
			set{ _plandate=value;}
			get{return _plandate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string plantime
		{
			set{ _plantime=value;}
			get{return _plantime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int totalnum
		{
			set{ _totalnum=value;}
			get{return _totalnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int leftnum
		{
			set{ _leftnum=value;}
			get{return _leftnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int nexttotal
		{
			set{ _nexttotal=value;}
			get{return _nexttotal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int nextleft
		{
			set{ _nextleft=value;}
			get{return _nextleft;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string nextid
		{
			set{ _nextid=value;}
			get{return _nextid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pss1
		{
			set{ _pss1=value;}
			get{return _pss1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pss2
		{
			set{ _pss2=value;}
			get{return _pss2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pss3
		{
			set{ _pss3=value;}
			get{return _pss3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pss4
		{
			set{ _pss4=value;}
			get{return _pss4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pss5
		{
			set{ _pss5=value;}
			get{return _pss5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? psd1
		{
			set{ _psd1=value;}
			get{return _psd1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? psd2
		{
			set{ _psd2=value;}
			get{return _psd2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? psd3
		{
			set{ _psd3=value;}
			get{return _psd3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? psd4
		{
			set{ _psd4=value;}
			get{return _psd4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? psd5
		{
			set{ _psd5=value;}
			get{return _psd5;}
		}
		#endregion Model

	}
}

