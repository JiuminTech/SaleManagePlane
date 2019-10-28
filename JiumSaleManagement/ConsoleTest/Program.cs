using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var filePath = "C:\\WORK\\111\\SaleManagePlane\\fwhorder11.xlsx";
            //Ctrl.piorecord.BactchImportOrderData(filePath);
            var filePath = "C:\\WORK\\111\\SaleManagePlane\\出货报表导出结果_20191028140910.xlsx";
            Ctrl.piorecord.BactchImportOrderInData(filePath);
            Console.ReadLine();

        }
    }
}
