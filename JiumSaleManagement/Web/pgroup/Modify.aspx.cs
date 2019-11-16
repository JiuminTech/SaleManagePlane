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
namespace Jium.Web.pgroup
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
		Jium.BLL.pgroup bll=new Jium.BLL.pgroup();
		Jium.Model.pgroup model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtgid.Text=model.gid.ToString();
		this.txtgindex.Text=model.gindex.ToString();
		this.txtgpid.Text=model.gpid.ToString();
		this.txtgpcnt.Text=model.gpcnt.ToString();
		this.txtgdesc.Text=model.gdesc;
		//this.txtgs1.Text=model.gs1;
		//this.txtgs2.Text=model.gs2;
		//this.txtgs3.Text=model.gs3;
		//this.txtgs4.Text=model.gs4;
		//this.txtgs5.Text=model.gs5;
		//this.txtgd1.Text=model.gd1.ToString();
		//this.txtgd2.Text=model.gd2.ToString();
		//this.txtgd3.Text=model.gd3.ToString();
		//this.txtgd4.Text=model.gd4.ToString();
		//this.txtgd5.Text=model.gd5.ToString();
		//this.txtgdc1.Text=model.gdc1.ToString();
		//this.txtgdc2.Text=model.gdc2.ToString();
		//this.txtgdc3.Text=model.gdc3.ToString();
		//this.txtgdc4.Text=model.gdc4.ToString();
		//this.txtgdc5.Text=model.gdc5.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtgid.Text))
			{
				strErr+="gid格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtgindex.Text))
			{
				strErr+="gindex格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtgpid.Text))
			{
				strErr+="gpid格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtgpcnt.Text))
			{
				strErr+="gpcnt格式错误！\\n";	
			}
			//if(this.txtgdesc.Text.Trim().Length==0)
			//{
			//	strErr+="gdesc不能为空！\\n";	
			//}
			//if(this.txtgs1.Text.Trim().Length==0)
			//{
			//	strErr+="gs1不能为空！\\n";	
			//}
			//if(this.txtgs2.Text.Trim().Length==0)
			//{
			//	strErr+="gs2不能为空！\\n";	
			//}
			//if(this.txtgs3.Text.Trim().Length==0)
			//{
			//	strErr+="gs3不能为空！\\n";	
			//}
			//if(this.txtgs4.Text.Trim().Length==0)
			//{
			//	strErr+="gs4不能为空！\\n";	
			//}
			//if(this.txtgs5.Text.Trim().Length==0)
			//{
			//	strErr+="gs5不能为空！\\n";	
			//}
			//if(!PageValidate.IsNumber(txtgd1.Text))
			//{
			//	strErr+="gd1格式错误！\\n";	
			//}
			//if(!PageValidate.IsNumber(txtgd2.Text))
			//{
			//	strErr+="gd2格式错误！\\n";	
			//}
			//if(!PageValidate.IsNumber(txtgd3.Text))
			//{
			//	strErr+="gd3格式错误！\\n";	
			//}
			//if(!PageValidate.IsNumber(txtgd4.Text))
			//{
			//	strErr+="gd4格式错误！\\n";	
			//}
			//if(!PageValidate.IsNumber(txtgd5.Text))
			//{
			//	strErr+="gd5格式错误！\\n";	
			//}
			//if(!PageValidate.IsDecimal(txtgdc1.Text))
			//{
			//	strErr+="gdc1格式错误！\\n";	
			//}
			//if(!PageValidate.IsDecimal(txtgdc2.Text))
			//{
			//	strErr+="gdc2格式错误！\\n";	
			//}
			//if(!PageValidate.IsDecimal(txtgdc3.Text))
			//{
			//	strErr+="gdc3格式错误！\\n";	
			//}
			//if(!PageValidate.IsDecimal(txtgdc4.Text))
			//{
			//	strErr+="gdc4格式错误！\\n";	
			//}
			//if(!PageValidate.IsDecimal(txtgdc5.Text))
			//{
			//	strErr+="gdc5格式错误！\\n";	
			//}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long id=long.Parse(this.lblid.Text);
			int gid=int.Parse(this.txtgid.Text);
			int gindex=int.Parse(this.txtgindex.Text);
			int gpid=int.Parse(this.txtgpid.Text);
			int gpcnt=int.Parse(this.txtgpcnt.Text);
			string gdesc=this.txtgdesc.Text;
			//string gs1=this.txtgs1.Text;
			//string gs2=this.txtgs2.Text;
			//string gs3=this.txtgs3.Text;
			//string gs4=this.txtgs4.Text;
			//string gs5=this.txtgs5.Text;
			//int gd1=int.Parse(this.txtgd1.Text);
			//int gd2=int.Parse(this.txtgd2.Text);
			//int gd3=int.Parse(this.txtgd3.Text);
			//int gd4=int.Parse(this.txtgd4.Text);
			//int gd5=int.Parse(this.txtgd5.Text);
			//decimal gdc1=decimal.Parse(this.txtgdc1.Text);
			//decimal gdc2=decimal.Parse(this.txtgdc2.Text);
			//decimal gdc3=decimal.Parse(this.txtgdc3.Text);
			//decimal gdc4=decimal.Parse(this.txtgdc4.Text);
			//decimal gdc5=decimal.Parse(this.txtgdc5.Text);


			Jium.Model.pgroup model=new Jium.Model.pgroup();
			model.id=id;
			model.gid=gid;
			model.gindex=gindex;
			model.gpid=gpid;
			model.gpcnt=gpcnt;
			model.gdesc=gdesc;
			//model.gs1=gs1;
			//model.gs2=gs2;
			//model.gs3=gs3;
			//model.gs4=gs4;
			//model.gs5=gs5;
			//model.gd1=gd1;
			//model.gd2=gd2;
			//model.gd3=gd3;
			//model.gd4=gd4;
			//model.gd5=gd5;
			//model.gdc1=gdc1;
			//model.gdc2=gdc2;
			//model.gdc3=gdc3;
			//model.gdc4=gdc4;
			//model.gdc5=gdc5;

			Jium.BLL.pgroup bll=new Jium.BLL.pgroup();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
