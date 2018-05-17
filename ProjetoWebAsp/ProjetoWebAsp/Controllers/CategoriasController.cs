using ProjetoWebAsp.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoWebAsp.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
           

           

            return View();
        }

        public ActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Formulario(string nome, string descricao,bool ativo,string textoComprido)
        {
            return View();
        }
    }
}