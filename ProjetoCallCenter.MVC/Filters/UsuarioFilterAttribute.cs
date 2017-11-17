using ProjetoCallCenter.MVC.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace ProjetoCallCenter.MVC.Filters
{
    public class UsuarioFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var usuario = (UsuarioViewModel) filterContext.ActionParameters.FirstOrDefault().Value;

            if (filterContext.ActionDescriptor.ActionName == "Create")
            {
                if (usuario != null)
                {
                    var nomeusuario = usuario.Email.Split(Char.Parse("@"));
                    usuario.Credencial.NomeUsuario = nomeusuario[0];
                    usuario.Credencial.Senha = nomeusuario[0];
                    filterContext.ActionParameters.Remove("model");
                    filterContext.ActionParameters.Add("model", usuario);
                }
            }
        }
    }
}