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
namespace Xwsw.Web.NMS.consumerservice
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtccode.Text.Trim().Length==0)
			{
				strErr+="ccode不能为空！\\n";	
			}
			if(this.txtcphone.Text.Trim().Length==0)
			{
				strErr+="cphone不能为空！\\n";	
			}
			if(this.txtcstype.Text.Trim().Length==0)
			{
				strErr+="cstype不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcsnum.Text))
			{
				strErr+="csnum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcsleft.Text))
			{
				strErr+="csleft格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtcsiostatus.Text))
			{
				strErr+="csiostatus格式错误！\\n";	
			}
			if(this.txtcstime0.Text.Trim().Length==0)
			{
				strErr+="cstime0不能为空！\\n";	
			}
			if(this.txtcstime1.Text.Trim().Length==0)
			{
				strErr+="cstime1不能为空！\\n";	
			}
			if(this.txtcstime2.Text.Trim().Length==0)
			{
				strErr+="cstime2不能为空！\\n";	
			}
			if(this.txtcstime3.Text.Trim().Length==0)
			{
				strErr+="cstime3不能为空！\\n";	
			}
			if(this.txtcstime4.Text.Trim().Length==0)
			{
				strErr+="cstime4不能为空！\\n";	
			}
			if(this.txtcstime5.Text.Trim().Length==0)
			{
				strErr+="cstime5不能为空！\\n";	
			}
			if(this.txtcstime6.Text.Trim().Length==0)
			{
				strErr+="cstime6不能为空！\\n";	
			}
			if(this.txtcstime7.Text.Trim().Length==0)
			{
				strErr+="cstime7不能为空！\\n";	
			}
			if(this.txtcstime8.Text.Trim().Length==0)
			{
				strErr+="cstime8不能为空！\\n";	
			}
			if(this.txtcstime9.Text.Trim().Length==0)
			{
				strErr+="cstime9不能为空！\\n";	
			}
			if(this.txtcstime10.Text.Trim().Length==0)
			{
				strErr+="cstime10不能为空！\\n";	
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
			if(this.txtcsd1.Text.Trim().Length==0)
			{
				strErr+="csd1不能为空！\\n";	
			}
			if(this.txtcsd2.Text.Trim().Length==0)
			{
				strErr+="csd2不能为空！\\n";	
			}
			if(this.txtcsd3.Text.Trim().Length==0)
			{
				strErr+="csd3不能为空！\\n";	
			}
			if(this.txtcsd4.Text.Trim().Length==0)
			{
				strErr+="csd4不能为空！\\n";	
			}
			if(this.txtcsd5.Text.Trim().Length==0)
			{
				strErr+="csd5不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ccode=this.txtccode.Text;
			string cphone=this.txtcphone.Text;
			string cstype=this.txtcstype.Text;
			int csnum=int.Parse(this.txtcsnum.Text);
			int csleft=int.Parse(this.txtcsleft.Text);
			int csiostatus=int.Parse(this.txtcsiostatus.Text);
			string cstime0=this.txtcstime0.Text;
			string cstime1=this.txtcstime1.Text;
			string cstime2=this.txtcstime2.Text;
			string cstime3=this.txtcstime3.Text;
			string cstime4=this.txtcstime4.Text;
			string cstime5=this.txtcstime5.Text;
			string cstime6=this.txtcstime6.Text;
			string cstime7=this.txtcstime7.Text;
			string cstime8=this.txtcstime8.Text;
			string cstime9=this.txtcstime9.Text;
			string cstime10=this.txtcstime10.Text;
			string css1=this.txtcss1.Text;
			string css2=this.txtcss2.Text;
			string css3=this.txtcss3.Text;
			string css4=this.txtcss4.Text;
			string css5=this.txtcss5.Text;
			string csd1=this.txtcsd1.Text;
			string csd2=this.txtcsd2.Text;
			string csd3=this.txtcsd3.Text;
			string csd4=this.txtcsd4.Text;
			string csd5=this.txtcsd5.Text;

			Jium.Model.consumerservice model=new Jium.Model.consumerservice();
			model.ccode=ccode;
			model.cphone=cphone;
			model.cstype=cstype;
			model.csnum=csnum;
			model.csleft=csleft;
			model.csiostatus=csiostatus;
			model.cstime0=cstime0;
			model.cstime1=cstime1;
			model.cstime2=cstime2;
			model.cstime3=cstime3;
			model.cstime4=cstime4;
			model.cstime5=cstime5;
			model.cstime6=cstime6;
			model.cstime7=cstime7;
			model.cstime8=cstime8;
			model.cstime9=cstime9;
			model.cstime10=cstime10;
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

			Jium.BLL.consumerservice bll=new Jium.BLL.consumerservice();
			bll.Add(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
