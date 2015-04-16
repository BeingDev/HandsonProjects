using MyWeb.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MyBlog.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var blogList = new List<Blog>();
            blogList.Add(new Blog { BlogId = 1, BlogName = "MyBlog1", CreatedBy = "Vidwan", CreatedOn = DateTime.Now, ModifiedBy = "Vidwan", ModifiedOn = DateTime.Now });
            blogList.Add(new Blog { BlogId = 1, BlogName = "MyBlog2", CreatedBy = "Vidwan", CreatedOn = DateTime.Now, ModifiedBy = "Vidwan", ModifiedOn = DateTime.Now });
            return View(blogList);
        }
    }
}