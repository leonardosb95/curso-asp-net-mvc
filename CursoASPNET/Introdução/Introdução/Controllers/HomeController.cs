using Introdução.Models;
using System.Web.Mvc;

namespace Introdução.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()//Metodo que retorna uma View
        {
            var pessoa = new Pessoa()
            {
                PessoaId = 1,
                Nome = "Leonardo",
                Tipo = "Administrador"

            };

            ////Viewdata associativo

            //ViewData["PessoaId"] = pessoa.PessoaId;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["Tipo"] = pessoa.Tipo;

            ////ViewBag
            //ViewBag.Id = pessoa.PessoaId;
            //ViewBag.Nome = pessoa.Nome;
            //ViewBag.Tipo = pessoa.Tipo;

            return View(pessoa);
        }

        public ActionResult Contatos()
        {

            return View();

        }

        //[HttpPost]//Metodo que vai receber valor via POST
        //public ActionResult Lista(Pessoa pessoa)
        //{
        //    ViewData["PessoaId"] = pessoa.PessoaId;
        //    ViewData["Nome"] = pessoa.Nome;
        //    ViewData["Tipo"] = pessoa.Tipo;


        //    return View();

        //}

        public ActionResult Lista(Pessoa pessoa)
        {
            return View(pessoa);

        }


    }
}