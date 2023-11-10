using ApControle.Data;
using ApControle.Service;
using Microsoft.AspNetCore.Mvc;

namespace ApControle.Web.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            CrudAluno service = new CrudAluno();
            return View(service.Read());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Aluno model)
        {
            CrudAluno service = new CrudAluno();
            service.Create(model);
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            CrudAluno service = new CrudAluno();
            service.Delete(id);
            return RedirectToAction("List");
        }
    }
}
