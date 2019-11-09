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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string sname=this.txtsname.Text;
			int sminutes=int.Parse(this.txtsminutes.Text);
			string sdesc=this.txtsdesc.Text;

			Jium.Model.servicetype model=new Jium.Model.servicetype();
			model.sname=sname;
			model.sminutes=sminutes;
			model.sdesc=sdesc;

			Jium.BLL.servicetype bll=new Jium.BLL.servicetype();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
