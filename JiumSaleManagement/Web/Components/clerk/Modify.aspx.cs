﻿using System;
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
namespace Jium.Web.clerk
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
		Jium.BLL.clerk bll=new Jium.BLL.clerk();
		Jium.Model.clerk model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtcname.Text=model.cname;
		this.txtcphone.Text=model.cphone;
		this.txtcemail.Text=model.cemail;
		this.txtcsex.Text=model.csex.ToString();
		this.txtclevel.Text=model.clevel.ToString();
		this.lblccode.Text=model.ccode;
		this.txtcaddress.Text=model.caddress;
		this.txtcsalesum.Text=model.csalesum.ToString();
		this.txtcremark.Text=model.cremark;
		this.txtcls1.Text=model.cls1;
		this.txtcls2.Text=model.cls2;
		this.txtcls3.Text=model.cls3;
		this.txtcls4.Text=model.cls4;
		this.txtcls5.Text=model.cls5;
		this.txtcld1.Text=model.cld1.ToString();
		this.txtcld2.Text=model.cld2.ToString();
		this.txtcld3.Text=model.cld3.ToString();
		this.txtcld4.Text=model.cld4.ToString();
		this.txtcld5.Text=model.cld5.ToString();
		this.txtcldc1.Text=model.cldc1.ToString();
		this.txtcldc2.Text=model.cldc2.ToString();
		this.txtcldc3.Text=model.cldc3.ToString();
		this.txtcldc4.Text=model.cldc4.ToString();
		this.txtcldc5.Text=model.cldc5.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcname.Text.Trim().Length==0)
			{
				strErr+="cname不能为空！\\n";	
			}
			if(this.txtcphone.Text.Trim().Length==0)
			{
				strErr+="cphone不能为空！\\n";	
			}
			if(this.txtcemail.Text.Trim().Length==0)
			{
				strErr+="cemail不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcsex.Text))
			{
				strErr+="csex格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtclevel.Text))
			{
				strErr+="clevel格式错误！\\n";	
			}
			if(this.txtcaddress.Text.Trim().Length==0)
			{
				strErr+="caddress不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcsalesum.Text))
			{
				strErr+="csalesum格式错误！\\n";	
			}
			if(this.txtcremark.Text.Trim().Length==0)
			{
				strErr+="cremark不能为空！\\n";	
			}
			if(this.txtcls1.Text.Trim().Length==0)
			{
				strErr+="cls1不能为空！\\n";	
			}
			if(this.txtcls2.Text.Trim().Length==0)
			{
				strErr+="cls2不能为空！\\n";	
			}
			if(this.txtcls3.Text.Trim().Length==0)
			{
				strErr+="cls3不能为空！\\n";	
			}
			if(this.txtcls4.Text.Trim().Length==0)
			{
				strErr+="cls4不能为空！\\n";	
			}
			if(this.txtcls5.Text.Trim().Length==0)
			{
				strErr+="cls5不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcld1.Text))
			{
				strErr+="cld1格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcld2.Text))
			{
				strErr+="cld2格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcld3.Text))
			{
				strErr+="cld3格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcld4.Text))
			{
				strErr+="cld4格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcld5.Text))
			{
				strErr+="cld5格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcldc1.Text))
			{
				strErr+="cldc1格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcldc2.Text))
			{
				strErr+="cldc2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcldc3.Text))
			{
				strErr+="cldc3格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcldc4.Text))
			{
				strErr+="cldc4格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcldc5.Text))
			{
				strErr+="cldc5格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string cname=this.txtcname.Text;
			string cphone=this.txtcphone.Text;
			string cemail=this.txtcemail.Text;
			int csex=int.Parse(this.txtcsex.Text);
			int clevel=int.Parse(this.txtclevel.Text);
			string ccode=this.lblccode.Text;
			string caddress=this.txtcaddress.Text;
			decimal csalesum=decimal.Parse(this.txtcsalesum.Text);
			string cremark=this.txtcremark.Text;
			string cls1=this.txtcls1.Text;
			string cls2=this.txtcls2.Text;
			string cls3=this.txtcls3.Text;
			string cls4=this.txtcls4.Text;
			string cls5=this.txtcls5.Text;
			int cld1=int.Parse(this.txtcld1.Text);
			int cld2=int.Parse(this.txtcld2.Text);
			int cld3=int.Parse(this.txtcld3.Text);
			int cld4=int.Parse(this.txtcld4.Text);
			int cld5=int.Parse(this.txtcld5.Text);
			decimal cldc1=decimal.Parse(this.txtcldc1.Text);
			decimal cldc2=decimal.Parse(this.txtcldc2.Text);
			decimal cldc3=decimal.Parse(this.txtcldc3.Text);
			decimal cldc4=decimal.Parse(this.txtcldc4.Text);
			decimal cldc5=decimal.Parse(this.txtcldc5.Text);


			Jium.Model.clerk model=new Jium.Model.clerk();
			model.id=id;
			model.cname=cname;
			model.cphone=cphone;
			model.cemail=cemail;
			model.csex=csex;
			model.clevel=clevel;
			model.ccode=ccode;
			model.caddress=caddress;
			model.csalesum=csalesum;
			model.cremark=cremark;
			model.cls1=cls1;
			model.cls2=cls2;
			model.cls3=cls3;
			model.cls4=cls4;
			model.cls5=cls5;
			model.cld1=cld1;
			model.cld2=cld2;
			model.cld3=cld3;
			model.cld4=cld4;
			model.cld5=cld5;
			model.cldc1=cldc1;
			model.cldc2=cldc2;
			model.cldc3=cldc3;
			model.cldc4=cldc4;
			model.cldc5=cldc5;

			Jium.BLL.clerk bll=new Jium.BLL.clerk();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
