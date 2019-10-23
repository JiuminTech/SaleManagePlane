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
            var filePath = "C:\\work\\111\\fwhorder11.xlsx";
            Ctrl.piorecord.BactchImportOrderData(filePath);
            Console.ReadLine();

        }
    }
}
