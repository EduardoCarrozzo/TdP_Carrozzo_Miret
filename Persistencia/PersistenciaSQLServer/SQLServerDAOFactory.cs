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
        SqlConnection iConexion;
        SqlTransaction iTransaccion;
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

        public override IFuenteDAO FuenteDAO()
        {
            SQLServerFuenteDAO fuente = new SQLServerFuenteDAO(iConexion, iTransaccion);
            return fuente;
        }

        public override void IniciarConexion()
        {
            try
            {
                this.iConexion = new SqlConnection(iCadenaConexion);
                iConexion.Open();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
                throw new DAOException("No se pudo conectar a la base de datos");
            }
        }

        public override void ComenzarTransaccion()
        {
            if (this.iConexion == null)
            {
                throw new DAOException("No hay conexión abierta con la base de datos");
            }
            else
            {
                try
                {
                    this.iTransaccion = this.iConexion.BeginTransaction();
                }
                catch (SqlException)
                {
                    throw new DAOException("No se pudo comenzar la transacción con la base de datos");
                }
            }
        }

        public override void Commit()
        {
            if (this.iConexion == null)
            {
                throw new DAOException("No hay conexión abierta con la base de datos");
            }
            else
            {
                try
                {
                    this.iTransaccion.Commit();
                }
                catch (SqlException)
                {
                    throw new DAOException("No se pudo realizar el commit");
                }
            }
        }

        public override void RollBack()
        {
            if (this.iConexion == null)
            {
                throw new DAOException("No hay conexión abierta con la base de datos");
            }
            else
            {
                try
                {
                    this.iTransaccion.Rollback();
                }
                catch(SqlException)
                {
                    throw new DAOException("No se pudo realizar el RollBack");
                }
            }
            
        }

        public override void FinalizarConexion()
        {
            if(this.iConexion != null)
            {
                try
                {
                    this.iConexion.Close();
                }
                catch (SqlException)
                {
                    throw new DAOException("No se pudo cerrar la conexión");
                }
            }
        }
    }
}
