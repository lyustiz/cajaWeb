using Caja.Core.Entidades;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Caja.MVC.Core.Models
{
    public class ProgramacionJuegoModel
    {
        [DisplayName("Número Juego")]
        public int NumeroJuego { get; set; }

        [DisplayName("Fecha Juego")]        
        public DateTime FechaJuego { get; set; }

        [DisplayName("Valor Cartón")]
        public double ValorCarton { get; set; }

        [DisplayName("Valor Módulo")]
        public double ValorModulo { get; set; }

        [DisplayName("Serie")]
        public int IdSerie { get; set; }

        [DisplayName("Cartón Inicial")]
        public int CartonInicial { get; set; }

        [DisplayName("Cartón Final")]
        public int CartonFinal { get; set; }

        [DisplayName("Hoja Inicial")]
        public int HojaInicial { get; set; }

        [DisplayName("Hoja Final")]
        public int HojaFinal { get; set; }

        public List<Figuras> Figuras { get; set; }

        public SelectList ListaProgramaciones { get; set; }

        public SelectList ListaSeries { get; set; }

        public SelectList ListaFiguras { get; set; }

        public ProgramacionJuegoModel ToModel(Programacionjuegos registro)
        {
            var programacion = new ProgramacionJuegoModel()
            {
                NumeroJuego = registro.IdProgramacionJuego,
                FechaJuego = registro.FechaProgramada,
                ValorCarton = registro.ValorCarton,
                ValorModulo = registro.ValorModulo,
                IdSerie = registro.IdSerie,
                CartonInicial = registro.CartonInicial,
                CartonFinal = registro.CartonFinal,
                HojaInicial = registro.HojaInicial,
                HojaFinal = registro.HojaFinal                
            };

            if (registro.Programacionjuegosfiguras.ToList().NotIsNullOrZeroItems())
            {
                programacion.Figuras = new List<Figuras>();

                foreach (var figura in registro.Programacionjuegosfiguras)
                {
                    programacion.Figuras.Add(new Figuras() { Id = figura.IdPlenoAutomatico, 
                        Nombre = figura.IdPlenoAutomaticoNavigation?.Nombre, 
                        ValorPremio = figura.ValorPremio });
                }
            }

            return programacion;
        }

        public List<ProgramacionJuegoModel> ToModelList(List<Programacionjuegos> listado)
        {
            List<ProgramacionJuegoModel> modelo = new();
            listado.ToList().ForEach(x => modelo.Add(ToModel(x)));

            return modelo;
        }
    }

    public class Figuras
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double ValorPremio { get; set; }
    }
}
