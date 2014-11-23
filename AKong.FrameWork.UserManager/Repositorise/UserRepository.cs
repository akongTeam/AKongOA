using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AKong.FrameWork.Data.Models;
using AKong.FrameWork.Data;

namespace AKong.FrameWork.UserManager.Repositorise
{
    class UserRepository
    {
        public static User GetUser(string userName)
        {
            User usr = null;
            try
            {
                using (var context = new OaContext())
                {
                    usr = context.Users.FirstOrDefault(o => o.UserName == userName);
                }

            }
            catch (Exception ex)
            {
            }
            return usr;
        }
    }
}
