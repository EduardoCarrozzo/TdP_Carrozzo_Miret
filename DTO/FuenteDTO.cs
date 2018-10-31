using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public abstract class FuenteDTO
    {

        public int iIdFuente { get; set; }

        public virtual string Valor { get; set; }

        public abstract bool Actualizable();

      //  public abstract void Actualizar(); no es comun a todos los tipos de fuentes

    }
}
