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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtuserid.Text))
			{
				strErr+="userid格式错误！\\n";	
			}
			if(this.txteventid.Text.Trim().Length==0)
			{
				strErr+="eventid不能为空！\\n";	
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
			int userid=int.Parse(this.txtuserid.Text);
			string eventid=this.txteventid.Text;
			string eventtime=this.txteventtime.Text;
			string remark=this.txtremark.Text;

			Jium.Model.userevent model=new Jium.Model.userevent();
			model.userid=userid;
			model.eventid=long.Parse(eventid);
			model.eventtime=eventtime;
			model.remark=remark;

			Jium.BLL.userevent bll=new Jium.BLL.userevent();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
