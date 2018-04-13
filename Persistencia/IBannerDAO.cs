using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Persistencia
{
    public interface IBannerDAO
    {
        void Agregar(BannerDTO pBanner);
        BannerDTO Buscar(int pIdBanner);
        void Modificar(BannerDTO pBanner);
        void Eliminar(int pIdBanner);
    }
}
