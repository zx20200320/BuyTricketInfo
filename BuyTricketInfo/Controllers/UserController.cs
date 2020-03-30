using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Configuration;
using BuyTricketInfo.Models;
using System.Data.SqlClient;

namespace BuyTricketInfo.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public void Login(UserInfo user)
        {
            using (SqlConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["userdb"].ConnectionString))
            {
                var result = db.GetAll<UserInfo>().Where(x=>x.UserName==user.UserName && x.PassWard==user.PassWard);
                if(result!=null && result.Count()>0)
                {
                    Response.Write("<script>alert('登录成功！');location.href='/BuyTricket/Index'</script>");
                }
                else
                {
                    Response.Write("<script>alert('用户名或密码不正确！');location.href='/BuyTricket/Login'</script>");
                }
            }
        }
    }
}