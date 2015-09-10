using System.Web.Mvc;

namespace CustomerFundao.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return Json(null, JsonRequestBehavior.AllowGet);
        }
    }
}