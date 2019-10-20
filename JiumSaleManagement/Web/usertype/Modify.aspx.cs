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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int level=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(level);
				}
			}
		}
			
	private void ShowInfo(int level)
	{
		Jium.BLL.usertype bll=new Jium.BLL.usertype();
		Jium.Model.usertype model=bll.GetModel(level);
		this.txttagname.Text=model.tagname;
		this.lbllevel.Text=model.level.ToString();
		this.txtauthvalue.Text=model.authvalue.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int level=int.Parse(this.lbllevel.Text);
			int authvalue=int.Parse(this.txtauthvalue.Text);


			Jium.Model.usertype model=new Jium.Model.usertype();
			model.tagname=tagname;
			model.level=level;
			model.authvalue=authvalue;

			Jium.BLL.usertype bll=new Jium.BLL.usertype();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
