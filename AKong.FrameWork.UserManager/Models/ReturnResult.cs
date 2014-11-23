using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKong.FrameWork.UserManager
{
    public class ReturnResult
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public object OtherInfo { get; set; }
        public static ReturnResult CreateDefualtSuccess()
        {
            return new ReturnResult() { IsSuccess = true, Message = string.Empty, OtherInfo = null };
        }
        public static ReturnResult CreateDefualtFaild(string msg = "未知原因失败！") 
        {
            return new ReturnResult() { IsSuccess = false, Message = msg, OtherInfo = null };
        }
    }
}
