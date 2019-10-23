using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace Jium.Common
{
    public class AsposeExcellHelper
    {
        public static DataTable ExportToDataTableAsString(string excelFilePath, bool showTitle = true)
        {
            Workbook workbook = new Workbook(excelFilePath);
            //workbook.Open(excelFilePath);
            Cells cells = workbook.Worksheets[0].Cells;

            System.Data.DataTable dataTable2 = cells.ExportDataTableAsString(0, 0, cells.MaxDataRow + 1, cells.MaxColumn + 1, showTitle);//showTitle
            return dataTable2;
        }
        public static DataTable ExportToDataTableAsString(Stream stream, bool showTitle = true)
        {
            Workbook workbook = new Workbook(stream);
            //workbook.Open(stream);
            Cells cells = workbook.Worksheets[0].Cells;

            System.Data.DataTable dataTable2 = cells.ExportDataTableAsString(0, 0, cells.MaxDataRow + 1, cells.MaxColumn + 1, showTitle);//showTitle
            return dataTable2;
        }

    }
    
}

