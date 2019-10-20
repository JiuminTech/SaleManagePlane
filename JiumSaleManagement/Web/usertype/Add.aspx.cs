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
namespace Jium.Web.usertype
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
			if(!PageValidate.IsNumber(txtauthvalue.Text))
			{
				strErr+="authvalue格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string tagname=this.txttagname.Text;
			int authvalue=int.Parse(this.txtauthvalue.Text);

			Jium.Model.usertype model=new Jium.Model.usertype();
			model.tagname=tagname;
			model.authvalue=authvalue;

			Jium.BLL.usertype bll=new Jium.BLL.usertype();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
