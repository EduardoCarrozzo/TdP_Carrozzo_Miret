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
        void Insertar(IFuenteDTO pFuente);
        IFuenteDTO Buscar(int pIdFuente);
        void Modificar(int pIdFuente, IFuenteDTO pFuente);
        void Eliminar(int pIdFuente);
    }
}
