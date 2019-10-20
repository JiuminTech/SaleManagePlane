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
namespace Jium.Web.plib
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			//if(this.txtid.Text.Trim().Length==0)
			//{
			//	strErr+="id不能为空！\\n";	
			//}
			if(this.txtpcode.Text.Trim().Length==0)
			{
				strErr+="pcode不能为空！\\n";	
			}
			if(this.txtpname.Text.Trim().Length==0)
			{
				strErr+="pname不能为空！\\n";	
			}
			if(this.txtpdesc.Text.Trim().Length==0)
			{
				strErr+="pdesc不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtpleftcnt.Text))
			{
				strErr+="pleftcnt格式错误！\\n";	
			}
			//if(this.txtplupdatetime.Text.Trim().Length==0)
			//{
			//	strErr+="plupdatetime不能为空！\\n";	
			//}
			if(!PageValidate.IsNumber(txtpsumcnt.Text))
			{
				strErr+="psumcnt格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpsalecnt.Text))
			{
				strErr+="psalecnt格式错误！\\n";	
			}
			//if(this.txtpls1.Text.Trim().Length==0)
			//{
			//	strErr+="pls1不能为空！\\n";	
			//}
			//if(this.txtpls2.Text.Trim().Length==0)
			//{
			//	strErr+="pls2不能为空！\\n";	
			//}
			//if(this.txtpls3.Text.Trim().Length==0)
			//{
			//	strErr+="pls3不能为空！\\n";	
			//}
			//if(this.txtpls4.Text.Trim().Length==0)
			//{
			//	strErr+="pls4不能为空！\\n";	
			//}
			//if(this.txtpls5.Text.Trim().Length==0)
			//{
			//	strErr+="pls5不能为空！\\n";	
			//}
			//if(!PageValidate.IsNumber(txtpld1.Text))
			//{
			//	strErr+="pld1格式错误！\\n";	
			//}
			//if(!PageValidate.IsNumber(txtpld2.Text))
			//{
			//	strErr+="pld2格式错误！\\n";	
			//}
			//if(!PageValidate.IsNumber(txtpld3.Text))
			//{
			//	strErr+="pld3格式错误！\\n";	
			//}
			//if(!PageValidate.IsNumber(txtpld4.Text))
			//{
			//	strErr+="pld4格式错误！\\n";	
			//}
			//if(!PageValidate.IsNumber(txtpld5.Text))
			//{
			//	strErr+="pld5格式错误！\\n";	
			//}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string id= this.txtpcode.Text; //this.txtid.Text;
			string pcode=this.txtpcode.Text;
			string pname=this.txtpname.Text;
			string pdesc=this.txtpdesc.Text;
			int pleftcnt=int.Parse(this.txtpleftcnt.Text);
			string plupdatetime = DateTime.Now.ToString("yyyyMMddHHmmss"); ;
			int psumcnt=int.Parse(this.txtpsumcnt.Text);
			int psalecnt=int.Parse(this.txtpsalecnt.Text);
			//string pls1=this.txtpls1.Text;
			//string pls2=this.txtpls2.Text;
			//string pls3=this.txtpls3.Text;
			//string pls4=this.txtpls4.Text;
			//string pls5=this.txtpls5.Text;
			//int pld1=int.Parse(this.txtpld1.Text);
			//int pld2=int.Parse(this.txtpld2.Text);
			//int pld3=int.Parse(this.txtpld3.Text);
			//int pld4=int.Parse(this.txtpld4.Text);
			//int pld5=int.Parse(this.txtpld5.Text);

			Jium.Model.plib model=new Jium.Model.plib();
			model.id= long.Parse(id);
			model.pcode=pcode;
			model.pname=pname;
			model.pdesc=pdesc;
			model.pleftcnt=pleftcnt;
			model.plupdatetime=plupdatetime;
			model.psumcnt=psumcnt;
			model.psalecnt=psalecnt;
			//model.pls1=pls1;
			//model.pls2=pls2;
			//model.pls3=pls3;
			//model.pls4=pls4;
			//model.pls5=pls5;
			//model.pld1=pld1;
			//model.pld2=pld2;
			//model.pld3=pld3;
			//model.pld4=pld4;
			//model.pld5=pld5;

			Jium.BLL.plib bll=new Jium.BLL.plib();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
