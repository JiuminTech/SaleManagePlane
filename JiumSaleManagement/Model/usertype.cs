using System;
namespace Jium.Model
{
	/// <summary>
	/// usertype:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class usertype
	{
		public usertype()
		{}
		#region Model
		private string _tagname;
		private int _level;
		private int _authvalue=0;
		/// <summary>
		/// 
		/// </summary>
		public string tagname
		{
			set{ _tagname=value;}
			get{return _tagname;}
		}
		/// <summary>
		/// auto_increment
		/// </summary>
		public int level
		{
			set{ _level=value;}
			get{return _level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int authvalue
		{
			set{ _authvalue=value;}
			get{return _authvalue;}
		}
		#endregion Model

	}
}

