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
namespace Jium.Web.piorecord
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
		Jium.BLL.piorecord bll=new Jium.BLL.piorecord();
		Jium.Model.piorecord model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblptime.Text=model.ptime;
		this.lblpcode.Text=model.pcode;
		this.lblpcnt.Text=model.pcnt.ToString();
		this.lblpsaleprice.Text=model.psaleprice.ToString();
		this.lblprealprice.Text=model.prealprice.ToString();
		this.lblptype.Text=model.ptype.ToString();
		this.lblpzekou.Text=model.pzekou.ToString();
		this.lblpremark.Text=model.premark;
		this.lblpguestid.Text=model.pguestid.ToString();
		this.lblpsalerid.Text=model.psalerid.ToString();
		this.lblpios1.Text=model.pios1;
		this.lblpios2.Text=model.pios2;
		//this.lblpios3.Text=model.pios3;
		//this.lblpios4.Text=model.pios4;
		//this.lblpios5.Text=model.pios5;
		//this.lblpiod1.Text=model.piod1.ToString();
		//this.lblpiod2.Text=model.piod2.ToString();
		//this.lblpiod3.Text=model.piod3.ToString();
		//this.lblpiod5.Text=model.piod5.ToString();
		//this.lblpiod4.Text=model.piod4.ToString();
		//this.lblpiodc1.Text=model.piodc1.ToString();
		//this.lblpiodc2.Text=model.piodc2.ToString();
		//this.lblpiodc3.Text=model.piodc3.ToString();
		//this.lblpiodc4.Text=model.piodc4.ToString();
		//this.lblpiodc5.Text=model.piodc5.ToString();

	}


    }
}
