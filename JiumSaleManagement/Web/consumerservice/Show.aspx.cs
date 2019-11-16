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
namespace Xwsw.Web.NMS.consumerservice
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
		Jium.BLL.consumerservice bll=new Jium.BLL.consumerservice();
		Jium.Model.consumerservice model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblccode.Text=model.ccode;
		this.lblcphone.Text=model.cphone;
		this.lblcstype.Text=model.cstype;
		this.lblcsnum.Text=model.csnum.ToString();
		this.lblcsleft.Text=model.csleft.ToString();
		this.lblcsiostatus.Text=model.csiostatus.ToString();
		this.lblcstime0.Text=model.cstime0;
		this.lblcstime1.Text=model.cstime1;
		this.lblcstime2.Text=model.cstime2;
		this.lblcstime3.Text=model.cstime3;
		this.lblcstime4.Text=model.cstime4;
		this.lblcstime5.Text=model.cstime5;
		this.lblcstime6.Text=model.cstime6;
		this.lblcstime7.Text=model.cstime7;
		this.lblcstime8.Text=model.cstime8;
		this.lblcstime9.Text=model.cstime9;
		this.lblcstime10.Text=model.cstime10;
		//this.lblcss1.Text=model.css1;
		//this.lblcss2.Text=model.css2;
		//this.lblcss3.Text=model.css3;
		//this.lblcss4.Text=model.css4;
		//this.lblcss5.Text=model.css5;
		//this.lblcsd1.Text=model.csd1;
		//this.lblcsd2.Text=model.csd2;
		//this.lblcsd3.Text=model.csd3;
		//this.lblcsd4.Text=model.csd4;
		//this.lblcsd5.Text=model.csd5;

	}


    }
}
