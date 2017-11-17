using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace ProjetoCallCenter.MVC.Validations
{
    public class EmailBrasilAttribute : ValidationAttribute, IClientValidatable
    {

        public Boolean EmailRequerido { get; set; }

        public EmailBrasilAttribute()
        {
            this.ErrorMessage = "E-mail inválido.";
            this.EmailRequerido = false;

        }

        protected override ValidationResult IsValid(
            object value,
            ValidationContext validationContext)
        {

            // Verifica se o Valor é nulo
            if (value == null)
            {
                value = "";
            }

            // Retira espaços do final da literal
            value = value.ToString().TrimEnd();

            // Caso o valor informado seja nulo não é requerido retorna sem validar
            if (value == "" && EmailRequerido == false)
            {
                return ValidationResult.Success;
            }


            // Atribui expressao Regex
            Regex regExpEmail = new Regex(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$");


            // Valida a expressao
            Match match = regExpEmail.Match(value.ToString());

            if (match.Success)
            {
                return ValidationResult.Success; ;
            }

            // Devolve o erro padrao se a expressao nao for valida.
            return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));
        }

        // Diretivas para validação do lado do Cliente, implementa com jquery.validate
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(
            ModelMetadata metadata,
            ControllerContext context)
        {
            var Rule = new ModelClientValidationRule
            {
                ValidationType = "emailbrasil",
                ErrorMessage = this.FormatErrorMessage(metadata.PropertyName)

            };

            Rule.ValidationParameters["emailrequerido"] = EmailRequerido;

            yield return Rule;
        }
    }
}