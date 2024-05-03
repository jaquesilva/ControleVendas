using Microsoft.AspNetCore.Mvc;

namespace ControleVendas.Controllers
{
    public class RelatoriosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
