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
namespace Jium.Web.consumer
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
		Jium.BLL.consumer bll=new Jium.BLL.consumer();
		Jium.Model.consumer model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblcname.Text=model.cname;
		this.lblccode.Text=model.ccode;
		this.lblcphone.Text=model.cphone;
		this.lblcemail.Text=model.cemail;
		this.lblclevel.Text=model.clevel;
		this.lblcsum.Text=model.csum.ToString();
		this.lblcsex.Text=model.csex.ToString();
		this.lblcremark.Text=model.cremark;
		this.lblcss1.Text=model.css1;
		this.lblcss2.Text=model.css2;
		this.lblcss3.Text=model.css3;
		this.lblcss4.Text=model.css4;
		this.lblcss5.Text=model.css5;
		this.lblcsd1.Text=model.csd1.ToString();
		this.lblcsd2.Text=model.csd2.ToString();
		this.lblcsd3.Text=model.csd3.ToString();
		this.lblcsd4.Text=model.csd4.ToString();
		this.lblcsd5.Text=model.csd5.ToString();
		this.lblcsdc1.Text=model.csdc1.ToString();
		this.lblcsdc2.Text=model.csdc2.ToString();
		this.lblcsdc3.Text=model.csdc3.ToString();
		this.lblcsdc4.Text=model.csdc4.ToString();
		this.lblcsdc5.Text=model.csdc5.ToString();

	}


    }
}
