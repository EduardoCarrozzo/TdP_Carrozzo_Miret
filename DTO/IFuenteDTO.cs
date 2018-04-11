﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public interface IFuenteDTO : IEquatable<IFuenteDTO>
    {
        /// <summary>
        /// Texto de la fuente
        /// </summary>
        /// <returns>Tipo de dato string que representa el valor de la fuente</returns>
        string Texto();

        /// <summary>
        /// Codigo de la fuente
        /// </summary>
        int Codigo { get; set; }

        /// <summary>
        /// Determina si la fuente debe actualizarse periódicamente (fuente externa)
        /// </summary>
        /// <returns>Tipo de dato booleano que representa si la fuente debe actualizarse</returns>
        bool Actualizable();

        /// <summary>
        /// Actualiza el valor de la fuente si corresponde
        /// </summary>
        void Actualizar();
    }
}
