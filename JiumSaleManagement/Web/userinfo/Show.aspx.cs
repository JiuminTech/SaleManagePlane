using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace Jium.Web.userinfo
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int id=(Convert.ToInt32(strid));
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(int id)
	{
		Jium.BLL.userinfo bll=new Jium.BLL.userinfo();
		Jium.Model.userinfo model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lbltagname.Text=model.tagname;
		this.lblemail.Text=model.email;
		this.lbllevel.Text=model.level.ToString();
		this.lblpwd.Text=model.pwd;
		this.lblremark.Text=model.remark;
		this.lblcreatetime.Text=model.createtime;
		this.lbltoken.Text=model.token;
		this.lbltokentime.Text=model.tokentime;
		this.lblstatus.Text=model.status.ToString();

	}


    }
}
