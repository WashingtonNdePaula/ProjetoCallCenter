using Microsoft.Reporting.WebForms;
using ProjetoCallCenter.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ProjetoCallCenter.MVC.Controllers
{
    public class RelatorioController : Controller
    {
        private readonly IUsuarioAppService _service;
        public RelatorioController(IUsuarioAppService service)
        {
            _service = service;
        }

        // GET: Relatorio
        public ActionResult Usuario()
        {

            var viewer = new ReportViewer();
            var usuarios = _service.GetAll();
            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\ReportUsuario.rdlc";
            viewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetRelatorioUsuario",(from u in usuarios where u.Credencial.TipoCredencialId != 4 select new { u.Nome, u.Email, u.Credencial.NomeUsuario, u.Credencial.TipoCredencial.Descricao })));
            viewer.SizeToReportContent = true;
            viewer.Width = Unit.Percentage(100);
            viewer.Height = Unit.Percentage(100);

            ViewBag.ReportViewer = viewer;
            return View();
        }
    }
}