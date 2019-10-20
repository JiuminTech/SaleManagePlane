using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jium.Web.plib
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Jium.BLL.plib bll=new Jium.BLL.plib();
				long id = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					id=(Convert.ToInt64(Request.Params["id0"]));
				}
				string pcode = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					pcode= Request.Params["id1"];
				}
				#warning 代码生成提示：删除页面,请检查确认传递过来的参数是否正确
				// bll.Delete(id,pcode);
			}

        }
    }
}