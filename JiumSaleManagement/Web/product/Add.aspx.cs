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
namespace Jium.Web.product
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtpcode.Text.Trim().Length==0)
			{
				strErr+="pcode不能为空！\\n";	
			}
			if(this.txtpname.Text.Trim().Length==0)
			{
				strErr+="pname不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpsaleprice.Text))
			{
				strErr+="psaleprice格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtprealprice.Text))
			{
				strErr+="prealprice格式错误！\\n";	
			}
			if(this.txtptype.Text.Trim().Length==0)
			{
				strErr+="ptype不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtpisgroup.Text))
			{
				strErr+="pisgroup格式错误！\\n";	
			}
			if(this.txtpdesc.Text.Trim().Length==0)
			{
				strErr+="pdesc不能为空！\\n";	
			}
			if(this.txtps1.Text.Trim().Length==0)
			{
				strErr+="ps1不能为空！\\n";	
			}
			if(this.txtps2.Text.Trim().Length==0)
			{
				strErr+="ps2不能为空！\\n";	
			}
			if(this.txtps3.Text.Trim().Length==0)
			{
				strErr+="ps3不能为空！\\n";	
			}
			if(this.txtps4.Text.Trim().Length==0)
			{
				strErr+="ps4不能为空！\\n";	
			}
			if(this.txtps5.Text.Trim().Length==0)
			{
				strErr+="ps5不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtpd1.Text))
			{
				strErr+="pd1格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpd2.Text))
			{
				strErr+="pd2格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpd3.Text))
			{
				strErr+="pd3格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpd4.Text))
			{
				strErr+="pd4格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpd5.Text))
			{
				strErr+="pd5格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpdc1.Text))
			{
				strErr+="pdc1格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpdc2.Text))
			{
				strErr+="pdc2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpdc3.Text))
			{
				strErr+="pdc3格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string pcode=this.txtpcode.Text;
			string pname=this.txtpname.Text;
			decimal psaleprice=decimal.Parse(this.txtpsaleprice.Text);
			decimal prealprice=decimal.Parse(this.txtprealprice.Text);
			string ptype=this.txtptype.Text;
			int pisgroup=int.Parse(this.txtpisgroup.Text);
			string pdesc=this.txtpdesc.Text;
			string ps1=this.txtps1.Text;
			string ps2=this.txtps2.Text;
			string ps3=this.txtps3.Text;
			string ps4=this.txtps4.Text;
			string ps5=this.txtps5.Text;
			int pd1=int.Parse(this.txtpd1.Text);
			int pd2=int.Parse(this.txtpd2.Text);
			int pd3=int.Parse(this.txtpd3.Text);
			int pd4=int.Parse(this.txtpd4.Text);
			int pd5=int.Parse(this.txtpd5.Text);
			decimal pdc1=decimal.Parse(this.txtpdc1.Text);
			decimal pdc2=decimal.Parse(this.txtpdc2.Text);
			decimal pdc3=decimal.Parse(this.txtpdc3.Text);

			Jium.Model.product model=new Jium.Model.product();
			model.pcode=pcode;
			model.pname=pname;
			model.psaleprice=psaleprice;
			model.prealprice=prealprice;
			model.ptype=ptype;
			model.pisgroup=pisgroup;
			model.pdesc=pdesc;
			model.ps1=ps1;
			model.ps2=ps2;
			model.ps3=ps3;
			model.ps4=ps4;
			model.ps5=ps5;
			model.pd1=pd1;
			model.pd2=pd2;
			model.pd3=pd3;
			model.pd4=pd4;
			model.pd5=pd5;
			model.pdc1=pdc1;
			model.pdc2=pdc2;
			model.pdc3=pdc3;

			Jium.BLL.product bll=new Jium.BLL.product();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
