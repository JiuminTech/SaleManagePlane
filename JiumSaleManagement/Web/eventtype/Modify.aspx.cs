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
namespace Jium.Web.eventtype
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					long id=(Convert.ToInt64(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(long id)
	{
		Jium.BLL.eventtype bll=new Jium.BLL.eventtype();
		Jium.Model.eventtype model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txteventname.Text=model.eventname;
		this.txtremark.Text=model.remark;
		this.chkisnotify.Checked=model.isnotify;
		this.txtudatetime.Text=model.udatetime;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txteventname.Text.Trim().Length==0)
			{
				strErr+="eventname不能为空！\\n";	
			}
			if(this.txtremark.Text.Trim().Length==0)
			{
				strErr+="remark不能为空！\\n";	
			}
			if(this.txtudatetime.Text.Trim().Length==0)
			{
				strErr+="udatetime不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long id=long.Parse(this.lblid.Text);
			string eventname=this.txteventname.Text;
			string remark=this.txtremark.Text;
			bool isnotify=this.chkisnotify.Checked;
			string udatetime=this.txtudatetime.Text;


			Jium.Model.eventtype model=new Jium.Model.eventtype();
			model.id=id;
			model.eventname=eventname;
			model.remark=remark;
			model.isnotify=isnotify;
			model.udatetime=udatetime;

			Jium.BLL.eventtype bll=new Jium.BLL.eventtype();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
