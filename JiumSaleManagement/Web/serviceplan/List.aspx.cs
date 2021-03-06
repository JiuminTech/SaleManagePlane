﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using Maticsoft.Common;
using System.Drawing;
using LTP.Accounts.Bus;
namespace Jium.Web.serviceplan
{
    public partial class List : Page
    {  
		Jium.BLL.serviceplan bll = new Jium.BLL.serviceplan();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gridView.BorderColor = ColorTranslator.FromHtml(Application[Session["Style"].ToString() + "xtable_bordercolorlight"].ToString());
                gridView.HeaderStyle.BackColor = ColorTranslator.FromHtml(Application[Session["Style"].ToString() + "xtable_titlebgcolor"].ToString());
                btnDelete.Attributes.Add("onclick", "return confirm(\"你确认要删除吗？\")");
                BindData();
            }
        }
        
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindData();
        }
        private static int DAY_TIMES = 12;
        private static int MINUTE_TIME_LEN = 60;
        private static int WORKER_NUM = 4;
        protected void btnBatchAdd_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text.Trim() == "" )
            {
                MessageBox.Show(this, "请输入要批量增加的日期数字，今天后第几日");
                return;                
            }
            int index = int.Parse(txtKeyword.Text.Trim());

            int times = DAY_TIMES;
            int totalnum = WORKER_NUM;
            int nexttotal = WORKER_NUM;
            Jium.BLL.serviceplan bll = new Jium.BLL.serviceplan();
            DateTime pdate = DateTime.Now.AddDays(index).Date.AddHours(8);
            
            for (int i=0;i< times; i++)
            {
                Jium.Model.serviceplan model = new Jium.Model.serviceplan();
                model.id = pdate.AddMinutes(i* MINUTE_TIME_LEN).ToString("yyyyMMddHHmm");
                model.plandate = pdate.AddMinutes(i * MINUTE_TIME_LEN).ToString("yyyy-MM-dd");
                model.plantime = pdate.AddMinutes(i * MINUTE_TIME_LEN).ToString("HH:mm");
                model.pss1= pdate.AddMinutes(i * MINUTE_TIME_LEN + MINUTE_TIME_LEN).ToString("HH:mm");
                model.totalnum = totalnum;
                model.leftnum = totalnum;
                model.nexttotal = nexttotal;
                model.nextleft = nexttotal;
                model.nextid = i==times-1?"0": pdate.AddMinutes(i * MINUTE_TIME_LEN + MINUTE_TIME_LEN).ToString("yyyyMMddHHmm"); 
                bll.Add(model);
            }
            txtKeyword.Text = "";
            BindData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string idlist = GetSelIDlist();
            if (idlist.Trim().Length == 0) 
                return;
            bll.DeleteList(idlist);
            BindData();
        }
        
        #region gridView
                        
        public void BindData()
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
                strWhere.AppendFormat("id like '%{0}%'", txtKeyword.Text.Trim());
            }            
            ds = bll.GetList(strWhere.ToString());            
            gridView.DataSource = ds;
            gridView.DataBind();
        }

        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridView.PageIndex = e.NewPageIndex;
            BindData();
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
                LinkButton linkbtnDel = (LinkButton)e.Row.FindControl("LinkButton1");
                linkbtnDel.Attributes.Add("onclick", "return confirm(\"你确认要删除吗\")");
                
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

        private string GetSelIDlist()
        {
            string idlist = "";
            bool BxsChkd = false;
            for (int i = 0; i < gridView.Rows.Count; i++)
            {
                CheckBox ChkBxItem = (CheckBox)gridView.Rows[i].FindControl("DeleteThis");
                if (ChkBxItem != null && ChkBxItem.Checked)
                {
                    BxsChkd = true;
                    //#warning 代码生成警告：请检查确认Cells的列索引是否正确
                    if (gridView.DataKeys[i].Value != null)
                    {                        
                        idlist += gridView.DataKeys[i].Value.ToString() + ",";
                    }
                }
            }
            if (BxsChkd)
            {
                idlist = idlist.Substring(0, idlist.LastIndexOf(","));
            }
            return idlist;
        }

        #endregion





    }
}
