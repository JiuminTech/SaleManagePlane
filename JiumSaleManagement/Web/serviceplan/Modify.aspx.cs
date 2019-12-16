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
namespace Jium.Web.serviceplan
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string id= Request.Params["id"];
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(string id)
	{
		Jium.BLL.serviceplan bll=new Jium.BLL.serviceplan();
		Jium.Model.serviceplan model=bll.GetModel(id);
		this.lblid.Text=model.id;
		this.txtplandate.Text=model.plandate;
		this.txtplantime.Text=model.plantime;
		this.txttotalnum.Text=model.totalnum.ToString();
		this.txtleftnum.Text=model.leftnum.ToString();
		this.txtnexttotal.Text=model.nexttotal.ToString();
		this.txtnextleft.Text=model.nextleft.ToString();
		this.txtnextid.Text=model.nextid;
		this.txtpss1.Text=model.pss1;
		//this.txtpss2.Text=model.pss2;
		//this.txtpss3.Text=model.pss3;
		//this.txtpss4.Text=model.pss4;
		//this.txtpss5.Text=model.pss5;
		//this.txtpsd1.Text=model.psd1.ToString();
		//this.txtpsd2.Text=model.psd2.ToString();
		//this.txtpsd3.Text=model.psd3.ToString();
		//this.txtpsd4.Text=model.psd4.ToString();
		//this.txtpsd5.Text=model.psd5.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtplandate.Text.Trim().Length==0)
			{
				strErr+="plandate不能为空！\\n";	
			}
			if(this.txtplantime.Text.Trim().Length==0)
			{
				strErr+="plantime不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txttotalnum.Text))
			{
				strErr+="totalnum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtleftnum.Text))
			{
				strErr+="leftnum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtnexttotal.Text))
			{
				strErr+="nexttotal格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtnextleft.Text))
			{
				strErr+="nextleft格式错误！\\n";	
			}
			if(this.txtnextid.Text.Trim().Length==0)
			{
				strErr+="nextid不能为空！\\n";	
			}
			//if(this.txtpss1.Text.Trim().Length==0)
			//{
			//	strErr+="pss1不能为空！\\n";	
			//}
			//if(this.txtpss2.Text.Trim().Length==0)
			//{
			//	strErr+="pss2不能为空！\\n";	
			//}
			//if(this.txtpss3.Text.Trim().Length==0)
			//{
			//	strErr+="pss3不能为空！\\n";	
			//}
			//if(this.txtpss4.Text.Trim().Length==0)
			//{
			//	strErr+="pss4不能为空！\\n";	
			//}
			//if(this.txtpss5.Text.Trim().Length==0)
			//{
			//	strErr+="pss5不能为空！\\n";	
			//}
			//if(!PageValidate.IsNumber(txtpsd1.Text))
			//{
			//	strErr+="psd1格式错误！\\n";	
			//}
			//if(!PageValidate.IsNumber(txtpsd2.Text))
			//{
			//	strErr+="psd2格式错误！\\n";	
			//}
			//if(!PageValidate.IsNumber(txtpsd3.Text))
			//{
			//	strErr+="psd3格式错误！\\n";	
			//}
			//if(!PageValidate.IsNumber(txtpsd4.Text))
			//{
			//	strErr+="psd4格式错误！\\n";	
			//}
			//if(!PageValidate.IsNumber(txtpsd5.Text))
			//{
			//	strErr+="psd5格式错误！\\n";	
			//}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string id=this.lblid.Text;
			string plandate=this.txtplandate.Text;
			string plantime=this.txtplantime.Text;
			int totalnum=int.Parse(this.txttotalnum.Text);
			int leftnum=int.Parse(this.txtleftnum.Text);
			int nexttotal=int.Parse(this.txtnexttotal.Text);
			int nextleft=int.Parse(this.txtnextleft.Text);
			string nextid=this.txtnextid.Text;
			string pss1=this.txtpss1.Text;
			//string pss2=this.txtpss2.Text;
			//string pss3=this.txtpss3.Text;
			//string pss4=this.txtpss4.Text;
			//string pss5=this.txtpss5.Text;
			//int psd1=int.Parse(this.txtpsd1.Text);
			//int psd2=int.Parse(this.txtpsd2.Text);
			//int psd3=int.Parse(this.txtpsd3.Text);
			//int psd4=int.Parse(this.txtpsd4.Text);
			//int psd5=int.Parse(this.txtpsd5.Text);


			Jium.Model.serviceplan model=new Jium.Model.serviceplan();
			model.id=id;
			model.plandate=plandate;
			model.plantime=plantime;
			model.totalnum=totalnum;
			model.leftnum=leftnum;
			model.nexttotal=nexttotal;
			model.nextleft=nextleft;
			model.nextid=nextid;
			model.pss1=pss1;
			//model.pss2=pss2;
			//model.pss3=pss3;
			//model.pss4=pss4;
			//model.pss5=pss5;
			//model.psd1=psd1;
			//model.psd2=psd2;
			//model.psd3=psd3;
			//model.psd4=psd4;
			//model.psd5=psd5;

			Jium.BLL.serviceplan bll=new Jium.BLL.serviceplan();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
