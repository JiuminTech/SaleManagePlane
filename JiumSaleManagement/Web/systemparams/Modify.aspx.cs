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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Jium.Web.systemparams
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		Jium.BLL.systemparams bll=new Jium.BLL.systemparams();
		Jium.Model.systemparams model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblparamname.Text=model.paramname;
		this.txtparamvalue.Text=model.paramvalue;
		this.txtremark.Text=model.remark;
		this.txtstatus.Text=model.status.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtparamvalue.Text.Trim().Length==0)
			{
				strErr+="paramvalue不能为空！\\n";	
			}
			if(this.txtremark.Text.Trim().Length==0)
			{
				strErr+="remark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtstatus.Text))
			{
				strErr+="status格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string paramname=this.lblparamname.Text;
			string paramvalue=this.txtparamvalue.Text;
			string remark=this.txtremark.Text;
			int status=int.Parse(this.txtstatus.Text);


			Jium.Model.systemparams model=new Jium.Model.systemparams();
			model.id=id;
			model.paramname=paramname;
			model.paramvalue=paramvalue;
			model.remark=remark;
			model.status=status;

			Jium.BLL.systemparams bll=new Jium.BLL.systemparams();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
