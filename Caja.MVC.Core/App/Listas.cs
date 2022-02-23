using Caja.MVC.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Caja.MVC.Core.App
{
    public static class Listas
    {
        public static SelectList ObtenerListaSiNo()
        {
            IEnumerable<ComboModel> lista = new ComboModel().ListaSiNo();
            return new SelectList(lista, nameof(ComboModel.Value), nameof(ComboModel.Text));
        }

        public static SelectList ObtenerListaEstadoCivil()
        {
            IEnumerable<ComboModel> lista = new ComboModel().ListaEstadoCivil();
            return new SelectList(lista, nameof(ComboModel.Value), nameof(ComboModel.Text));
        }

        public static SelectList ObtenerListaTiposRelacion()
        {
            IEnumerable<ComboModel> lista = new ComboModel().ListaTiposRelacion();
            return new SelectList(lista, nameof(ComboModel.Value), nameof(ComboModel.Text));
        }
    }
}
