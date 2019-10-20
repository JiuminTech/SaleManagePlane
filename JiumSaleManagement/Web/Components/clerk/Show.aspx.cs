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
namespace Jium.Web.clerk
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
		Jium.BLL.clerk bll=new Jium.BLL.clerk();
		Jium.Model.clerk model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblcname.Text=model.cname;
		this.lblcphone.Text=model.cphone;
		this.lblcemail.Text=model.cemail;
		this.lblcsex.Text=model.csex.ToString();
		this.lblclevel.Text=model.clevel.ToString();
		this.lblccode.Text=model.ccode;
		this.lblcaddress.Text=model.caddress;
		this.lblcsalesum.Text=model.csalesum.ToString();
		this.lblcremark.Text=model.cremark;
		this.lblcls1.Text=model.cls1;
		this.lblcls2.Text=model.cls2;
		this.lblcls3.Text=model.cls3;
		this.lblcls4.Text=model.cls4;
		this.lblcls5.Text=model.cls5;
		this.lblcld1.Text=model.cld1.ToString();
		this.lblcld2.Text=model.cld2.ToString();
		this.lblcld3.Text=model.cld3.ToString();
		this.lblcld4.Text=model.cld4.ToString();
		this.lblcld5.Text=model.cld5.ToString();
		this.lblcldc1.Text=model.cldc1.ToString();
		this.lblcldc2.Text=model.cldc2.ToString();
		this.lblcldc3.Text=model.cldc3.ToString();
		this.lblcldc4.Text=model.cldc4.ToString();
		this.lblcldc5.Text=model.cldc5.ToString();

	}


    }
}
