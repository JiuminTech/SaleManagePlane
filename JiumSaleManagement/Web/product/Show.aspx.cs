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
namespace Jium.Web.product
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
		Jium.BLL.product bll=new Jium.BLL.product();
		Jium.Model.product model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblpcode.Text=model.pcode;
		this.lblpname.Text=model.pname;
		this.lblpsaleprice.Text=model.psaleprice.ToString();
		this.lblprealprice.Text=model.prealprice.ToString();
		this.lblptype.Text=model.ptype;
		this.lblpisgroup.Text=model.pisgroup.ToString();
		this.lblpdesc.Text=model.pdesc;
		this.lblps1.Text=model.ps1;
		this.lblps2.Text=model.ps2;
		this.lblps3.Text=model.ps3;
		this.lblps4.Text=model.ps4;
		this.lblps5.Text=model.ps5;
		this.lblpd1.Text=model.pd1.ToString();
		this.lblpd2.Text=model.pd2.ToString();
		this.lblpd3.Text=model.pd3.ToString();
		this.lblpd4.Text=model.pd4.ToString();
		this.lblpd5.Text=model.pd5.ToString();
		this.lblpdc1.Text=model.pdc1.ToString();
		this.lblpdc2.Text=model.pdc2.ToString();
		this.lblpdc3.Text=model.pdc3.ToString();

	}


    }
}
