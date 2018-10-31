using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Persistencia
{
    public interface IFuenteDAO
    {
        public void Agregar(FuenteDTO pFuente);
        public FuenteDTO Buscar(int pIdFuente); //ver parámetros (no hay nada en el diagrama)
        void Modificar(FuenteDTO pFuente);
        void Eliminar(int pIdFuente);
    }
}
