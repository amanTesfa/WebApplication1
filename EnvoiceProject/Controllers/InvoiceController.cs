using Microsoft.AspNetCore.Mvc;

namespace EnvoiceProject.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
