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
#if true
            var basicbind = new System.ServiceModel.BasicHttpBinding();
            basicbind.SendTimeout = new TimeSpan(0, 10, 0);
            basicbind.MaxReceivedMessageSize = int.MaxValue;

            var endpoint = new System.ServiceModel.EndpointAddress(string.Format("http://{0}:8088/CNmsService", "127.0.0.1"));

            var m_oNmsServiceClient = new ServiceReference_CNmsService.CNmsServiceClient(basicbind, endpoint);
            var a=m_oNmsServiceClient.GetUserinfo(003, "");
            Console.Write(a._data);
            Console.ReadLine();

#endif

#if false
            var filePath = "C:\\WORK\\111\\SaleManagePlane\\fwhorder11.xlsx";
            Jium.Ctrl.piorecord.BactchImportOrderData(filePath);
            //var filePath = "C:\\WORK\\111\\SaleManagePlane\\出货报表导出结果_20191028140910.xlsx";
            //Ctrl.piorecord.BactchImportOrderInData(filePath);
            Console.ReadLine();
#endif

        }
    }



    [Serializable]
    public class ResInfoModel
    {
        public ResInfoModel()
        {
            ErrCode = ResCode.CODE_SUCCESS;
        }
        private ResCode _errCode;
        public ResCode ErrCode
        {
            set { _errCode = value; }
            get { return _errCode; }
        }

        private string _errDesc;
        public string ErrDesc
        {
            set { _errDesc = value; }
            get { return _errDesc; }
        }

        private string _data;
        public string Data
        {
            set { _data = value; }
            get { return _data; }
        }
    }

    public enum ResCode
    {
        CODE_SUCCESS = 0,
        CODE_FAILED = 1,
        CODE_EXCEPTION = 2,
    }
}
