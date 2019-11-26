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
namespace Jium.Web.servicerorder
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
		Jium.BLL.servicerorder bll=new Jium.BLL.servicerorder();
		Jium.Model.servicerorder model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblccode.Text=model.ccode;
		this.lblspid.Text=model.spid;
		this.lblspnum.Text=model.spnum.ToString();
		this.lblspspan.Text=model.spspan.ToString();
		this.lblsostatus.Text=model.sostatus.ToString();
		this.lblcreatetime.Text=model.createtime;
		this.lblupdatetime.Text=model.updatetime;
		this.lblupdateby.Text=model.updateby;
		this.lblsos1.Text=model.sos1;
		this.lblsos2.Text=model.sos2;
		this.lblsos3.Text=model.sos3;
		this.lblsos4.Text=model.sos4;
		this.lblsos5.Text=model.sos5;
		this.lblsod1.Text=model.sod1.ToString();
		this.lblsod2.Text=model.sod2.ToString();
		this.lblsod3.Text=model.sod3.ToString();
		this.lblsod4.Text=model.sod4.ToString();
		this.lblsod5.Text=model.sod5.ToString();

	}


    }
}
