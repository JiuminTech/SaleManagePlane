using Jium.Ctrl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jium.Web.piorecord
{
    public partial class Sale : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearchConsumer_Click(object sender, EventArgs e)
        {
            Jium.BLL.consumer bll = new Jium.BLL.consumer();
            StringBuilder strWhere = new StringBuilder();
            if (txtCphone.Text.Trim() != "")
            {
#warning 代码生成警告：请修改 keywordField 为需要匹配查询的真实字段名称
                strWhere.AppendFormat("cphone = '{0}'", txtCphone.Text.Trim());
            }
            else
            {
                /// new user?
                return;
            }
            strWhere.Append(" and csd5=5 order by clevel desc");
            var consumers= bll.GetModelList(strWhere.ToString());
            if(consumers.Count ==0)
            {
                Maticsoft.Common.MessageBox.Show(this, "账户信息不存在，请重新输入");
                return;
            }
            txtCcode.Text = consumers[0].ccode;
            txtCname.Text = consumers[0].cname;
            txtSumMoney.Text = consumers[0].csum.ToString();
            LinkButtonBuyHistory.PostBackUrl = string.Format("~/piorecord/list.aspx?id={0}", consumers[0].ccode);
            LinkButtonBuyHistory.Enabled = true;
            LinkButtonServiceHistory.PostBackUrl = string.Format("~/consumerservice/list.aspx?id={0}", consumers[0].ccode);
            LinkButtonServiceHistory.Enabled = true;
        }

  
        protected void ButtonAllZekou_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < gridViewBuy.Rows.Count; i++)
            {               
                gridViewBuy.Rows[i].Cells[6].Text = txtZekou.Text;          ;
                
            }
            if (!string.IsNullOrWhiteSpace(txtSumTotal.Text) && !string.IsNullOrWhiteSpace(txtZekou.Text))
            {
                decimal sum = decimal.Parse(txtSumTotal.Text) * decimal.Parse(txtZekou.Text);
                txtSumReal.Text = sum.ToString();
            }
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            GetSelIDlist();

        }
        protected void btnPlibAdd_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var index = ((GridViewRow)btn.Parent.Parent).RowIndex;
            var sNum = gridViewLib.Rows[index].Cells[5].Text;

            var lst = new List<Jium.Model.piorecord>();            
            //#warning 代码生成警告：请检查确认Cells的列索引是否正确
            if (gridViewLib.DataKeys[index].Value != null)
            {
                var model = new Jium.Model.piorecord();
                model.pcode = gridViewLib.Rows[index].Cells[1].Text;// i.ToString();
                model.pios3 = gridViewLib.Rows[index].Cells[2].Text;// gridViewLib.Rows[i].Cells[3].ToString();                        
                model.pzekou = 1;
                model.pcnt = 1;
                model.piod1 = 0;
                string where = string.Format("pcode='{0}'", model.pcode);
                var productBll = new Jium.BLL.product();
                var lstProduct = productBll.GetModelList(where);
                if (lstProduct.Count > 0)
                {
                    model.psaleprice = lstProduct.FirstOrDefault().psaleprice;
                    model.piod1 = lstProduct.FirstOrDefault().pd1;
                    model.pios4 = lstProduct.FirstOrDefault().ps1;
                }
                lst.Add(model);

            }

            for (int i = 0; i < gridViewBuy.Rows.Count; i++)
            {
                var model = new Jium.Model.piorecord();
                model.pcode = gridViewBuy.Rows[i].Cells[0].Text;
                model.pios3 = gridViewBuy.Rows[i].Cells[1].Text;
                model.psaleprice = decimal.Parse(gridViewBuy.Rows[i].Cells[3].Text);
                model.pcnt = int.Parse(gridViewBuy.Rows[i].Cells[5].Text);
                model.pzekou = decimal.Parse(gridViewBuy.Rows[i].Cells[6].Text);
                lst.Add(model);
            }

            gridViewBuy.DataSource = lst;
            var sumTotal = lst.Sum(e1 => e1.pcnt * e1.psaleprice);
            var sumReal = lst.Sum(e1 => e1.pcnt * e1.psaleprice * e1.pzekou);
            var zekou = sumTotal == 0 ? 1 : sumReal / sumTotal;

            txtSumTotal.Text = sumTotal.ToString();
            txtSumReal.Text = sumReal.ToString();
            txtZekou.Text = zekou.ToString();


            gridViewBuy.DataBind();


        }

        protected void btnSearchProduct_Click(object sender, EventArgs e)
        {
            BindProductData();
        }

        public void BindProductData()
        {            
            #region
            //if (!Context.User.Identity.IsAuthenticated)
            //{
            //    return;
            //}
            //AccountsPrincipal user = new AccountsPrincipal(Context.User.Identity.Name);
            //if (user.HasPermissionID(PermId_Modify))
            //{
            //    gridView.Columns[6].Visible = true;
            //}
            //if (user.HasPermissionID(PermId_Delete))
            //{
            //    gridView.Columns[7].Visible = true;
            //}
            #endregion

            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            if (txtKeyword.Text.Trim() != "")
            {
#warning 代码生成警告：请修改 keywordField 为需要匹配查询的真实字段名称
                strWhere.AppendFormat(" (pname like '%{0}%' or pcode like '%{0}%' or pdesc like '%{0}%' or pls1 like '%{0}%')", txtKeyword.Text.Trim());
            }
            Jium.BLL.plib bll = new Jium.BLL.plib();
            ds = bll.GetList(strWhere.ToString());
            gridViewLib.DataSource = ds;
            gridViewLib.DataBind();
        }

        private string GetSelIDlist()
        {
            var lst=new List<Jium.Model.piorecord>();
            string idlist = "";
            bool BxsChkd = false;
            var productBll = new Jium.BLL.product();
            for (int i = 0; i < gridViewLib.Rows.Count; i++)
            {
                CheckBox ChkBxItem = (CheckBox)gridViewLib.Rows[i].FindControl("SaleThis");
                if (ChkBxItem != null && ChkBxItem.Checked)
                {
                    BxsChkd = true;
                    //#warning 代码生成警告：请检查确认Cells的列索引是否正确
                    if (gridViewLib.DataKeys[i].Value != null)
                    {                       
                        var model = new Jium.Model.piorecord();
                        model.pcode = gridViewLib.Rows[i].Cells[1].Text;// i.ToString();
                        model.pios3 = gridViewLib.Rows[i].Cells[2].Text;// gridViewLib.Rows[i].Cells[3].ToString();                        
                        model.pzekou = 1;
                        model.pcnt = 1;
                        model.piod1 = 0;
                        string where = string.Format("pcode='{0}'", model.pcode);
                        var lstProduct = productBll.GetModelList(where);
                        if (lstProduct.Count > 0)
                        {
                            model.psaleprice = lstProduct.FirstOrDefault().psaleprice;
                            model.piod1 = lstProduct.FirstOrDefault().pd1;
                            model.pios4 = lstProduct.FirstOrDefault().ps1;
                        }
                        lst.Add(model);
                        idlist += gridViewLib.DataKeys[i].Value.ToString() + ",";
                    }
                }
            }
            if (BxsChkd)
            {
                idlist = idlist.Substring(0, idlist.LastIndexOf(","));
            }
            
            for(int i=0; i< gridViewBuy.Rows.Count; i++)
            {
                var model = new Jium.Model.piorecord();
                model.pcode = gridViewBuy.Rows[i].Cells[0].Text;
                model.pios3= gridViewBuy.Rows[i].Cells[1].Text;
                model.psaleprice = decimal.Parse(gridViewBuy.Rows[i].Cells[3].Text);
                model.pcnt = int.Parse(gridViewBuy.Rows[i].Cells[5].Text);
                model.pzekou = decimal.Parse(gridViewBuy.Rows[i].Cells[6].Text);
                lst.Add(model);
            }
            //if (gridViewBuy.DataSource == null)
            //{
                gridViewBuy.DataSource = lst;
                var sumTotal = lst.Sum(e => e.pcnt * e.psaleprice);
                var sumReal  = lst.Sum(e => e.pcnt * e.psaleprice*e.pzekou);
            var zekou = sumTotal == 0 ? 1 : sumReal / sumTotal;
            //}
            //else
            //{
            //    var lstBuy = (List<Jium.Model.piorecord>)gridViewBuy.DataSource;
            //    lstBuy.AddRange(lst);
            //    gridViewBuy.DataSource = lstBuy;
            //    sum = lstBuy.Sum(e => e.pcnt * e.psaleprice);
            //}
            txtSumTotal.Text = sumTotal.ToString();
            txtSumReal.Text = sumReal.ToString();
            txtZekou.Text = zekou.ToString();

            
            gridViewBuy.DataBind();
            return idlist;
        }




        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridViewLib.PageIndex = e.NewPageIndex;
            BindProductData();
        }
        protected void gridView_OnRowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //e.Row.Cells[0].Text = "<input id='Checkbox2' type='checkbox' onclick='CheckAll()'/><label></label>";
            }
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

        protected void gridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //#warning 代码生成警告：请检查确认真实主键的名称和类型是否正确
            //int ID = (int)gridView.DataKeys[e.RowIndex].Value;
            //bll.Delete(ID);
            //gridView.OnBind();
        }

        protected void gridView_BuyDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //#warning 代码生成警告：请检查确认真实主键的名称和类型是否正确
            gridViewBuy.DeleteRow(e.RowIndex);
            //int ID = (int)gridView.DataKeys[e.RowIndex].Value;
            //bll.Delete(ID);
            //gridView.OnBind();
        }
        //protected void gridView_BuyAdd(object sender, GridViewRowEventArgs e)
         protected void btnProductAdd_Click(object sender, EventArgs e)
        {
            //#warning 代码生成警告：请检查确认真实主键的名称和类型是否正确
            var btn = (Button)sender;
            var index = ((GridViewRow)btn.Parent.Parent).RowIndex;
            var sNum = gridViewBuy.Rows[index].Cells[5].Text;
            if (string.IsNullOrWhiteSpace(sNum))
                gridViewBuy.Rows[index].Cells[5].Text = "1";
            else
            {
                int cnt = int.Parse(gridViewBuy.Rows[index].Cells[5].Text)+1;
                gridViewBuy.Rows[index].Cells[5].Text = cnt.ToString();
                var newsum = decimal.Parse(txtSumTotal.Text) + decimal.Parse(gridViewBuy.Rows[index].Cells[3].Text);
                txtSumTotal.Text = newsum.ToString();
                var realsum = decimal.Parse(txtSumReal.Text) +decimal.Parse(gridViewBuy.Rows[index].Cells[3].Text) * decimal.Parse(gridViewBuy.Rows[index].Cells[6].Text);
                txtSumReal.Text = realsum.ToString();
            }

            //gridViewBuy.DataBind();
        }
        protected void btnProductPlus_Click(object sender, EventArgs e)
        {
            //#warning 代码生成警告：请检查确认真实主键的名称和类型是否正确
            var btn = (Button)sender;
            var index = ((GridViewRow)btn.Parent.Parent).RowIndex;

            //var sNum = e.Row.Cells[3].Text;
            //if (string.IsNullOrWhiteSpace(sNum) || sNum.Trim() == "1")
               //gridViewBuy.DeleteRow(index);
            //else
            {
                int cnt = int.Parse(gridViewBuy.Rows[index].Cells[5].Text) - 1;
                gridViewBuy.Rows[index].Cells[5].Text = cnt.ToString();

                var newsum = decimal.Parse(txtSumTotal.Text) - decimal.Parse(gridViewBuy.Rows[index].Cells[3].Text);
                txtSumTotal.Text = newsum.ToString();
                var realsum = decimal.Parse(txtSumReal.Text) - decimal.Parse(gridViewBuy.Rows[index].Cells[3].Text) * decimal.Parse(gridViewBuy.Rows[index].Cells[6].Text);
                txtSumReal.Text = realsum.ToString();
            }
        }
        protected void btnConfirmSale_Click(object sender, EventArgs e)
        {
            try
            {
                //#warning 代码生成警告：请检查确认真实主键的名称和类型是否正确
                string orderid = DateTime.Now.ToString("yyyyMMddHHmmss");
                var lstModel = new List<Jium.Model.piorecord>();

                for (int i = 0; i < gridViewBuy.Rows.Count; i++)
                {
                    var model = new Jium.Model.piorecord();
                    model.pcode = gridViewBuy.Rows[i].Cells[0].Text;
                    model.pios3 = gridViewBuy.Rows[i].Cells[1].Text;
                    model.psaleprice = decimal.Parse(gridViewBuy.Rows[i].Cells[3].Text);
                    model.pcnt = int.Parse(gridViewBuy.Rows[i].Cells[5].Text);
                    model.pzekou = decimal.Parse(gridViewBuy.Rows[i].Cells[6].Text);
                    model.psalerid = 0;
                    model.ptype = (int)PRODUCT_IO_TYPE.SALE; ;
                    model.ptime = orderid;
                    model.pguestid = int.Parse(txtCcode.Text);
                    var txtNum = gridViewBuy.Rows[i].Cells[4].Text.Trim();
                    model.piod1 = string.IsNullOrWhiteSpace(txtNum.Replace("&nbsp;", "")) ? 0 : int.Parse(gridViewBuy.Rows[i].Cells[4].Text);//服务
                    model.pios4 = gridViewBuy.Rows[i].Cells[2].Text.Replace("&nbsp;", "");//单位
                    model.piod5 = 5;                                                                      //model.pios5 = cells[i, 0].StringValue.Trim();//系列
                    model.pios1 = "销售";
                    lstModel.Add(model);
                }
                ERR_CODE iRes = ERR_CODE.SUCCESS;
                ///事务回滚机制？？？
                var bllCustomeService = new Jium.BLL.consumerservice();
                foreach (var model in lstModel)
                {
                    if (!Ctrl.piorecord.AddPiorecord(model))
                    {
                        iRes = ERR_CODE.FAIL;
                        break;
                    }
                    if (model.piod1 > 0)//add service for guset
                    {
                        var consumerservice = new Jium.Model.consumerservice();
                        consumerservice.ccode = model.pguestid.ToString();
                        consumerservice.csnum = model.piod1 ?? 0;
                        consumerservice.cstype = model.pios3;
                        consumerservice.csleft = model.piod1 ?? 0;
                        consumerservice.csiostatus = 0;
                        consumerservice.cstime0 = orderid;
                        consumerservice.csd5 = "5";
                        bllCustomeService.Add(consumerservice);
                    }
                }
                //update guest info
                var consumerBll = new Jium.BLL.consumer();
                var lstConsumer = consumerBll.GetModelList(string.Format("ccode='{0}' and csd5=5", txtCcode.Text.Trim()));
                if (lstConsumer.Count == 0)
                {
                    ///error 
                    ///return;
                }
                lstConsumer[0].css1 = orderid;
                lstConsumer[0].csum += decimal.Parse(txtSumReal.Text);
                lstConsumer[0].clevel = Jium.BLL.consumer.getLevelByConsume(lstConsumer[0].csum).ToString();//get from csum
                consumerBll.Update(lstConsumer[0]);

                Maticsoft.Common.MessageBox.ShowAndRedirects(this, "操作完成！", "/default.aspx");
            }
            catch(Exception ex)
            {
                Maticsoft.Common.MessageBox.Show(this, "系统错误："+ex.Message);
                return;
            }
        }
        
        protected void btnProductZekou_Click(object sender, EventArgs e)
        {
            //#warning 代码生成警告：请检查确认真实主键的名称和类型是否正确
            var btn = (Button)sender;
            var index = ((GridViewRow)btn.Parent.Parent).RowIndex;

            //var sNum = e.Row.Cells[3].Text;
            //if (string.IsNullOrWhiteSpace(sNum) || sNum.Trim() == "1")
            //gridViewBuy.DeleteRow(index);
            //else
            {
                int cnt = int.Parse(gridViewBuy.Rows[index].Cells[5].Text) - 1;
                gridViewBuy.Rows[index].Cells[5].Text = cnt.ToString();
            }
        }
        protected void btnProductZekouUpdate_Click(object sender, EventArgs e)
        {
            //#warning 代码生成警告：请检查确认真实主键的名称和类型是否正确
            var btn = (Button)sender;
            var index = ((GridViewRow)btn.Parent.Parent).RowIndex;
        }


        protected void btnProductClear_Click(object sender, EventArgs e)
        {
            //#warning 代码生成警告：请检查确认真实主键的名称和类型是否正确
            var btn = (Button)sender;
            

            gridViewBuy.DataSource = new List<Jium.Model.piorecord>();
            txtSumTotal.Text = "";
            txtSumReal.Text = "";
            txtZekou.Text = "";
            gridViewBuy.DataBind();
        }
        protected void btnProductHold_Click(object sender, EventArgs e)
        {
            //#warning 代码生成警告：请检查确认真实主键的名称和类型是否正确
            var btn = (Button)sender;
            
                        
        }
    }
}