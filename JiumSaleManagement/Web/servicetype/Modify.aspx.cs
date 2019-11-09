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
namespace Xwsw.Web.NMS.servicetype
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
		Jium.BLL.servicetype bll=new Jium.BLL.servicetype();
		Jium.Model.servicetype model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtsname.Text=model.sname;
		this.txtsminutes.Text=model.sminutes.ToString();
		this.txtsdesc.Text=model.sdesc;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtsname.Text.Trim().Length==0)
			{
				strErr+="sname不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtsminutes.Text))
			{
				strErr+="sminutes格式错误！\\n";	
			}
			if(this.txtsdesc.Text.Trim().Length==0)
			{
				strErr+="sdesc不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string sname=this.txtsname.Text;
			int sminutes=int.Parse(this.txtsminutes.Text);
			string sdesc=this.txtsdesc.Text;


			Jium.Model.servicetype model=new Jium.Model.servicetype();
			model.id=id;
			model.sname=sname;
			model.sminutes=sminutes;
			model.sdesc=sdesc;

			Jium.BLL.servicetype bll=new Jium.BLL.servicetype();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
