using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace day1.Controllers
{
    
    public class userinfo
    {
        [Key]
        public int uid { get; set; }
        public string uname { get; set; }
        public string xname { get; set; }
        public string pwd { get; set; }
        public string uemail { get; set; }


        public int MyProperty { get; set; }
        public int mptyu { get; set; }

    }
}