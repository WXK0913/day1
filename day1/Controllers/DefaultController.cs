using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace day1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        userdal dal = new userdal();
        public ActionResult Register()
        {
            return View();
        }

        //生成验证码
        public ActionResult validate() 
        {
            string code = ValidateCodeHelper.GetCode(4);
            Session["code"] = code;
            byte[] data = ValidateCodeHelper.ValidateCode(code);
            return File(data,"image/jpeg");
        }

        [HttpPost]
        public int zc(userinfo er,string code="") 
        {
            int t = dal.Register(er);
            if (code.ToUpper().ToString() != Session["code"].ToString().ToUpper())
            {
                return -1;
            }            
            else 
            {
                return t;
            }
        }

        [HttpGet]
        public int asd(string uname="") 
        {
            int i = dal.cnique(uname);
            return i;
        }
    }
}