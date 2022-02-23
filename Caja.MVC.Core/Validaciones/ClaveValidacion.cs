using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;

namespace Caja.MVC.Core.Validaciones
{
    /// <summary>
    /// 
    /// </summary>
    public class ClaveValidacion : Attribute, IModelValidator
    {
        /// <summary>
        /// Obtiene o establece el mensaje de error.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Función para la retornar validación - función con inyección de dependencia
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            return new List<ModelValidationResult>
            {
                new ModelValidationResult(string.Empty, ErrorMessage)
            };
        }
    }
}
