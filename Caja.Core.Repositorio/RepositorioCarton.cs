using Caja.Core.Entidades;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace Caja.Core.Repositorio
{
    public partial class RepositorioCarton : RepositorioBase
    {

        /// <summary>
        /// Inicializa una nueva instancia de la clase  <see cref="RepositorioCliente"/>.
        /// </summary>
        /// <param name="pConfiguracion">Representa un conjunto de propiedades de configuración de la aplicación de clave/valor.</param>
        /// <param name="pDispose">Indica si libera los recursos asignados para el contexto.</param>
        public RepositorioCarton(IConfiguration pConfiguracion, bool pDispose = true) : base(pConfiguracion, pDispose)
        {
        }

        /// <summary>
        /// Obtener la información de un cliente.
        /// </summary>
        /// <param name="pIdCliente">Identificador unico del vendedor.</param>
        /// <returns><see cref="Clientes"/></returns>
        public List<CartonJuego> Obtener(int pIdJuegoInicial, int pIdJuegoFinal, int pIdVendedor)
        {

            try
            {
                object[] xparams = {
                    new MySqlParameter("@parIdJuegoInicial", pIdJuegoInicial),
                    new MySqlParameter("@parIdJuegoFinal", pIdJuegoFinal),
                    new MySqlParameter("@parIdVendedor", pIdVendedor)
                };

                List<CartonJuego> cartones = Contexto
                                            .CartonJuego
                                            .FromSqlRaw("CALL psObtenerCartonesJuegos (@parIdJuegoInicial, @parIdJuegoFinal, @parIdVendedor)", xparams)
                                            .ToList();

                return cartones;
            }
            catch (Exception)
            {
                return new List<CartonJuego>();
            }

        }
        
        public bool GuardarActualizarLote(List<CartonJuego> cartones)
        {
             int IdVendedor = cartones[0].Idvendedor;

            List<Cartones> CartonesDb = Contexto.Cartones
                                           .Where(c => c.Idvendedor == IdVendedor)
                                           .ToList();

            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                 foreach (CartonJuego carton in cartones)
                 {
                    
                    var cartonUpd = CartonesDb.Find(c => c.IdCarton == carton.IdCarton);
                    cartonUpd.IdCliente = carton.IdCliente == 0 ? null : carton.IdCliente;
                    cartonUpd.Estado = carton.Estado;
                    cartonUpd.Actualizado = DateTime.Now;
                    Contexto.Cartones.Update(cartonUpd);
                 }

                 Contexto.SaveChanges();
                 transaction.Commit();
                 return true;
            }
            catch (Exception )
            {
                 transaction.Rollback();
                 return false;
            }
        }
    }
}





