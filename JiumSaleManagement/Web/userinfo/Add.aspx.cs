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
namespace Jium.Web.userinfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txttagname.Text.Trim().Length==0)
			{
				strErr+="tagname不能为空！\\n";	
			}
			if(this.txtemail.Text.Trim().Length==0)
			{
				strErr+="email不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtlevel.Text))
			{
				strErr+="level格式错误！\\n";	
			}
			if(this.txtpwd.Text.Trim().Length==0)
			{
				strErr+="pwd不能为空！\\n";	
			}
			if(this.txtremark.Text.Trim().Length==0)
			{
				strErr+="remark不能为空！\\n";	
			}
			//if(this.txtcreatetime.Text.Trim().Length==0)
			//{
			//	strErr+="createtime不能为空！\\n";	
			//}
			//if(this.txttoken.Text.Trim().Length==0)
			//{
			//	strErr+="token不能为空！\\n";	
			//}
			//if(this.txttokentime.Text.Trim().Length==0)
			//{
			//	strErr+="tokentime不能为空！\\n";	
			//}
			//if(!PageValidate.IsNumber(txtstatus.Text))
			//{
			//	strErr+="status格式错误！\\n";	
			//}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string tagname=this.txttagname.Text;
			string email=this.txtemail.Text;
			int level=int.Parse(this.txtlevel.Text);
			string pwd=this.txtpwd.Text;
			string remark=this.txtremark.Text;
            string createtime = DateTime.Now.ToString("yyyyMMddHHmmss");// this.txtcreatetime.Text;
			//string token=this.txttoken.Text;
			//string tokentime=this.txttokentime.Text;
			//int status=int.Parse(this.txtstatus.Text);

			Jium.Model.userinfo model=new Jium.Model.userinfo();
			model.tagname=tagname;
			model.email=email;
			model.level=level;
			model.pwd=pwd;
			model.remark=remark;
			model.createtime=createtime;
			//model.token=token;
			//model.tokentime=tokentime;
			//model.status=status;

			Jium.BLL.userinfo bll=new Jium.BLL.userinfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
