namespace Caja.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// IRepositorio que expone las operaciones básicas con la BD.
    /// </summary>
    /// <typeparam name="TEntidad">Tipo de entidad.</typeparam>
    public interface IRepositorio<TEntidad, TKeyType>
    {
        /// <summary>
        /// Inserta un objeto de tipo <see cref="TEntidad"/>.
        /// </summary>
        /// <param name="objEntidad"><see cref="TEntidad"/> que se insertará.</param>
        /// <returns>Id generado.</returns>
        TKeyType Insert(TEntidad objEntidad);

        /// <summary>
        /// Modifica un objeto de tipo <see cref="TEntidad"/>.
        /// </summary>
        /// <param name="objEntidad"><see cref="TEntidad"/> que se modificará.</param>
        /// <returns>Id del objeto modificado.</returns>
        TKeyType Update(TEntidad objEntidad);

        /// <summary>
        /// Busca todos los registros de tipo <see cref="TEntidad"/>.
        /// </summary>
        /// <returns>Coleccion de objetos de tipo <see cref="TEntidad"/>.</returns>
        IEnumerable<TEntidad> Find();

        /// <summary>
        /// Recupera un objeto de tipo <see cref="TEntidad"/>.
        /// </summary>
        /// <param name="id">Id del objeto.</param>
        /// <returns>Objeto de tipo <see cref="TEntidad"/>.</returns>
        TEntidad FindOne(TKeyType id);
    }
}

