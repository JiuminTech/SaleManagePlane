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
namespace Jium.Web.servicerorder
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
		Jium.BLL.servicerorder bll=new Jium.BLL.servicerorder();
		Jium.Model.servicerorder model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtccode.Text=model.ccode;
		this.txtspid.Text=model.spid;
		this.txtspnum.Text=model.spnum.ToString();
		this.txtspspan.Text=model.spspan.ToString();
		this.txtsostatus.Text=model.sostatus.ToString();
		this.txtcreatetime.Text=model.createtime;
		this.txtupdatetime.Text=model.updatetime;
		this.txtupdateby.Text=model.updateby;
		this.txtsos1.Text=model.sos1;
		this.txtsos2.Text=model.sos2;
		this.txtsos3.Text=model.sos3;
		this.txtsos4.Text=model.sos4;
		this.txtsos5.Text=model.sos5;
		this.txtsod1.Text=model.sod1.ToString();
		this.txtsod2.Text=model.sod2.ToString();
		this.txtsod3.Text=model.sod3.ToString();
		this.txtsod4.Text=model.sod4.ToString();
		this.txtsod5.Text=model.sod5.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtccode.Text.Trim().Length==0)
			{
				strErr+="ccode不能为空！\\n";	
			}
			if(this.txtspid.Text.Trim().Length==0)
			{
				strErr+="spid不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtspnum.Text))
			{
				strErr+="spnum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtspspan.Text))
			{
				strErr+="spspan格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsostatus.Text))
			{
				strErr+="sostatus格式错误！\\n";	
			}
			if(this.txtcreatetime.Text.Trim().Length==0)
			{
				strErr+="createtime不能为空！\\n";	
			}
			if(this.txtupdatetime.Text.Trim().Length==0)
			{
				strErr+="updatetime不能为空！\\n";	
			}
			if(this.txtupdateby.Text.Trim().Length==0)
			{
				strErr+="updateby不能为空！\\n";	
			}
			if(this.txtsos1.Text.Trim().Length==0)
			{
				strErr+="sos1不能为空！\\n";	
			}
			if(this.txtsos2.Text.Trim().Length==0)
			{
				strErr+="sos2不能为空！\\n";	
			}
			if(this.txtsos3.Text.Trim().Length==0)
			{
				strErr+="sos3不能为空！\\n";	
			}
			if(this.txtsos4.Text.Trim().Length==0)
			{
				strErr+="sos4不能为空！\\n";	
			}
			if(this.txtsos5.Text.Trim().Length==0)
			{
				strErr+="sos5不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtsod1.Text))
			{
				strErr+="sod1格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsod2.Text))
			{
				strErr+="sod2格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsod3.Text))
			{
				strErr+="sod3格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsod4.Text))
			{
				strErr+="sod4格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsod5.Text))
			{
				strErr+="sod5格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long id=long.Parse(this.lblid.Text);
			string ccode=this.txtccode.Text;
			string spid=this.txtspid.Text;
			int spnum=int.Parse(this.txtspnum.Text);
			int spspan=int.Parse(this.txtspspan.Text);
			int sostatus=int.Parse(this.txtsostatus.Text);
			string createtime=this.txtcreatetime.Text;
			string updatetime=this.txtupdatetime.Text;
			string updateby=this.txtupdateby.Text;
			string sos1=this.txtsos1.Text;
			string sos2=this.txtsos2.Text;
			string sos3=this.txtsos3.Text;
			string sos4=this.txtsos4.Text;
			string sos5=this.txtsos5.Text;
			int sod1=int.Parse(this.txtsod1.Text);
			int sod2=int.Parse(this.txtsod2.Text);
			int sod3=int.Parse(this.txtsod3.Text);
			int sod4=int.Parse(this.txtsod4.Text);
			int sod5=int.Parse(this.txtsod5.Text);


			Jium.Model.servicerorder model=new Jium.Model.servicerorder();
			model.id=id;
			model.ccode=ccode;
			model.spid=spid;
			model.spnum=spnum;
			model.spspan=spspan;
			model.sostatus=sostatus;
			model.createtime=createtime;
			model.updatetime=updatetime;
			model.updateby=updateby;
			model.sos1=sos1;
			model.sos2=sos2;
			model.sos3=sos3;
			model.sos4=sos4;
			model.sos5=sos5;
			model.sod1=sod1;
			model.sod2=sod2;
			model.sod3=sod3;
			model.sod4=sod4;
			model.sod5=sod5;

			Jium.BLL.servicerorder bll=new Jium.BLL.servicerorder();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
