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
        void Insertar(CampaniaDTO pCampania);
        CampaniaDTO Buscar(int pIdCampania);
        void Modificar(int pIdCampania, CampaniaDTO pCampania);
        void Eliminar(int pIdCampania);
    }
}
