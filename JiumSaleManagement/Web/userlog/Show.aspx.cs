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
namespace Jium.Web.userlog
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
					long id=(Convert.ToInt64(strid));
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(long id)
	{
		Jium.BLL.userlog bll=new Jium.BLL.userlog();
		Jium.Model.userlog model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblusercode.Text=model.usercode;
		this.lbluseraddr.Text=model.useraddr;
		this.lblopertype.Text=model.opertype;
		this.lbloperobject.Text=model.operobject;
		this.lblopervalue.Text=model.opervalue;
		this.lbloperdesc.Text=model.operdesc;
		this.lblopertime.Text=model.opertime;

	}


    }
}
