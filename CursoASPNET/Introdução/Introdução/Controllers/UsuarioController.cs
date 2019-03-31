using Introdução.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introdução.Controllers
{
    public class UsuarioController : Controller
    {
        


        //GET: Usuario
        public ActionResult Usuario()
        {
            Usuario usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Nome))//Se o campo nome estiver vazio
            {
                ModelState.AddModelError("Nome", "O campo nome é obrigatório!!");
            }

            if (usuario.Senha != usuario.ConfirmaSenha)
            {
                ModelState.AddModelError("", "As senhas são diferentes");//Quando o primeiro parametro está vazio, ele envia a mensagem para automaticamente para o ValidateSummary
            }


            if (ModelState.IsValid)
            {

                return View("Resultado", usuario);

            }

            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {

            return View(usuario);

        }

        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "Leonardo",
                "Hugo",
                "Larissa"
            };

            return Json(bdExemplo.All(x=> x.ToLower() != login.ToLower() ), JsonRequestBehavior.AllowGet);
        }






        }
}