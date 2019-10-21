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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var bres = true;
                do
                {
                    string strErr = "";
                    //if(this.txtptime.Text.Trim().Length==0)
                    //{
                    //	strErr+="ptime不能为空！\\n";	
                    //}
                    if (this.txtpcode.Text.Trim().Length == 0)
                    {
                        strErr += "pcode不能为空！\\n";
                    }
                    if (!PageValidate.IsNumber(txtpcnt.Text))
                    {
                        strErr += "pcnt格式错误！\\n";
                    }
                    if (!PageValidate.IsNumber(txtpsaleprice.Text) && !PageValidate.IsDecimal(txtpsaleprice.Text))
                    {
                        strErr += "psaleprice格式错误！\\n";
                    }
                    if (!PageValidate.IsNumber(txtprealprice.Text) && !PageValidate.IsDecimal(txtprealprice.Text))
                    {
                        strErr += "prealprice格式错误！\\n";
                    }
                    if (!PageValidate.IsNumber(/*txtptype.Text*/ dropptype.SelectedValue))
                    {
                        strErr += "ptype格式错误！\\n";
                    }
                    if (!PageValidate.IsNumber(txtpzekou.Text) && !PageValidate.IsDecimal(txtpzekou.Text))
                    {
                        strErr += "pzekou格式错误！\\n";
                    }
                    //if(this.txtpremark.Text.Trim().Length==0)
                    //{
                    //	strErr+="premark不能为空！\\n";	
                    //}
                    if (!PageValidate.IsNumber(txtpguestid.Text))
                    {
                        strErr += "pguestid格式错误！\\n";
                    }
                    if (!PageValidate.IsNumber(txtpsalerid.Text))
                    {
                        strErr += "psalerid格式错误！\\n";
                    }

                    if (this.txtpios1.Text.Trim().Length == 0)
                    {
                        strErr += "pios1不能为空！\\n";
                    }
                    if (this.txtpios2.Text.Trim().Length == 0)
                    {
                        strErr += "pios2不能为空！\\n";
                    }
                    
                    //if(this.txtpios3.Text.Trim().Length==0)
                    //{
                    //    strErr+="pios3不能为空！\\n";	
                    //}
                    /*
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
                    */

                    if (strErr != "")
                    {
                        MessageBox.Show(this, strErr);
                        return;
                    }
                    string ptime = DateTime.Now.ToString("yyyyMMddHHmmss");// ,this.txtptime.Text;
                    string pcode = this.txtpcode.Text;
                    int pcnt = int.Parse(this.txtpcnt.Text);
                    decimal psaleprice = decimal.Parse(this.txtpsaleprice.Text);
                    decimal prealprice = decimal.Parse(this.txtprealprice.Text);
                    int ptype = int.Parse(/*txtptype.Text*/ dropptype.SelectedValue);
                    decimal pzekou = decimal.Parse(this.txtpzekou.Text);
                    string premark = this.txtpremark.Text;
                    int pguestid = int.Parse(this.txtpguestid.Text);
                    int psalerid = int.Parse(this.txtpsalerid.Text);
                    string pios1 = this.txtpios1.Text;
                    string pios2 = this.txtpios2.Text;
                    string pios3=this.txtpios3.Text;
                    //string pios4=this.txtpios4.Text;
                    //string pios5=this.txtpios5.Text;
                    //int piod1=int.Parse(this.txtpiod1.Text);
                    //int piod2=int.Parse(this.txtpiod2.Text);
                    //int piod3=int.Parse(this.txtpiod3.Text);
                    //int piod5=int.Parse(this.txtpiod5.Text);
                    //int piod4=int.Parse(this.txtpiod4.Text);
                    //decimal piodc1=decimal.Parse(this.txtpiodc1.Text);
                    //decimal piodc2=decimal.Parse(this.txtpiodc2.Text);
                    //decimal piodc3=decimal.Parse(this.txtpiodc3.Text);
                    //decimal piodc4=decimal.Parse(this.txtpiodc4.Text);
                    //decimal piodc5=decimal.Parse(this.txtpiodc5.Text);

                    Jium.Model.piorecord model = new Jium.Model.piorecord();
                    model.ptime = ptime;
                    model.pcode = pcode;
                    model.pcnt = pcnt;
                    model.psaleprice = psaleprice;
                    model.prealprice = prealprice;
                    model.ptype = ptype;
                    model.pzekou = pzekou;
                    model.premark = premark;
                    model.pguestid = pguestid;
                    model.psalerid = psalerid;
                    model.pios1 = pios1;
                    model.pios2 = pios2;
                    model.pios3=pios3;
                    //model.pios4=pios4;
                    //model.pios5=pios5;
                    //model.piod1=piod1;
                    //model.piod2=piod2;
                    //model.piod3=piod3;
                    //model.piod5=piod5;
                    //model.piod4=piod4;
                    //model.piodc1=piodc1;
                    //model.piodc2=piodc2;
                    //model.piodc3=piodc3;
                    //model.piodc4=piodc4;
                    //model.piodc5=piodc5;

                    Jium.BLL.product bllProduct = new Jium.BLL.product();
                    Jium.BLL.plib bllPlib = new Jium.BLL.plib();
                    var where = string.Format("pcode='{0}'", pcode);
                    if (bllProduct.GetRecordCount(where) ==0)
                    {
                        if (this.txtpios3.Text.Trim().Length == 0)
                        {
                           
                            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "新品请输入货品名称！", "add.aspx");
                            return;
                        }

                        Jium.Model.product pmodel = new Jium.Model.product();
                        pmodel.pcode = model.pcode;
                        pmodel.pname = model.pios3;
                        pmodel.pdesc = model.premark;
                        pmodel.psaleprice = model.psaleprice;
                        pmodel.prealprice = model.prealprice;
                        pmodel.ptype = "-";
                        pmodel.pisgroup = 0;
                        bllProduct.Add(pmodel);
                    }


                    Jium.BLL.piorecord bll = new Jium.BLL.piorecord();
                    if (!bll.Add(model)) break;
                    var pllst = bllPlib.GetModelList(where);
                    if (pllst.Count == 0)
                    {
                        Jium.Model.plib plmodel = new Jium.Model.plib();
                        plmodel.pcode = model.pcode;
                        plmodel.pname = model.pios3;
                        plmodel.psalecnt = 0;
                        plmodel.psumcnt = 0;
                        plmodel.pleftcnt = 0;
                        plmodel.pdesc = model.premark;
                        plmodel.plupdatetime = DateTime.Now.ToString("yyyyMMddHHmmss");
                        plmodel.pls1 = "";
                        plmodel.pld1 = 0;
                        switch (model.ptype)
                        {
                            case 0://销售
                                plmodel.psalecnt += model.pcnt;
                                plmodel.pleftcnt -= model.pcnt;
                                break;                            
                            case 1://进货
                                plmodel.psumcnt += model.pcnt;
                                plmodel.pleftcnt += model.pcnt;
                                if (!plmodel.pls1.Contains(model.pios2)) plmodel.pls1 += model.pios2 + ";";
                                break;
                            case 8://退回厂商
                                plmodel.psumcnt -= model.pcnt;
                                plmodel.pleftcnt -= model.pcnt;
                                break;
                            case 2://订单
                                plmodel.pld1 += model.pcnt;
                                break;                           

                            case 3://盘赢
                                plmodel.pleftcnt += model.pcnt;
                                if (!plmodel.pls1.Contains(model.pios2)) plmodel.pls1 += model.pios2 + ";";
                                break;                            
                                
                            case 4://盘亏
                                plmodel.pleftcnt -= model.pcnt;
                                break;
                            case 5://退货
                                   //plmodel.psalecnt -= model.pcnt;
                                   //plmodel.pleftcnt += model.pcnt;
                                   //break;
                            case 6://换货进
                                plmodel.psalecnt -= model.pcnt;
                                plmodel.pleftcnt += model.pcnt;
                                if (!plmodel.pls1.Contains(plmodel.pls1)) plmodel.pls1 += model.pios2 + ";";
                                break;
                            case 7://换货出
                                plmodel.psalecnt += model.pcnt;
                                plmodel.pleftcnt -= model.pcnt;
                                break;
                        }
                        bllPlib.Add(plmodel);
                    }
                    else
                    {
                        Jium.Model.plib plmodel = pllst[0];
                        plmodel.plupdatetime = DateTime.Now.ToString("yyyyMMddHHmmss");
                        switch (model.ptype)
                        {
                            case 0://销售
                                plmodel.psalecnt += model.pcnt;
                                plmodel.pleftcnt -= model.pcnt;
                                break;
                            case 1://进货
                                plmodel.psumcnt += model.pcnt;
                                plmodel.pleftcnt += model.pcnt;
                                if (!plmodel.pls1.Contains(plmodel.pls1)) plmodel.pls1 += model.pios2 + ";";
                                break;
                            case 8://退回厂商
                                plmodel.psumcnt -= model.pcnt;
                                plmodel.pleftcnt -= model.pcnt;
                                break;
                            case 2://订单
                                plmodel.pld1 += model.pcnt;
                                break;

                            case 3://盘赢
                                plmodel.pleftcnt += model.pcnt;
                                if (!plmodel.pls1.Contains(plmodel.pls1)) plmodel.pls1 += model.pios2 + ";";
                                break;

                            case 4://盘亏
                                plmodel.pleftcnt -= model.pcnt;
                                break;
                            case 5://退货
                                   //plmodel.psalecnt -= model.pcnt;
                                   //plmodel.pleftcnt += model.pcnt;
                                   //break;
                            case 6://换货进
                                plmodel.psalecnt -= model.pcnt;
                                plmodel.pleftcnt += model.pcnt;
                                if (!plmodel.pls1.Contains(plmodel.pls1)) plmodel.pls1 += model.pios2 + ";";
                                break;
                            case 7://换货出
                                plmodel.psalecnt += model.pcnt;
                                plmodel.pleftcnt -= model.pcnt;
                                break;
                        }
                        bllPlib.Update(plmodel);
                    }
                    Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "add.aspx");
                    return;
                } while (false);
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存失败！", "add.aspx");
            }
            catch(Exception ex)
            {
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "Error！"+ex.Message, "add.aspx");
            }
        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
