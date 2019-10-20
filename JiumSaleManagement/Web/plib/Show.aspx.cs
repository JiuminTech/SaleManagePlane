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
namespace Jium.Web.plib
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				long id = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					id=(Convert.ToInt64(Request.Params["id0"]));
				}
				string pcode = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					pcode= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(id,pcode);
			}
		}
		
	private void ShowInfo(long id,string pcode)
	{
		Jium.BLL.plib bll=new Jium.BLL.plib();
		Jium.Model.plib model=bll.GetModel(id,pcode);
		this.lblid.Text=model.id.ToString();
		this.lblpcode.Text=model.pcode;
		this.lblpname.Text=model.pname;
		this.lblpdesc.Text=model.pdesc;
		this.lblpleftcnt.Text=model.pleftcnt.ToString();
		this.lblplupdatetime.Text=model.plupdatetime;
		this.lblpsumcnt.Text=model.psumcnt.ToString();
		this.lblpsalecnt.Text=model.psalecnt.ToString();
		this.lblpls1.Text=model.pls1;
		this.lblpls2.Text=model.pls2;
		this.lblpls3.Text=model.pls3;
		this.lblpls4.Text=model.pls4;
		this.lblpls5.Text=model.pls5;
		this.lblpld1.Text=model.pld1.ToString();
		this.lblpld2.Text=model.pld2.ToString();
		this.lblpld3.Text=model.pld3.ToString();
		this.lblpld4.Text=model.pld4.ToString();
		this.lblpld5.Text=model.pld5.ToString();

	}


    }
}
