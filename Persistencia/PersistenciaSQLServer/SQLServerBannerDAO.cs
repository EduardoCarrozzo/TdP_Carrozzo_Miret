using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Persistencia.PersistenciaSQLServer
{
    class SQLServerBannerDAO : IBannerDAO
    {
        public void Insertar(BannerDTO pBanner) {}
         
          public BannerDTO Buscar(int pIdBanner) {}
          
          public void Modificar(int pIdBanner, BannerDTO pBanner) {}
          
          public void Eliminar(int pIdBanner) {}
         
    }
}
