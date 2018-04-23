using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";

            return View(new MyModel() { Id = 1, Name = "Test", Age = 17 });
        }

        [HttpPost]
        public ActionResult PostData([ModelBinder(typeof(DevExpress.Web.Mvc.DevExpressEditorsBinder))] MyModel model) {
            if (!ModelState.IsValid)
                return PartialView("Editors", model);

            return PartialView("Success");
        }
    }
}
