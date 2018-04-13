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
        void Agregar(IFuenteDTO pFuente);
        IFuenteDTO Buscar(int pIdFuente);
        void Modificar(IFuenteDTO pFuente);
        void Eliminar(int pIdFuente);
    }
}
