using Rotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Rotas.Controllers
{
    public class HomeController : Controller
    {

        private readonly IEnumerable<Noticia> todasAsNoticias;//Apenas leitura

        public HomeController()
        {

            todasAsNoticias = new Noticia().TodasAsNoticias().OrderByDescending(x => x.Data);//Toda vez que eu chamar e dar referencia, ele vai trazer em ordem de data
        }


        public ActionResult Index()
        {
            var ultimasNoticias = todasAsNoticias.Take(3);//Retorna as 3 ultimas noticias da classe
            var todasAsCategorias = todasAsNoticias.Select(x => x.Categoria).Distinct().ToList() ;//Retorna todas as categorias diferentes de forma ordenada

            ViewBag.Categorias = todasAsCategorias;//ViewBag esta recebendo todas as categorias

            return View(ultimasNoticias);
        }

        public ActionResult TodasAsNoticias()
        {

            return View(todasAsNoticias);//Mostra todas as noticias
        }

        public ActionResult MostrarTodasAsNoticias(int NoticiaId, string titulo, string categoria)
        {

            return View(todasAsNoticias.FirstOrDefault(x=> x.NoticiaId == NoticiaId));//Retorna pra mim todas as noticias que tiver o id igual ao cadastro igual que tiver o id selecionado
        }



        public ActionResult MostraCategoria(string categoria)
        {
            var categoriaEspecifica = todasAsNoticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();//Busca todas as categorias em que a categoria for igual, listando elas

            ViewBag.Categoria = categoria;
            return View(categoriaEspecifica);
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}