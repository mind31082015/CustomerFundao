using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerFundao.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public JsonResult Index()
        {
            return View();
        }
    }
}