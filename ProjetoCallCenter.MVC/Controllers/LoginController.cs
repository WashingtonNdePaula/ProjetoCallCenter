using AutoMapper;
using ProjetoCallCenter.Application;
using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.MVC.ViewModels;
using System.Web.Mvc;

namespace ProjetoCallCenter.MVC.Controllers
{
    public class LoginController : Controller
    {
        private CredencialAppService credencialAppService;
        public LoginController(CredencialAppService service)
        {
            credencialAppService = service;
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (credencialAppService.UsuarioExiste(model.Usuario)){
                    var credencial = Mapper.Map<Credencial, CredencialViewModel>(
                        credencialAppService.EfetuarLogin(model.Usuario, model.Senha));

                    if (credencial != null)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("Senha", "Senha Inválida");
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("Usuario", "Usuário não existe");
                    return View(model);
                }
            }
            return View(model);
        }
    }
}