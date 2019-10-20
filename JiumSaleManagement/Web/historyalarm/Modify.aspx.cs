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
namespace Jium.Web.historyalarm
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
		Jium.BLL.historyalarm bll=new Jium.BLL.historyalarm();
		Jium.Model.historyalarm model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtalarmname.Text=model.alarmname;
		this.txtalarmdesc.Text=model.alarmdesc;
		this.txtcreatetime.Text=model.createtime;
		this.txtupdatetime.Text=model.updatetime;
		this.txtownerid.Text=model.ownerid.ToString();
		this.txthandlerid.Text=model.handlerid.ToString();
		this.txtalarmtype.Text=model.alarmtype.ToString();
		this.txtoperateid.Text=model.operateid.ToString();
		this.txthandlestatus.Text=model.handlestatus.ToString();
		this.txtconfirmtime.Text=model.confirmtime;
		this.txthandledetail.Text=model.handledetail;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtalarmname.Text.Trim().Length==0)
			{
				strErr+="alarmname不能为空！\\n";	
			}
			if(this.txtalarmdesc.Text.Trim().Length==0)
			{
				strErr+="alarmdesc不能为空！\\n";	
			}
			if(this.txtcreatetime.Text.Trim().Length==0)
			{
				strErr+="createtime不能为空！\\n";	
			}
			if(this.txtupdatetime.Text.Trim().Length==0)
			{
				strErr+="updatetime不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtownerid.Text))
			{
				strErr+="ownerid格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txthandlerid.Text))
			{
				strErr+="handlerid格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtalarmtype.Text))
			{
				strErr+="alarmtype格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtoperateid.Text))
			{
				strErr+="operateid格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txthandlestatus.Text))
			{
				strErr+="handlestatus格式错误！\\n";	
			}
			if(this.txtconfirmtime.Text.Trim().Length==0)
			{
				strErr+="confirmtime不能为空！\\n";	
			}
			if(this.txthandledetail.Text.Trim().Length==0)
			{
				strErr+="handledetail不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long id=long.Parse(this.lblid.Text);
			string alarmname=this.txtalarmname.Text;
			string alarmdesc=this.txtalarmdesc.Text;
			string createtime=this.txtcreatetime.Text;
			string updatetime=this.txtupdatetime.Text;
			int ownerid=int.Parse(this.txtownerid.Text);
			int handlerid=int.Parse(this.txthandlerid.Text);
			int alarmtype=int.Parse(this.txtalarmtype.Text);
			long operateid=long.Parse(this.txtoperateid.Text);
			int handlestatus=int.Parse(this.txthandlestatus.Text);
			string confirmtime=this.txtconfirmtime.Text;
			string handledetail=this.txthandledetail.Text;


			Jium.Model.historyalarm model=new Jium.Model.historyalarm();
			model.id=id;
			model.alarmname=alarmname;
			model.alarmdesc=alarmdesc;
			model.createtime=createtime;
			model.updatetime=updatetime;
			model.ownerid=ownerid;
			model.handlerid=handlerid;
			model.alarmtype=alarmtype;
			model.operateid=operateid;
			model.handlestatus=handlestatus;
			model.confirmtime=confirmtime;
			model.handledetail=handledetail;

			Jium.BLL.historyalarm bll=new Jium.BLL.historyalarm();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
