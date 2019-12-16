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
namespace Jium.Web.serviceplan
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
					string id= strid;
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(string id)
	{
		Jium.BLL.serviceplan bll=new Jium.BLL.serviceplan();
		Jium.Model.serviceplan model=bll.GetModel(id);
		this.lblid.Text=model.id;
		this.lblplandate.Text=model.plandate;
		this.lblplantime.Text=model.plantime;
		this.lbltotalnum.Text=model.totalnum.ToString();
		this.lblleftnum.Text=model.leftnum.ToString();
		this.lblnexttotal.Text=model.nexttotal.ToString();
		this.lblnextleft.Text=model.nextleft.ToString();
		this.lblnextid.Text=model.nextid;
		this.lblpss1.Text=model.pss1;
		//this.lblpss2.Text=model.pss2;
		//this.lblpss3.Text=model.pss3;
		//this.lblpss4.Text=model.pss4;
		//this.lblpss5.Text=model.pss5;
		//this.lblpsd1.Text=model.psd1.ToString();
		//this.lblpsd2.Text=model.psd2.ToString();
		//this.lblpsd3.Text=model.psd3.ToString();
		//this.lblpsd4.Text=model.psd4.ToString();
		//this.lblpsd5.Text=model.psd5.ToString();

	}


    }
}
