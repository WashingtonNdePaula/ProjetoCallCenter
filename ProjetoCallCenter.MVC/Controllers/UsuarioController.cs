using AutoMapper;
using ProjetoCallCenter.Application.Interfaces;
using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.MVC.Filters;
using ProjetoCallCenter.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoCallCenter.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ICredencialAppService _credencialService;
        private readonly IUsuarioAppService _usuarioService;
        private readonly IStatusAppService _statusService;
        private readonly ITipoCredencialAppService _tipoService;
        public UsuarioController(ICredencialAppService credencialService, IUsuarioAppService usuarioService, IStatusAppService statusService, ITipoCredencialAppService tipoService)
        {
            _credencialService = credencialService;
            _usuarioService = usuarioService;
            _statusService = statusService;
            _tipoService = tipoService;
        }
        // GET: Usuario
        public ActionResult Index()
        {
            var usuarios = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioService.GetAllValidos());
            return View(usuarios);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            var usuario = Mapper.Map<Usuario, UsuarioViewModel>(_usuarioService.GetById(id));
            return View(usuario);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            ViewBag.ListaStatus = new SelectList(_statusService.GetAllForUsuario(),"StatusId","Descricao");
            ViewBag.ListaTipo = new SelectList(_tipoService.GetAllValidos(), "TipoCredencialId","Descricao");

            return View();
        }

        public ActionResult EmailJaCadastrado(string email, int usuarioId)
        {
            bool emailExiste = false;
            try
            {
                emailExiste = _usuarioService.EmailJaCadastrado(usuarioId, email) ? true : false;
                return Json(!emailExiste, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [UsuarioFilter]
        public ActionResult Create(UsuarioViewModel model)
        {
            ViewBag.ListaStatus = new SelectList(_statusService.GetAllForUsuario(), "StatusId", "Descricao", model.Credencial.StatusId);
            ViewBag.ListaTipo = new SelectList(_tipoService.GetAllValidos(), "TipoCredencialId", "Descricao", model.Credencial.TipoCredencialId);

            try
            {
                if (ModelState.IsValid)
                {
                    _usuarioService.Add(Mapper.Map<UsuarioViewModel, Usuario>(model));
                }else
                {
                    return View(model);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            var usuario = Mapper.Map<Usuario, UsuarioViewModel>(_usuarioService.GetById(id));

            ViewBag.ListaStatus = new SelectList(_statusService.GetAllForUsuario(),"StatusId","Descricao", usuario.Credencial.StatusId);
            ViewBag.ListaTipo = new SelectList(_tipoService.GetAllValidos(), "TipoCredencialId", "Descricao", usuario.Credencial.TipoCredencialId);
            return View(usuario);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [UsuarioFilter]
        public ActionResult Edit(UsuarioViewModel model)
        {
            ViewBag.ListaStatus = new SelectList(_statusService.GetAllForUsuario(), "StatusId", "Descricao", model.Credencial.StatusId);
            ViewBag.ListaTipo = new SelectList(_tipoService.GetAllValidos(), "TipoCredencialId", "Descricao", model.Credencial.TipoCredencialId);
            try
            {
                if (ModelState.IsValid)
                {
                    var credencial = _credencialService.GetById(model.UsuarioId);
                    model.Credencial.NomeUsuario = credencial.NomeUsuario;
                    model.Credencial.Senha = credencial.Senha;
                    model.Credencial.UsuarioId = credencial.UsuarioId;
                    credencial.TipoCredencialId = model.Credencial.TipoCredencialId;
                    credencial.StatusId = model.Credencial.StatusId;
                    _usuarioService.Update(Mapper.Map<UsuarioViewModel, Usuario>(model));
                    _credencialService.Update(credencial);
                }
                else
                {
                    return View(model);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            var usuario = Mapper.Map<Usuario, UsuarioViewModel>(_usuarioService.GetById(id));

            ViewBag.ListaStatus = new SelectList(_statusService.GetAllForUsuario(), usuario.Credencial.StatusId);
            ViewBag.ListaTipo = new SelectList(_tipoService.GetAllValidos(), usuario.Credencial.TipoCredencialId);
            return View(usuario);
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(UsuarioViewModel model)
        {
            try
            {
                var credencial = _credencialService.GetById(model.UsuarioId);
                credencial.StatusId = 2;
                _credencialService.Update(credencial);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }
    }
}
