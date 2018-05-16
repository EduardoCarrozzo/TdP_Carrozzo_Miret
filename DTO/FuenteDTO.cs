using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public abstract class FuenteDTO
    {

        /// <summary>
        /// Código identificable de la fuente
        /// </summary>
        public int Codigo { get; set; }
        /// <summary>
        /// Último valor de la fuente
        /// </summary>
        public virtual string Valor { get; set; }

    }
}
