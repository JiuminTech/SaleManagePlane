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
namespace Jium.Web.usertype
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
					int level=(Convert.ToInt32(strid));
					ShowInfo(level);
				}
			}
		}
		
	private void ShowInfo(int level)
	{
		Jium.BLL.usertype bll=new Jium.BLL.usertype();
		Jium.Model.usertype model=bll.GetModel(level);
		this.lbltagname.Text=model.tagname;
		this.lbllevel.Text=model.level.ToString();
		this.lblauthvalue.Text=model.authvalue.ToString();

	}


    }
}
