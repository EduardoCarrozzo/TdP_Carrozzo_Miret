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
        void Agregar(FuenteDTO pFuente);
        FuenteDTO Buscar(int pIdFuente);
        void Modificar(FuenteDTO pFuente);
        void Eliminar(int pIdFuente);
    }
}
