﻿namespace Console_Reader.src.Services
{
    public interface IReturn
    {
        /// <summary>
        /// Metodo que devuelve las facturas pagadas en el mes de enero.
        /// </summary>
        void FacturasPagadasEnero();

        /// <summary>
        /// Metodo que devuelve el total de las facturas pagadas parseado
        /// </summary>
        void TotalPagadas();

        /// <summary>
        /// Metodo que devuelve el total de las facturas NO pagadas parseado
        /// </summary>
        void TotalNoPagadas();

        /// <summary>
        /// Metodo que devuelve las facturas pagadas en los primeros 6 meses del anio
        /// </summary>
        void FacturasPrimerSemestre();

        /// <summary>
        /// Metodo que devuelve las facturas pagadas en los Ultimos 6 meses del anio
        /// </summary>
        void FacturasSegundoSemestre();

        /// <summary>
        /// Metodo que imprime todos los resultados
        /// </summary>
        void PrintResult();
    }
}
