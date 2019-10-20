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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			if(this.txtoperateid.Text.Trim().Length==0)
			{
				strErr+="operateid不能为空！\\n";	
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
			string alarmname=this.txtalarmname.Text;
			string alarmdesc=this.txtalarmdesc.Text;
			string createtime=this.txtcreatetime.Text;
			string updatetime=this.txtupdatetime.Text;
			int ownerid=int.Parse(this.txtownerid.Text);
			int handlerid=int.Parse(this.txthandlerid.Text);
			int alarmtype=int.Parse(this.txtalarmtype.Text);
			string operateid=this.txtoperateid.Text;
			int handlestatus=int.Parse(this.txthandlestatus.Text);
			string confirmtime=this.txtconfirmtime.Text;
			string handledetail=this.txthandledetail.Text;

			Jium.Model.historyalarm model=new Jium.Model.historyalarm();
			model.alarmname=alarmname;
			model.alarmdesc=alarmdesc;
			model.createtime=createtime;
			model.updatetime=updatetime;
			model.ownerid=ownerid;
			model.handlerid=handlerid;
			model.alarmtype=alarmtype;
			model.operateid= long.Parse(operateid);
			model.handlestatus=handlestatus;
			model.confirmtime=confirmtime;
			model.handledetail=handledetail;

			Jium.BLL.historyalarm bll=new Jium.BLL.historyalarm();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
