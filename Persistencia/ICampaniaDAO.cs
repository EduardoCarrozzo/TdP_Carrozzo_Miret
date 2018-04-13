using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Persistencia
{
    public interface ICampaniaDAO
    {
        void Agregar(CampaniaDTO pCampania);
        CampaniaDTO Buscar(int pIdCampania);
        void Modificar(CampaniaDTO pCampania);
        void Eliminar(int pIdCampania);
    }
}
