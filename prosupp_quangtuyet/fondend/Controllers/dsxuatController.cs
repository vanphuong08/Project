using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fondend.Controllers
{
    public class dsxuatController : Controller
    {
        // GET: dsxuat
        public ActionResult Index()
        {
            int pageSize = 3;
            int total = 0;
            ViewBag.totalPage = (int)Math.Ceiling((double)total / pageSize);
            return View();
        }
    }
}