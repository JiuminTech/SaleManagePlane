using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jium.Web.usertype
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Jium.BLL.usertype bll=new Jium.BLL.usertype();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int level=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(level);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}