using System.Web.Mvc;
using BlogOefLes.Core;

namespace BlogOefLes.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult DeleteConfirmation()
        {
            return View();
        }
    }
}