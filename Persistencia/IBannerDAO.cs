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
        void Insertar(BannerDTO pBanner);
        BannerDTO Buscar(int pIdBanner);
        void Modificar(int pIdBanner, BannerDTO pBanner);
        void Eliminar(int pIdBanner);
    }
}
