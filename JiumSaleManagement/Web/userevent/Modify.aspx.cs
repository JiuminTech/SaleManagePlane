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
namespace Jium.Web.userevent
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
		Jium.BLL.userevent bll=new Jium.BLL.userevent();
		Jium.Model.userevent model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtuserid.Text=model.userid.ToString();
		this.txteventid.Text=model.eventid.ToString();
		this.txteventtime.Text=model.eventtime;
		this.txtremark.Text=model.remark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtuserid.Text))
			{
				strErr+="userid格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txteventid.Text))
			{
				strErr+="eventid格式错误！\\n";	
			}
			if(this.txteventtime.Text.Trim().Length==0)
			{
				strErr+="eventtime不能为空！\\n";	
			}
			if(this.txtremark.Text.Trim().Length==0)
			{
				strErr+="remark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long id=long.Parse(this.lblid.Text);
			int userid=int.Parse(this.txtuserid.Text);
			long eventid=long.Parse(this.txteventid.Text);
			string eventtime=this.txteventtime.Text;
			string remark=this.txtremark.Text;


			Jium.Model.userevent model=new Jium.Model.userevent();
			model.id=id;
			model.userid=userid;
			model.eventid=eventid;
			model.eventtime=eventtime;
			model.remark=remark;

			Jium.BLL.userevent bll=new Jium.BLL.userevent();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
