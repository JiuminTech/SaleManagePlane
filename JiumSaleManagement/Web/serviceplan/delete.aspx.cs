using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jium.Web.serviceplan
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Jium.BLL.serviceplan bll=new Jium.BLL.serviceplan();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string id= Request.Params["id"];
					bll.Delete(id);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}