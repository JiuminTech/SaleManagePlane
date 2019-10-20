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
namespace Jium.Web.consumer
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		Jium.BLL.consumer bll=new Jium.BLL.consumer();
		Jium.Model.consumer model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtcname.Text=model.cname;
		this.txtccode.Text=model.ccode;
		this.txtcphone.Text=model.cphone;
		this.txtcemail.Text=model.cemail;
		this.txtclevel.Text=model.clevel;
		this.txtcsum.Text=model.csum.ToString();
		this.txtcsex.Text=model.csex.ToString();
		this.txtcremark.Text=model.cremark;
		this.txtcss1.Text=model.css1;
		this.txtcss2.Text=model.css2;
		this.txtcss3.Text=model.css3;
		this.txtcss4.Text=model.css4;
		this.txtcss5.Text=model.css5;
		this.txtcsd1.Text=model.csd1.ToString();
		this.txtcsd2.Text=model.csd2.ToString();
		this.txtcsd3.Text=model.csd3.ToString();
		this.txtcsd4.Text=model.csd4.ToString();
		this.txtcsd5.Text=model.csd5.ToString();
		this.txtcsdc1.Text=model.csdc1.ToString();
		this.txtcsdc2.Text=model.csdc2.ToString();
		this.txtcsdc3.Text=model.csdc3.ToString();
		this.txtcsdc4.Text=model.csdc4.ToString();
		this.txtcsdc5.Text=model.csdc5.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcname.Text.Trim().Length==0)
			{
				strErr+="cname不能为空！\\n";	
			}
			if(this.txtccode.Text.Trim().Length==0)
			{
				strErr+="ccode不能为空！\\n";	
			}
			if(this.txtcphone.Text.Trim().Length==0)
			{
				strErr+="cphone不能为空！\\n";	
			}
			if(this.txtcemail.Text.Trim().Length==0)
			{
				strErr+="cemail不能为空！\\n";	
			}
			if(this.txtclevel.Text.Trim().Length==0)
			{
				strErr+="clevel不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcsum.Text))
			{
				strErr+="csum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcsex.Text))
			{
				strErr+="csex格式错误！\\n";	
			}
			if(this.txtcremark.Text.Trim().Length==0)
			{
				strErr+="cremark不能为空！\\n";	
			}
			if(this.txtcss1.Text.Trim().Length==0)
			{
				strErr+="css1不能为空！\\n";	
			}
			if(this.txtcss2.Text.Trim().Length==0)
			{
				strErr+="css2不能为空！\\n";	
			}
			if(this.txtcss3.Text.Trim().Length==0)
			{
				strErr+="css3不能为空！\\n";	
			}
			if(this.txtcss4.Text.Trim().Length==0)
			{
				strErr+="css4不能为空！\\n";	
			}
			if(this.txtcss5.Text.Trim().Length==0)
			{
				strErr+="css5不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcsd1.Text))
			{
				strErr+="csd1格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcsd2.Text))
			{
				strErr+="csd2格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcsd3.Text))
			{
				strErr+="csd3格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcsd4.Text))
			{
				strErr+="csd4格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcsd5.Text))
			{
				strErr+="csd5格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcsdc1.Text))
			{
				strErr+="csdc1格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcsdc2.Text))
			{
				strErr+="csdc2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcsdc3.Text))
			{
				strErr+="csdc3格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcsdc4.Text))
			{
				strErr+="csdc4格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcsdc5.Text))
			{
				strErr+="csdc5格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string cname=this.txtcname.Text;
			string ccode=this.txtccode.Text;
			string cphone=this.txtcphone.Text;
			string cemail=this.txtcemail.Text;
			string clevel=this.txtclevel.Text;
			decimal csum=decimal.Parse(this.txtcsum.Text);
			int csex=int.Parse(this.txtcsex.Text);
			string cremark=this.txtcremark.Text;
			string css1=this.txtcss1.Text;
			string css2=this.txtcss2.Text;
			string css3=this.txtcss3.Text;
			string css4=this.txtcss4.Text;
			string css5=this.txtcss5.Text;
			int csd1=int.Parse(this.txtcsd1.Text);
			int csd2=int.Parse(this.txtcsd2.Text);
			int csd3=int.Parse(this.txtcsd3.Text);
			int csd4=int.Parse(this.txtcsd4.Text);
			int csd5=int.Parse(this.txtcsd5.Text);
			decimal csdc1=decimal.Parse(this.txtcsdc1.Text);
			decimal csdc2=decimal.Parse(this.txtcsdc2.Text);
			decimal csdc3=decimal.Parse(this.txtcsdc3.Text);
			decimal csdc4=decimal.Parse(this.txtcsdc4.Text);
			decimal csdc5=decimal.Parse(this.txtcsdc5.Text);


			Jium.Model.consumer model=new Jium.Model.consumer();
			model.id=id;
			model.cname=cname;
			model.ccode=ccode;
			model.cphone=cphone;
			model.cemail=cemail;
			model.clevel=clevel;
			model.csum=csum;
			model.csex=csex;
			model.cremark=cremark;
			model.css1=css1;
			model.css2=css2;
			model.css3=css3;
			model.css4=css4;
			model.css5=css5;
			model.csd1=csd1;
			model.csd2=csd2;
			model.csd3=csd3;
			model.csd4=csd4;
			model.csd5=csd5;
			model.csdc1=csdc1;
			model.csdc2=csdc2;
			model.csdc3=csdc3;
			model.csdc4=csdc4;
			model.csdc5=csdc5;

			Jium.BLL.consumer bll=new Jium.BLL.consumer();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
