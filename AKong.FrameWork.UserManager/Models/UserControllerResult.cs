using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKong.FrameWork.UserManager
{
    public class UserControllerResult
    {
        public string Message { get; set; } 

        public bool IsSuccess { get; set; }

        public object OtherInfo { get; set; }

        public static UserControllerResult CreateDefualtSuccess()
        {
            return new UserControllerResult() { IsSuccess = true, Message = string.Empty, OtherInfo = null };
        }

        public static UserControllerResult CreateDefualtFaild(string msg = "未知原因失败！") 
        {
            return new UserControllerResult() { IsSuccess = false, Message = msg, OtherInfo = null };
        }
    }
}
