using AutoMapper;
using ProjetoCallCenter.Application.Interfaces;
using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ProjetoCallCenter.MVC.Controllers
{
    public class SegmentacaoController : Controller
    {
        private readonly IUsuarioAppService _usuarioService;
        private readonly ICredorAppService _credorService;
        private readonly ISegmentacaoAppService _segmentacaoService;

        public SegmentacaoController(IUsuarioAppService usuarioService, ICredorAppService credorService, ISegmentacaoAppService segmentacaoService)
        {
            _usuarioService = usuarioService;
            _credorService = credorService;
            _segmentacaoService = segmentacaoService;
        }
        // GET: Segmentacao
        public ActionResult Index()
        {
            var selecaoCredor = _credorService.GetAll().FirstOrDefault();
            var selecaoUsuario = _usuarioService.GetAllOperadores().FirstOrDefault();
            ViewBag.ListaCredores = new SelectList(_credorService.GetAll(), "CredorId", "NomeFantasia", selecaoCredor );
            ViewBag.ListaUsuarios = new SelectList(_usuarioService.GetAllOperadores(), "UsuarioId", "Nome", selecaoUsuario);
            var model = new ListaSegmentacaoViewModel();
            model.CredorId = selecaoCredor != null ? selecaoCredor.CredorId : 0;
            model.UsuarioId = selecaoUsuario != null ? selecaoUsuario.UsuarioId : 0;
            model.Credor = selecaoCredor;
            model.Usuario = selecaoUsuario;
            model.Segmentacoes = Mapper.Map<IEnumerable<Segmentacao>, IEnumerable<SegmentacaoViewModel>>(
                _segmentacaoService.GetAll(model.UsuarioId, model.CredorId));
            return View(model);
        }

        // POST: Segmentacao/Index
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            var selecaoCredor = _credorService.GetById(int.Parse(form["CredorId"].ToString()));
            var selecaoUsuario = _usuarioService.GetById(int.Parse(form["UsuarioId"].ToString()));
            ViewBag.ListaCredores = new SelectList(_credorService.GetAll(), "CredorId", "NomeFantasia", selecaoCredor);
            ViewBag.ListaUsuarios = new SelectList(_usuarioService.GetAllOperadores(), "UsuarioId", "Nome", selecaoUsuario);
            var model = new ListaSegmentacaoViewModel();
            model.CredorId = selecaoCredor != null ? selecaoCredor.CredorId : 0;
            model.UsuarioId = selecaoUsuario != null ? selecaoUsuario.UsuarioId : 0;
            model.Credor = selecaoCredor;
            model.Usuario = selecaoUsuario;
            model.Segmentacoes = Mapper.Map<IEnumerable<Segmentacao>, IEnumerable<SegmentacaoViewModel>>(
                _segmentacaoService.GetAll(selecaoUsuario.UsuarioId, selecaoCredor.CredorId));
            return View(model);
        }

        // GET: Segmentacao/Details/5
        public ActionResult Details(int id)
        {
            var segmentacao = Mapper.Map<Segmentacao, SegmentacaoViewModel>(
                _segmentacaoService.GetById(id));
            return View(segmentacao);
        }

        // GET: Segmentacao/Create
        public ActionResult Create()
        {
            ViewBag.ListaCredores = new SelectList(_credorService.GetAll(), "CredorId", "NomeFantasia", String.Empty);
            ViewBag.ListaUsuarios = new SelectList(_usuarioService.GetAllOperadores(), "UsuarioId", "Nome", String.Empty);
            return View();
        }

        // POST: Segmentacao/Create
        [HttpPost]
        public ActionResult Create(SegmentacaoViewModel model)
        {
            ViewBag.ListaCredores = new SelectList(_credorService.GetAll(), "CredorId", "NomeFantasia", model.CredorId);
            ViewBag.ListaUsuarios = new SelectList(_usuarioService.GetAllOperadores(), "UsuarioId", "Nome", model.UsuarioId);
            try
            {
                if (ModelState.IsValid)
                {
                    _segmentacaoService.Add(
                        Mapper.Map<SegmentacaoViewModel, Segmentacao>(model));
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Segmentacao/Edit/5
        public ActionResult Edit(int id)
        {
            var model = Mapper.Map<Segmentacao, SegmentacaoViewModel>(
                _segmentacaoService.GetById(id));
            ViewBag.ListaCredores = new SelectList(_credorService.GetAll(), "CredorId", "NomeFantasia", model.CredorId);
            ViewBag.ListaUsuarios = new SelectList(_usuarioService.GetAllOperadores(), "UsuarioId", "Nome", model.UsuarioId);
            return View(model);
        }

        // POST: Segmentacao/Edit/5
        [HttpPost]
        public ActionResult Edit(SegmentacaoViewModel model)
        {
            ViewBag.ListaCredores = new SelectList(_credorService.GetAll(), "CredorId", "NomeFantasia", model.CredorId);
            ViewBag.ListaUsuarios = new SelectList(_usuarioService.GetAllOperadores(), "UsuarioId", "Nome", model.UsuarioId);
            try
            {
                if (ModelState.IsValid)
                {
                    _segmentacaoService.Update(
                        Mapper.Map<SegmentacaoViewModel, Segmentacao>(model));
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Segmentacao/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _segmentacaoService.GetById(id);
            return View(model);
        }

        // POST: Segmentacao/Delete/5
        [HttpPost]
        public ActionResult Delete(FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
