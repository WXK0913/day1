using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace day1.Controllers
{
    public class userdal
    {
        //实例化上下文
        Model1 cxt = new Model1();

        //注册
        public int Register(userinfo er) 
        {
            cxt.uinfo.Add(er);
            return cxt.SaveChanges();
        }

        //用户名唯一性
        public int cnique(string uname="") 
        {
            IQueryable<userinfo> list = from b in cxt.uinfo
                                        where (b.uname.Equals(uname))
                                        select b;

            
            return list.ToList().Count();
        }

        
    }
}