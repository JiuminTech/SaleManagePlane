using System;
namespace Jium.Model
{
	/// <summary>
	/// userinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class userinfo
	{
		public userinfo()
		{}
		#region Model
		private int _id;
		private string _tagname;
		private string _email;
		private int _level;
		private string _pwd;
		private string _remark;
		private string _createtime;
		private string _token;
		private string _tokentime;
		private int _status=0;
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
		public string tagname
		{
			set{ _tagname=value;}
			get{return _tagname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int level
		{
			set{ _level=value;}
			get{return _level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pwd
		{
			set{ _pwd=value;}
			get{return _pwd;}
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
		public string createtime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string token
		{
			set{ _token=value;}
			get{return _token;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tokentime
		{
			set{ _tokentime=value;}
			get{return _tokentime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int status
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}

