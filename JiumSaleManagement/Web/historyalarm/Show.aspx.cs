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
namespace Jium.Web.historyalarm
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
		Jium.BLL.historyalarm bll=new Jium.BLL.historyalarm();
		Jium.Model.historyalarm model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblalarmname.Text=model.alarmname;
		this.lblalarmdesc.Text=model.alarmdesc;
		this.lblcreatetime.Text=model.createtime;
		this.lblupdatetime.Text=model.updatetime;
		this.lblownerid.Text=model.ownerid.ToString();
		this.lblhandlerid.Text=model.handlerid.ToString();
		this.lblalarmtype.Text=model.alarmtype.ToString();
		this.lbloperateid.Text=model.operateid.ToString();
		this.lblhandlestatus.Text=model.handlestatus.ToString();
		this.lblconfirmtime.Text=model.confirmtime;
		this.lblhandledetail.Text=model.handledetail;

	}


    }
}
