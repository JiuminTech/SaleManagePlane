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
namespace Jium.Web.userlog
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
		Jium.BLL.userlog bll=new Jium.BLL.userlog();
		Jium.Model.userlog model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtusercode.Text=model.usercode;
		this.txtuseraddr.Text=model.useraddr;
		this.txtopertype.Text=model.opertype;
		this.txtoperobject.Text=model.operobject;
		this.txtopervalue.Text=model.opervalue;
		this.txtoperdesc.Text=model.operdesc;
		this.txtopertime.Text=model.opertime;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtusercode.Text.Trim().Length==0)
			{
				strErr+="usercode不能为空！\\n";	
			}
			if(this.txtuseraddr.Text.Trim().Length==0)
			{
				strErr+="useraddr不能为空！\\n";	
			}
			if(this.txtopertype.Text.Trim().Length==0)
			{
				strErr+="opertype不能为空！\\n";	
			}
			if(this.txtoperobject.Text.Trim().Length==0)
			{
				strErr+="operobject不能为空！\\n";	
			}
			if(this.txtopervalue.Text.Trim().Length==0)
			{
				strErr+="opervalue不能为空！\\n";	
			}
			if(this.txtoperdesc.Text.Trim().Length==0)
			{
				strErr+="operdesc不能为空！\\n";	
			}
			if(this.txtopertime.Text.Trim().Length==0)
			{
				strErr+="opertime不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long id=long.Parse(this.lblid.Text);
			string usercode=this.txtusercode.Text;
			string useraddr=this.txtuseraddr.Text;
			string opertype=this.txtopertype.Text;
			string operobject=this.txtoperobject.Text;
			string opervalue=this.txtopervalue.Text;
			string operdesc=this.txtoperdesc.Text;
			string opertime=this.txtopertime.Text;


			Jium.Model.userlog model=new Jium.Model.userlog();
			model.id=id;
			model.usercode=usercode;
			model.useraddr=useraddr;
			model.opertype=opertype;
			model.operobject=operobject;
			model.opervalue=opervalue;
			model.operdesc=operdesc;
			model.opertime=opertime;

			Jium.BLL.userlog bll=new Jium.BLL.userlog();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
