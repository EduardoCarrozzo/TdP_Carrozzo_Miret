using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Persistencia.PersistenciaSQLServer
{
    class SQLServerFuenteDAO : IFuenteDAO
    {
        public void Insertar(IFuenteDTO pFuente) {}
          
        public IFuenteDTO Buscar(int pIdFuente) {}
          
        public void Modificar(int pIdFuente, IFuenteDTO pFuente) {}
          
        public void Eliminar(int pIdFuente) {}
        
    }
}
