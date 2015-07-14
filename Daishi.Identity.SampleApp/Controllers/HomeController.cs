#region Includes

using System.Security.Claims;
using System.Web.Mvc;

#endregion

namespace Daishi.Identity.SampleApp.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        [Authorize]
        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View((User as ClaimsPrincipal).Claims);
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}