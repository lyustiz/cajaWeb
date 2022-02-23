using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Activacionesno
    {
        public short IdActivacion { get; set; }
        public short IdEmpresa { get; set; }
        public short? Caja { get; set; }
        public short? CorreccionPremio { get; set; }
        public short? PlanillaReal { get; set; }
        public short? Beano { get; set; }
        public short Modalidad { get; set; }
        public short? ModulosGratis { get; set; }
        public short? ValoresPremio { get; set; }
        public short? Telebingo { get; set; }
        public short? AlgunosCaja { get; set; }
        public short? Cartones { get; set; }
        public short? Piramides { get; set; }
        public short? Tarjeton { get; set; }
        public short? PiramideTarjeton { get; set; }
        public int? Formato { get; set; }
        public int? Secuenciales { get; set; }
        public short? CambiarCentro { get; set; }
        public short? ValorPremioCero { get; set; }
        public int? Simultanea { get; set; }
        public short? CalcularAdicionales { get; set; }
        public short? ModificarValorAdicional { get; set; }
        public short? IncluirSoloRegistrados { get; set; }
        public short? MostrarCartonesSegundo { get; set; }
        public int? Jornadas { get; set; }
        public short? PedirCartonesJuego { get; set; }
        public int? MostrarContadorSegundo { get; set; }
        public short? BloquearPorPuerto { get; set; }
        public short MostrarAdcionales { get; set; }
        public short? TipoPlanilla { get; set; }
        public short? EscritorioExtendido { get; set; }
        public short? AdicionalRey { get; set; }
        public short? ImpresionTexto { get; set; }
        public short? RespetarCaja { get; set; }
        public short? PedirDinero { get; set; }
        public short? AvanzarVerticales { get; set; }
        public short? Pantalla { get; set; }
        public short? PremioTiquete { get; set; }
        public int? MostarReporteCaja { get; set; }
        public short? PedirDineroCaja { get; set; }
        public short? CargarCartones { get; set; }
        public short? SiempreActivoRey { get; set; }
        public short? PosicionExtendido { get; set; }
        public short? LecturaActumaticaBalota { get; set; }
        public short DigitacionTecladoLectura { get; set; }
        public short? TiempoActivacion { get; set; }
        public short? TableroNuevoActivo { get; set; }
        public short? PedirTipoPleno { get; set; }
        public short? DescontarDeProducido { get; set; }
        public short? DejaVerPlanilla { get; set; }
        public short? VirtualEnExtendido { get; set; }
        public short? VirtualTotalExtendido { get; set; }
        public short? PreLiquidacion { get; set; }
        public short PreLiquidacionAuto { get; set; }
        public short? PreImprimirTiquete { get; set; }
        public short? RevisarRegistroUsuarios { get; set; }
        public int? PremioNumerico { get; set; }

        public virtual Empresas IdEmpresaNavigation { get; set; }
    }
}
