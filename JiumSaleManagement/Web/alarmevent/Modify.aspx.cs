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
namespace Jium.Web.alarmevent
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
		Jium.BLL.alarmevent bll=new Jium.BLL.alarmevent();
		Jium.Model.alarmevent model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtalarmname.Text=model.alarmname;
		this.txtalarmdesc.Text=model.alarmdesc;
		this.txtcreatetime.Text=model.createtime;
		this.txtupdatetime.Text=model.updatetime;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtalarmname.Text.Trim().Length==0)
			{
				strErr+="alarmname不能为空！\\n";	
			}
			if(this.txtalarmdesc.Text.Trim().Length==0)
			{
				strErr+="alarmdesc不能为空！\\n";	
			}
			if(this.txtcreatetime.Text.Trim().Length==0)
			{
				strErr+="createtime不能为空！\\n";	
			}
			if(this.txtupdatetime.Text.Trim().Length==0)
			{
				strErr+="updatetime不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long id=long.Parse(this.lblid.Text);
			string alarmname=this.txtalarmname.Text;
			string alarmdesc=this.txtalarmdesc.Text;
			string createtime=this.txtcreatetime.Text;
			string updatetime=this.txtupdatetime.Text;


			Jium.Model.alarmevent model=new Jium.Model.alarmevent();
			model.id=id;
			model.alarmname=alarmname;
			model.alarmdesc=alarmdesc;
			model.createtime=createtime;
			model.updatetime=updatetime;

			Jium.BLL.alarmevent bll=new Jium.BLL.alarmevent();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
