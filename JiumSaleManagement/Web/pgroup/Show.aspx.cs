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
namespace Jium.Web.pgroup
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
		Jium.BLL.pgroup bll=new Jium.BLL.pgroup();
		Jium.Model.pgroup model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblgid.Text=model.gid.ToString();
		this.lblgindex.Text=model.gindex.ToString();
		this.lblgpid.Text=model.gpid.ToString();
		this.lblgpcnt.Text=model.gpcnt.ToString();
		this.lblgdesc.Text=model.gdesc;
		//this.lblgs1.Text=model.gs1;
		//this.lblgs2.Text=model.gs2;
		//this.lblgs3.Text=model.gs3;
		//this.lblgs4.Text=model.gs4;
		//this.lblgs5.Text=model.gs5;
		//this.lblgd1.Text=model.gd1.ToString();
		//this.lblgd2.Text=model.gd2.ToString();
		//this.lblgd3.Text=model.gd3.ToString();
		//this.lblgd4.Text=model.gd4.ToString();
		//this.lblgd5.Text=model.gd5.ToString();
		//this.lblgdc1.Text=model.gdc1.ToString();
		//this.lblgdc2.Text=model.gdc2.ToString();
		//this.lblgdc3.Text=model.gdc3.ToString();
		//this.lblgdc4.Text=model.gdc4.ToString();
		//this.lblgdc5.Text=model.gdc5.ToString();

	}


    }
}
