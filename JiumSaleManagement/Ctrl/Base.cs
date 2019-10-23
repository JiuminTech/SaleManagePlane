using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctrl
{
    public class Base
    {
    }

    public enum PRODUCT_IO_TYPE
    {
        SALE=0,
        ORDERIN,
        ORDERPLAN,
        SUMADD,
        SUMPLUS,
        REJECT,
        RECHARGEIN,
        RECHARGEOUT,
        RETURN,

    }
    public enum ERR_CODE
    {
        SUCCESS = 0,
        EXCEPTION = 1,
        FAIL = 2,
        PARAM_EMPTY,
        FILE_NOT_EXIST,
        FILE_ERR_FORMAT,
    }
}
