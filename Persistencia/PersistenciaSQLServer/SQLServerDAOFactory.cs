using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.PersistenciaSQLServer
{
    class SQLServerDAOFactory : DAOFactory
    {
        private SqlConnection iConexion;
        private SqlCommand iTransaccion;
        private String iCadenaConexion = "Data Source = GIULIANA\\SQLEXPRESS;Initial Catalog = Taller; Integrated Security =True";

        public override IBannerDAO BannerDAO()
        {
            SQLServerBannerDAO banner = new SQLServerBannerDAO(iConexion, iTransaccion);
            return banner;
        }

        public override ICampaniaDAO CampaniaDAO()
        {
            SQLServerCampaniaDAO campania = new SQLServerCampaniaDAO(iConexion, iTransaccion);
            return campania;
        }

        public override void IniciarConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(iCadenaConexion);
                conexion.Open();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
                throw new DAOException("No se pudo conectar a la base de datos");
            }
        }

    }
}
