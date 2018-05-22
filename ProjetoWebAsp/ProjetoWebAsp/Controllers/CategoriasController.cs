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

        public ActionResult Create()//carregar formulario
        {
            return View(); //criar objeto no banco 


        }
        [HttpPost]

        public ActionResult Create (Categoria categoria)
        {

            if ( ModelState.IsValid){//para campos de validacao por exemplo
                //salvar no banco
            }
            return View(categoria);//recebendo o objeto inteiro retorno
        }

        public ActionResult Index2()
        {
            List<Categoria> categorias = new List<Categoria>();

            categorias.Add(
                new Categoria()
                {

                    Nome = "Casa"
                }

                );
            
            categorias.Add(new Categoria() { Nome = "Carro" });
            categorias.Add(new Categoria() { Nome = "Trabalho" });
            categorias.Add(new Categoria() { Nome = "Família" });

            return View(categorias);
        }
    }
}