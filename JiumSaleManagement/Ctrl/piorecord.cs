using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jium.Ctrl
{
    public class piorecord
    {

        public static int BactchImportOrderData(string excelFilePath)
        {
            var iRes = ERR_CODE.SUCCESS;
            try
            {
                do
                {
                    if (string.IsNullOrEmpty(excelFilePath))
                    {
                        iRes = ERR_CODE.PARAM_EMPTY;
                        break;
                    }
                    if (!File.Exists(excelFilePath))
                    {
                        iRes = ERR_CODE.FILE_NOT_EXIST;
                        break;
                    }
                    if(!excelFilePath.ToLower().EndsWith(".xls") && !excelFilePath.ToLower().EndsWith(".xlsx"))
                    {
                        iRes = ERR_CODE.FILE_ERR_FORMAT;
                        break;
                    }
                    var lstModel = new List<Jium.Model.piorecord>();
                    Workbook workbook = new Workbook(excelFilePath);
                    for (int n = 0; n <2/* workbook.Worksheets.Count*/; n++)
                    {
                        Cells cells = workbook.Worksheets[n].Cells;
                        var tabname = workbook.Worksheets[n].Name;// CodeName;
                                                                  //var fields = new List<string> { "", "", "", "", "", "", "", "" };
                       
                        var orderid = DateTime.Now.Ticks;
                        for (int i = 1; i < cells.MaxDataRow + 1; i++)
                        {
                            var model = new Jium.Model.piorecord();
                            model.pcode = cells[i, 1].StringValue.Trim();
                            model.pguestid = 0;
                            model.psalerid = 0;
                            model.ptime = DateTime.Now.ToString("yyyyMMddHHmmss");
                            model.pios3 = cells[i, 2].StringValue.Trim();
                            model.premark = cells[i, 9].StringValue.Trim();
                            var sCnt = cells[i, 4].StringValue.Trim();
                            if (string.IsNullOrWhiteSpace(sCnt) || sCnt.Trim() == "-" || sCnt.Trim() == "0") continue;
                            model.pcnt = int.Parse(sCnt);
                            decimal saleprice = 0;
                            if (cells[i, 5].StringValue.Trim() != "") saleprice = decimal.Parse(cells[i, 5].StringValue.Trim());
                            model.psaleprice = saleprice;
                            decimal zekou = 0;
                            if (cells[i, 7].StringValue.Trim() != "") zekou = decimal.Parse(cells[i, 7].StringValue.Trim());
                            model.pzekou = zekou;
                            //decimal realprice = 0;
                            //if (cells[i, 5].StringValue.Trim() != "") realprice = decimal.Parse(cells[i, 5].StringValue.Trim());
                            model.prealprice = saleprice * zekou;
                            model.ptype = (int)PRODUCT_IO_TYPE.ORDERPLAN;
                            model.pios4 = cells[i, 3].StringValue.Trim();//单位
                            model.pios5 = cells[i, 0].StringValue.Trim();//系列
                            model.pios1 = tabname;
                            model.pios2 = "";
                            lstModel.Add(model);
                            //for (int j = 0; j < cells.MaxDataColumn + 1; j++)
                            //{
                            //    string s = cells[i, j].StringValue.Trim();

                            //}
                        }
                    }
                    foreach (var model in lstModel)
                    {
                        if (!AddPiorecord(model))
                        {
                            iRes = ERR_CODE.FAIL;
                            break;
                        }
                    }
                } while (false);
            }
            catch (Exception ex)
            {
                iRes = ERR_CODE.EXCEPTION;
            }

            return (int)iRes;

        }

        public static int BactchImportOrderInData(string excelFilePath)
        {
            var iRes = ERR_CODE.SUCCESS;
            try
            {
                do
                {
                    if (string.IsNullOrEmpty(excelFilePath))
                    {
                        iRes = ERR_CODE.PARAM_EMPTY;
                        break;
                    }
                    if (!File.Exists(excelFilePath))
                    {
                        iRes = ERR_CODE.FILE_NOT_EXIST;
                        break;
                    }
                    if (!excelFilePath.ToLower().EndsWith(".xls") && !excelFilePath.ToLower().EndsWith(".xlsx"))
                    {
                        iRes = ERR_CODE.FILE_ERR_FORMAT;
                        break;
                    }
                    Workbook workbook = new Workbook(excelFilePath);
                    Cells cells = workbook.Worksheets[0].Cells;
                    var tabname = workbook.Worksheets[0].Name;// CodeName;
                    var fields = new List<string> { "", "", "", "", "", "", "", "" };
                    var lstModel = new List<Jium.Model.piorecord>();
                    var orderid = DateTime.Now.Ticks;
                    for (int i = 1; i < cells.MaxDataRow + 1; i++)
                    {
                        var model = new Jium.Model.piorecord();
                        model.pcode = cells[i, 10].StringValue.Trim();
                        model.pguestid = 0;
                        model.psalerid = 0;
                        model.ptime = DateTime.Now.ToString("yyyyMMddHHmmss");
                        model.pios3 = cells[i, 11].StringValue.Trim();
                        model.premark = cells[i, 12].StringValue.Trim();
                        model.pcnt = int.Parse(cells[i, 13].StringValue.Trim());
                        model.psaleprice = decimal.Parse(cells[i, 14].StringValue.Trim());
                        model.pzekou = decimal.Parse(cells[i, 16].StringValue.Trim());
                        model.prealprice = decimal.Parse(cells[i, 17].StringValue.Trim());
                        model.ptype = (int)PRODUCT_IO_TYPE.ORDERIN;
                        model.pios4 = "1";//cells[i, 3].StringValue.Trim();//单位
                        model.pios5 = cells[i, 21].StringValue.Trim();//系列
                        model.pios1 = orderid.ToString();
                        model.pios2 = "";
                        lstModel.Add(model);
                        //for (int j = 0; j < cells.MaxDataColumn + 1; j++)
                        //{
                        //    string s = cells[i, j].StringValue.Trim();

                        //}
                    }

                    foreach (var model in lstModel)
                    {
                        if (!AddPiorecord(model))
                        {
                            iRes = ERR_CODE.FAIL;
                            break;
                        }
                    }


                } while (false);
            }
            catch (Exception ex)
            {
                iRes = ERR_CODE.EXCEPTION;
            }

            return (int)iRes;

        }

        public static bool AddPiorecord(Jium.Model.piorecord model)
        {
            var bres = true;
            try
            {                
                do
                {                   

                    Jium.BLL.product bllProduct = new Jium.BLL.product();
                    Jium.BLL.plib bllPlib = new Jium.BLL.plib();
                    var where = string.Format("pcode='{0}'", model.pcode);
                    if (bllProduct.GetRecordCount(where) == 0)
                    {

                        Jium.Model.product pmodel = new Jium.Model.product();
                        pmodel.pcode = model.pcode;
                        pmodel.pname = model.pios3;
                        pmodel.pdesc = model.premark;
                        pmodel.psaleprice = model.psaleprice;
                        pmodel.prealprice = model.prealprice;
                        pmodel.ptype = model.pios5;//系列
                        pmodel.ps1 = model.pios4;//单位
                        pmodel.pisgroup = 0;
                        bres= bllProduct.Add(pmodel);
                        if (!bres) break;
                    }


                    Jium.BLL.piorecord bll = new Jium.BLL.piorecord();
                    bres = bll.Add(model);
                    if (!bres) break;
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
                        plmodel.pls2 = model.pios4;
                        plmodel.pld1 = 0;
                        switch ((PRODUCT_IO_TYPE)model.ptype)
                        {
                            case PRODUCT_IO_TYPE.SALE://销售
                                plmodel.psalecnt += model.pcnt;
                                plmodel.pleftcnt -= model.pcnt;
                                break;
                            case PRODUCT_IO_TYPE.ORDERIN://进货
                                plmodel.psumcnt += model.pcnt;
                                plmodel.pleftcnt += model.pcnt;
                                if (!plmodel.pls1.Contains(model.pios2)) plmodel.pls1 += model.pios2 + ";";
                                break;
                            case PRODUCT_IO_TYPE.RETURN://退回厂商
                                plmodel.psumcnt -= model.pcnt;
                                plmodel.pleftcnt -= model.pcnt;
                                break;
                            case PRODUCT_IO_TYPE.ORDERPLAN://订单
                                plmodel.pld1 += model.pcnt;
                                break;

                            case PRODUCT_IO_TYPE.SUMADD://盘赢
                                plmodel.pleftcnt += model.pcnt;
                                if (!plmodel.pls1.Contains(model.pios2)) plmodel.pls1 += model.pios2 + ";";
                                break;

                            case PRODUCT_IO_TYPE.SUMPLUS://盘亏
                                plmodel.pleftcnt -= model.pcnt;
                                break;
                            case PRODUCT_IO_TYPE.REJECT://退货
                                   //plmodel.psalecnt -= model.pcnt;
                                   //plmodel.pleftcnt += model.pcnt;
                                   //break;
                            case PRODUCT_IO_TYPE.RECHARGEIN://换货进
                                plmodel.psalecnt -= model.pcnt;
                                plmodel.pleftcnt += model.pcnt;
                                if (!plmodel.pls1.Contains(plmodel.pls1)) plmodel.pls1 += model.pios2 + ";";
                                break;
                            case PRODUCT_IO_TYPE.RECHARGEOUT://换货出
                                plmodel.psalecnt += model.pcnt;
                                plmodel.pleftcnt -= model.pcnt;
                                break;
                        }
                        bres=bllPlib.Add(plmodel);
                    }
                    else
                    {
                        Jium.Model.plib plmodel = pllst[0];
                        plmodel.plupdatetime = DateTime.Now.ToString("yyyyMMddHHmmss");
                        switch ((PRODUCT_IO_TYPE)model.ptype)
                        {
                            case PRODUCT_IO_TYPE.SALE://销售
                                plmodel.psalecnt += model.pcnt;
                                plmodel.pleftcnt -= model.pcnt;
                                break;
                            case PRODUCT_IO_TYPE.ORDERIN://进货
                                plmodel.psumcnt += model.pcnt;
                                plmodel.pleftcnt += model.pcnt;
                                if (!plmodel.pls1.Contains(model.pios2)) plmodel.pls1 += model.pios2 + ";";
                                break;
                            case PRODUCT_IO_TYPE.RETURN://退回厂商
                                plmodel.psumcnt -= model.pcnt;
                                plmodel.pleftcnt -= model.pcnt;
                                break;
                            case PRODUCT_IO_TYPE.ORDERPLAN://订单
                                plmodel.pld1 += model.pcnt;
                                break;

                            case PRODUCT_IO_TYPE.SUMADD://盘赢
                                plmodel.pleftcnt += model.pcnt;
                                if (!plmodel.pls1.Contains(model.pios2)) plmodel.pls1 += model.pios2 + ";";
                                break;

                            case PRODUCT_IO_TYPE.SUMPLUS://盘亏
                                plmodel.pleftcnt -= model.pcnt;
                                break;
                            case PRODUCT_IO_TYPE.REJECT://退货
                                                        //plmodel.psalecnt -= model.pcnt;
                                                        //plmodel.pleftcnt += model.pcnt;
                                                        //break;
                            case PRODUCT_IO_TYPE.RECHARGEIN://换货进
                                plmodel.psalecnt -= model.pcnt;
                                plmodel.pleftcnt += model.pcnt;
                                if (!plmodel.pls1.Contains(plmodel.pls1)) plmodel.pls1 += model.pios2 + ";";
                                break;
                            case PRODUCT_IO_TYPE.RECHARGEOUT://换货出
                                plmodel.psalecnt += model.pcnt;
                                plmodel.pleftcnt -= model.pcnt;
                                break;
                        }
                        bres=bllPlib.Update(plmodel);
                    }
                    return bres;
                } while (false);                
            }
            catch (Exception ex)
            {
                bres = false;
            }
            return false; ;
        }


    }
}
