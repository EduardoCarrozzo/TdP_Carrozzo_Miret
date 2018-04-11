using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace Persistencia.PersistenciaSQLServer
{
    class SQLServerBannerDAO : IBannerDAO
    {
        private SqlConnection iConexion;
        private SqlCommand iTransaccion = null;

        public SQLServerBannerDAO(SqlConnection pConexion, SqlCommand pTransaccion)
        {
            this.iConexion = pConexion;
            this.iTransaccion = pTransaccion;
        }

        public void Insertar(BannerDTO pBanner) {}
         
        public BannerDTO Buscar(int pIdBanner) {}
          
        public void Modificar(int pIdBanner, BannerDTO pBanner) {}
          
        public void Eliminar(int pIdBanner) {}
         
    }
}
