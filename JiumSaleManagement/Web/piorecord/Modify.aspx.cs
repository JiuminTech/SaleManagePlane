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
namespace Jium.Web.piorecord
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
		Jium.BLL.piorecord bll=new Jium.BLL.piorecord();
		Jium.Model.piorecord model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtptime.Text=model.ptime;
		this.txtpcode.Text=model.pcode;
		this.txtpcnt.Text=model.pcnt.ToString();
		this.txtpsaleprice.Text=model.psaleprice.ToString();
		this.txtprealprice.Text=model.prealprice.ToString();
		this.txtptype.Text=model.ptype.ToString();
		this.txtpzekou.Text=model.pzekou.ToString();
		this.txtpremark.Text=model.premark;
		this.txtpguestid.Text=model.pguestid.ToString();
		this.txtpsalerid.Text=model.psalerid.ToString();
		this.txtpios1.Text=model.pios1;
		this.txtpios2.Text=model.pios2;
		this.txtpios3.Text=model.pios3;
		this.txtpios4.Text=model.pios4;
		this.txtpios5.Text=model.pios5;
		this.txtpiod1.Text=model.piod1.ToString();
		this.txtpiod2.Text=model.piod2.ToString();
		this.txtpiod3.Text=model.piod3.ToString();
		this.txtpiod5.Text=model.piod5.ToString();
		this.txtpiod4.Text=model.piod4.ToString();
		this.txtpiodc1.Text=model.piodc1.ToString();
		this.txtpiodc2.Text=model.piodc2.ToString();
		this.txtpiodc3.Text=model.piodc3.ToString();
		this.txtpiodc4.Text=model.piodc4.ToString();
		this.txtpiodc5.Text=model.piodc5.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtptime.Text.Trim().Length==0)
			{
				strErr+="ptime不能为空！\\n";	
			}
			if(this.txtpcode.Text.Trim().Length==0)
			{
				strErr+="pcode不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtpcnt.Text))
			{
				strErr+="pcnt格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpsaleprice.Text))
			{
				strErr+="psaleprice格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtprealprice.Text))
			{
				strErr+="prealprice格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtptype.Text))
			{
				strErr+="ptype格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpzekou.Text))
			{
				strErr+="pzekou格式错误！\\n";	
			}
			if(this.txtpremark.Text.Trim().Length==0)
			{
				strErr+="premark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtpguestid.Text))
			{
				strErr+="pguestid格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpsalerid.Text))
			{
				strErr+="psalerid格式错误！\\n";	
			}
			if(this.txtpios1.Text.Trim().Length==0)
			{
				strErr+="pios1不能为空！\\n";	
			}
			if(this.txtpios2.Text.Trim().Length==0)
			{
				strErr+="pios2不能为空！\\n";	
			}
			if(this.txtpios3.Text.Trim().Length==0)
			{
				strErr+="pios3不能为空！\\n";	
			}
			if(this.txtpios4.Text.Trim().Length==0)
			{
				strErr+="pios4不能为空！\\n";	
			}
			if(this.txtpios5.Text.Trim().Length==0)
			{
				strErr+="pios5不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtpiod1.Text))
			{
				strErr+="piod1格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpiod2.Text))
			{
				strErr+="piod2格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpiod3.Text))
			{
				strErr+="piod3格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpiod5.Text))
			{
				strErr+="piod5格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpiod4.Text))
			{
				strErr+="piod4格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpiodc1.Text))
			{
				strErr+="piodc1格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpiodc2.Text))
			{
				strErr+="piodc2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpiodc3.Text))
			{
				strErr+="piodc3格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpiodc4.Text))
			{
				strErr+="piodc4格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpiodc5.Text))
			{
				strErr+="piodc5格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long id=long.Parse(this.lblid.Text);
			string ptime=this.txtptime.Text;
			string pcode=this.txtpcode.Text;
			int pcnt=int.Parse(this.txtpcnt.Text);
			decimal psaleprice=decimal.Parse(this.txtpsaleprice.Text);
			decimal prealprice=decimal.Parse(this.txtprealprice.Text);
			int ptype=int.Parse(this.txtptype.Text);
			decimal pzekou=decimal.Parse(this.txtpzekou.Text);
			string premark=this.txtpremark.Text;
			int pguestid=int.Parse(this.txtpguestid.Text);
			int psalerid=int.Parse(this.txtpsalerid.Text);
			string pios1=this.txtpios1.Text;
			string pios2=this.txtpios2.Text;
			string pios3=this.txtpios3.Text;
			string pios4=this.txtpios4.Text;
			string pios5=this.txtpios5.Text;
			int piod1=int.Parse(this.txtpiod1.Text);
			int piod2=int.Parse(this.txtpiod2.Text);
			int piod3=int.Parse(this.txtpiod3.Text);
			int piod5=int.Parse(this.txtpiod5.Text);
			int piod4=int.Parse(this.txtpiod4.Text);
			decimal piodc1=decimal.Parse(this.txtpiodc1.Text);
			decimal piodc2=decimal.Parse(this.txtpiodc2.Text);
			decimal piodc3=decimal.Parse(this.txtpiodc3.Text);
			decimal piodc4=decimal.Parse(this.txtpiodc4.Text);
			decimal piodc5=decimal.Parse(this.txtpiodc5.Text);


			Jium.Model.piorecord model=new Jium.Model.piorecord();
			model.id=id;
			model.ptime=ptime;
			model.pcode=pcode;
			model.pcnt=pcnt;
			model.psaleprice=psaleprice;
			model.prealprice=prealprice;
			model.ptype=ptype;
			model.pzekou=pzekou;
			model.premark=premark;
			model.pguestid=pguestid;
			model.psalerid=psalerid;
			model.pios1=pios1;
			model.pios2=pios2;
			model.pios3=pios3;
			model.pios4=pios4;
			model.pios5=pios5;
			model.piod1=piod1;
			model.piod2=piod2;
			model.piod3=piod3;
			model.piod5=piod5;
			model.piod4=piod4;
			model.piodc1=piodc1;
			model.piodc2=piodc2;
			model.piodc3=piodc3;
			model.piodc4=piodc4;
			model.piodc5=piodc5;

			Jium.BLL.piorecord bll=new Jium.BLL.piorecord();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
