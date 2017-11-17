using AutoMapper;
using ProjetoCallCenter.Application.br.com.correios.apps;
using ProjetoCallCenter.Application.Interfaces;
using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoCallCenter.MVC.Controllers
{
    public class CredorController : Controller
    {
        private readonly ICredorAppService _service;
        public CredorController(ICredorAppService service)
        {
            _service = service;
        }
        // GET: Credor
        public ActionResult Index()
        {
            var model = Mapper.Map<IEnumerable<Credor>,IEnumerable<CredorViewModel>>(_service.GetAll());
            return View(model);
        }

        // GET: Credor/Details/5
        public ActionResult Details(int id)
        {
            var model = Mapper.Map<Credor, CredorViewModel>(_service.GetById(id));
            return View(model);
        }

        // GET: Credor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Credor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CredorViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _service.Add(Mapper.Map<CredorViewModel, Credor>(model));
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

        // GET: Credor/Edit/5
        public ActionResult Edit(int id)
        {
            var model = Mapper.Map<Credor, CredorViewModel>(_service.GetById(id));
            return View(model);
        }

        public ActionResult ConsultaCEP(string cep)
        {
            Credor credor = new Credor();
            credor.CEP = cep;
            try
            {
                credor = _service.LocalizarCEP(credor);
            }
            catch
            {
                ModelState.AddModelError("CEP", "CEP Não Encontrado");
                return Json(credor, JsonRequestBehavior.AllowGet);
            }
            return Json(credor, JsonRequestBehavior.AllowGet);
        }

        // POST: Credor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CredorViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _service.Update(Mapper.Map<CredorViewModel, Credor>(model));
                }
                else
                {
                    return View(model);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Credor/Delete/5
        public ActionResult Delete(int id)
        {
            var model = Mapper.Map<Credor, CredorViewModel>(_service.GetById(id));
            return View(model);
        }

        // POST: Credor/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(CredorViewModel model)
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
