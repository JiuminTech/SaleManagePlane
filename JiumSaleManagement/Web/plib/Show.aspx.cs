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
namespace Jium.Web.plib
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				long id = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					id=(Convert.ToInt64(Request.Params["id0"]));
				}
				string pcode = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					pcode= Request.Params["id1"];
                    strid = pcode;

                }
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(id,pcode);
			}
		}
		
	private void ShowInfo(long id,string pcode)
	{
		Jium.BLL.plib bll=new Jium.BLL.plib();
		Jium.Model.plib model=bll.GetModel(id,pcode);
		//this.lblid.Text=model.id.ToString();
		this.lblpcode.Text=model.pcode;
		this.lblpname.Text=model.pname;
		this.lblpdesc.Text=model.pdesc;
		this.lblpleftcnt.Text=model.pleftcnt.ToString();
		this.lblplupdatetime.Text=model.plupdatetime;
		this.lblpsumcnt.Text=model.psumcnt.ToString();
		this.lblpsalecnt.Text=model.psalecnt.ToString();
		this.lblpls1.Text=model.pls1;
		this.lblpls2.Text=model.pls2;
		//this.lblpls3.Text=model.pls3;
		//this.lblpls4.Text=model.pls4;
		//this.lblpls5.Text=model.pls5;
		this.lblpld1.Text=model.pld1.ToString();
            //this.lblpld2.Text=model.pld2.ToString();
            //this.lblpld3.Text=model.pld3.ToString();
            //this.lblpld4.Text=model.pld4.ToString();
            //this.lblpld5.Text=model.pld5.ToString();
            BindData(this.lblpcode.Text);

	}

        public void BindData(string pcode)
        {

            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();

            strWhere.AppendFormat(" pcode = '{0}'", pcode);
            Jium.BLL.piorecord bll = new Jium.BLL.piorecord();
            ds = bll.GetList(strWhere.ToString());
            gridView.DataSource = ds;
            gridView.DataBind();
        }
        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridView.PageIndex = e.NewPageIndex;
            BindData(this.lblpcode.Text);
        }

        protected void gridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Attributes.Add("style", "background:#FFF");
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //LinkButton linkbtnDel = (LinkButton)e.Row.FindControl("LinkButton1");
                //linkbtnDel.Attributes.Add("onclick", "return confirm(\"你确认要删除吗\")");

                //object obj1 = DataBinder.Eval(e.Row.DataItem, "Levels");
                //if ((obj1 != null) && ((obj1.ToString() != "")))
                //{
                //    e.Row.Cells[1].Text = obj1.ToString();
                //}

            }
        }
        protected void gridView_OnRowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //e.Row.Cells[0].Text = "<input id='Checkbox2' type='checkbox' onclick='CheckAll()'/><label></label>";
            }
        }

    }
}
