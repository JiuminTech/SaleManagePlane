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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string eventname=this.txteventname.Text;
			string remark=this.txtremark.Text;
			bool isnotify=this.chkisnotify.Checked;
			string udatetime=this.txtudatetime.Text;

			Jium.Model.eventtype model=new Jium.Model.eventtype();
			model.eventname=eventname;
			model.remark=remark;
			model.isnotify=isnotify;
			model.udatetime=udatetime;

			Jium.BLL.eventtype bll=new Jium.BLL.eventtype();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
