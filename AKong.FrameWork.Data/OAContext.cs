using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AKong.FrameWork.Data.Models;

namespace AKong.FrameWork.Data
{
    public class OaContext : DbContext
    {
        public OaContext()
            : base("name=OA")
        {
        }
        public IDbSet<User> Users { get; set; }
    }
}
