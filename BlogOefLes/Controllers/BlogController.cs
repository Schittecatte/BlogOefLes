using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogOefLes.Models;

namespace BlogOefLes.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            var people = GetPeople();
            return View(people);
        }
        private IList<Blog> GetPeople()
        {
            return new List<Blog>
            {
                new Blog {Firstname="Karl",
                Name="von Drais",
                Email="karl.vondrais@gmail.com"},
                 new Blog {Firstname="Thomas ",
                Name=" McCall",
                Email="Thomas.McCall@gmail.com"},
                  new Blog {Firstname="Piere ",
                Name="Llallement",
                Email="Piere.Llallement@gmail.com"},
        };
        }
    }
}