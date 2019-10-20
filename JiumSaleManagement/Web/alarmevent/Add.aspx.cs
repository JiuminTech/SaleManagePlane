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
namespace Jium.Web.alarmevent
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

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string alarmname=this.txtalarmname.Text;
			string alarmdesc=this.txtalarmdesc.Text;
			string createtime=this.txtcreatetime.Text;
			string updatetime=this.txtupdatetime.Text;

			Jium.Model.alarmevent model=new Jium.Model.alarmevent();
			model.alarmname=alarmname;
			model.alarmdesc=alarmdesc;
			model.createtime=createtime;
			model.updatetime=updatetime;

			Jium.BLL.alarmevent bll=new Jium.BLL.alarmevent();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
