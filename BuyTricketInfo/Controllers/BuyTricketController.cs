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
    public class BuyTricketController : Controller
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        // GET: BuyTricket
        public ActionResult Index()
        {
            using (SqlConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["userdb"].ConnectionString))
            {
                List<Tickets> list = db.GetAll<Tickets>().ToList();
                return View(list);
            }               
        }
        public ActionResult Create()
        {           
                return View();
        }
        [HttpPost]
        public void Create(Tickets tickets)
        {
            using (SqlConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["userdb"].ConnectionString))
            {
                long result = db.Insert<Tickets>(tickets);
                if(result>0)
                {
                    Response.Write("<script>alert('添加成功！');location.href='/BuyTricket/Index'</script>");
                }
                else
                {
                    Response.Write("<script>alert('添加失败！')</script>");
                }
            }
                
        }
        //public ActionResult Delete()
        //{
        //    return View();
        //}
        public void Delete(int id)
        {
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["userdb"].ConnectionString))
            {
                var  result = db.Delete<Tickets>(new Tickets() { Id=id});
                if (result)
                {
                    Response.Write("<script>alert('删除成功！');location.href='/BuyTricket/Index'</script>");
                }
                else
                {
                    Response.Write("<script>alert('删除失败！')</script>");
                }
            }
        }
        public ActionResult Edit(int id)
        {
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["userdb"].ConnectionString))
            {
                var result = db.QueryFirstOrDefault<Tickets>($"select * from Tickets where Id={id}");
                return View(result);
            }
                
        }
        [HttpPost]
        public void Edit(Tickets tickets)
        {
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["userdb"].ConnectionString))
            {
                bool result = db.Update<Tickets>(tickets);
                if (result)
                {
                    Response.Write("<script>alert('修改成功！');location.href='/BuyTricket/Index'</script>");
                }
                else
                {
                    Response.Write("<script>alert('修改失败！')</script>");
                }
            }

        }
    }
}