using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AKong.FrameWork.Data;
using AKong.FrameWork.Data.Models;
using AKong.FrameWork.UserManager.Repositorise;
using System.Security.Cryptography;

namespace AKong.FrameWork.UserManager
{
    public class UserController
    {
        public UserController()
        {
            IsLogin = false;
        }
        public bool IsLogin { get; set; }

        public ReturnResult Login(UserLoginDto userInfo)
        {
            var result = ReturnResult.CreateDefualtFaild();
            var usr = UserRepository.GetUser(userInfo.UserName);
            if (usr.Password == MD5Crypto(userInfo.Password))
            {
                IsLogin = true;
                result.IsSuccess = true;
                result.Message = "验证成功，已登录！";
            }
            else
            {
                result.IsSuccess = false;
                result.Message = "帐号或密码错误！";
            }

            return result;
        }

        private string MD5Crypto(string value)
        {
            var md5 = MD5CryptoServiceProvider.Create();
            return Encoding.Default.GetString(md5.ComputeHash(Encoding.Default.GetBytes(value)));
        }
    }
}
