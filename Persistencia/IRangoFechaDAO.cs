using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Persistencia
{
    public interface IRangoFechaDAO
    {
        void Agregar(RangoFechaDTO pRangoFecha);
        void Eliminar(int pIdRangoFecha);
        RangoFechaDTO Buscar(int pIdRangoFecha);
        List<RangoFechaDTO> Buscar(List<int> pListaIdRangos);
    }
}
