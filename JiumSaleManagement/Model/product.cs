using System;
namespace Jium.Model
{
	/// <summary>
	/// product:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class product
	{
		public product()
		{}
		#region Model
		private int _id;
		private string _pcode;
		private string _pname;
		private decimal _psaleprice;
		private decimal _prealprice;
		private string _ptype;
		private int _pisgroup=0;
		private string _pdesc;
		private string _ps1;
		private string _ps2;
		private string _ps3;
		private string _ps4;
		private string _ps5;
		private int? _pd1;
		private int? _pd2;
		private int? _pd3;
		private int? _pd4;
		private int? _pd5;
		private decimal? _pdc1;
		private decimal? _pdc2;
		private decimal? _pdc3;
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
		public string pcode
		{
			set{ _pcode=value;}
			get{return _pcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pname
		{
			set{ _pname=value;}
			get{return _pname;}
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
		public string ptype
		{
			set{ _ptype=value;}
			get{return _ptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pisgroup
		{
			set{ _pisgroup=value;}
			get{return _pisgroup;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pdesc
		{
			set{ _pdesc=value;}
			get{return _pdesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ps1
		{
			set{ _ps1=value;}
			get{return _ps1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ps2
		{
			set{ _ps2=value;}
			get{return _ps2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ps3
		{
			set{ _ps3=value;}
			get{return _ps3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ps4
		{
			set{ _ps4=value;}
			get{return _ps4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ps5
		{
			set{ _ps5=value;}
			get{return _ps5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? pd1
		{
			set{ _pd1=value;}
			get{return _pd1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? pd2
		{
			set{ _pd2=value;}
			get{return _pd2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? pd3
		{
			set{ _pd3=value;}
			get{return _pd3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? pd4
		{
			set{ _pd4=value;}
			get{return _pd4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? pd5
		{
			set{ _pd5=value;}
			get{return _pd5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? pdc1
		{
			set{ _pdc1=value;}
			get{return _pdc1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? pdc2
		{
			set{ _pdc2=value;}
			get{return _pdc2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? pdc3
		{
			set{ _pdc3=value;}
			get{return _pdc3;}
		}
		#endregion Model

	}
}

