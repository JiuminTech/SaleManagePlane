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
namespace Jium.Web.userevent
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
		Jium.BLL.userevent bll=new Jium.BLL.userevent();
		Jium.Model.userevent model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lbluserid.Text=model.userid.ToString();
		this.lbleventid.Text=model.eventid.ToString();
		this.lbleventtime.Text=model.eventtime;
		this.lblremark.Text=model.remark;

	}


    }
}
