using System;
namespace Jium.Model
{
	/// <summary>
	/// plib:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class plib
	{
		public plib()
		{}
		#region Model
		private long _id;
		private string _pcode;
		private string _pname;
		private string _pdesc;
		private int _pleftcnt;
		private string _plupdatetime;
		private int _psumcnt;
		private int _psalecnt;
		private string _pls1;
		private string _pls2;
		private string _pls3;
		private string _pls4;
		private string _pls5;
		private int? _pld1;
		private int? _pld2;
		private int? _pld3;
		private int? _pld4;
		private int? _pld5;
		/// <summary>
		/// 
		/// </summary>
		public long id
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
		public string pdesc
		{
			set{ _pdesc=value;}
			get{return _pdesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pleftcnt
		{
			set{ _pleftcnt=value;}
			get{return _pleftcnt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string plupdatetime
		{
			set{ _plupdatetime=value;}
			get{return _plupdatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int psumcnt
		{
			set{ _psumcnt=value;}
			get{return _psumcnt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int psalecnt
		{
			set{ _psalecnt=value;}
			get{return _psalecnt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pls1
		{
			set{ _pls1=value;}
			get{return _pls1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pls2
		{
			set{ _pls2=value;}
			get{return _pls2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pls3
		{
			set{ _pls3=value;}
			get{return _pls3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pls4
		{
			set{ _pls4=value;}
			get{return _pls4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pls5
		{
			set{ _pls5=value;}
			get{return _pls5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? pld1
		{
			set{ _pld1=value;}
			get{return _pld1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? pld2
		{
			set{ _pld2=value;}
			get{return _pld2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? pld3
		{
			set{ _pld3=value;}
			get{return _pld3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? pld4
		{
			set{ _pld4=value;}
			get{return _pld4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? pld5
		{
			set{ _pld5=value;}
			get{return _pld5;}
		}
		#endregion Model

	}
}

