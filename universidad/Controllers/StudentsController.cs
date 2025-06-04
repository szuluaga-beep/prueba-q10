using Microsoft.AspNetCore.Mvc;

namespace universidad.Controllers
{
    public class StudentsController : Controller
    {
        // GET: StudentsController
        public ActionResult Students()
        {
            return View();
        }

    }
}
