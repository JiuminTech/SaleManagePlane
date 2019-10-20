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
namespace Jium.Web.systemparams
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtparamname.Text.Trim().Length==0)
			{
				strErr+="paramname不能为空！\\n";	
			}
			if(this.txtparamvalue.Text.Trim().Length==0)
			{
				strErr+="paramvalue不能为空！\\n";	
			}
			if(this.txtremark.Text.Trim().Length==0)
			{
				strErr+="remark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtstatus.Text))
			{
				strErr+="status格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string paramname=this.txtparamname.Text;
			string paramvalue=this.txtparamvalue.Text;
			string remark=this.txtremark.Text;
			int status=int.Parse(this.txtstatus.Text);

			Jium.Model.systemparams model=new Jium.Model.systemparams();
			model.paramname=paramname;
			model.paramvalue=paramvalue;
			model.remark=remark;
			model.status=status;

			Jium.BLL.systemparams bll=new Jium.BLL.systemparams();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
